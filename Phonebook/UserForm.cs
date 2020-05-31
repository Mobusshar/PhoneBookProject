using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using Phonebook.Classes;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace Phonebook
{
    public partial class UserForm : Form
    {
        bool NewUser = false;
        bool ChangeUser = false;
        bool ChangeInfo = false;

        public UserForm(bool newUser, bool changeUser, bool changeInfo)
        {
            InitializeComponent();
            /////////////////////

            this.NewUser = newUser;
            this.ChangeInfo = changeInfo;
            this.ChangeUser = changeUser;

            if (NewUser)
            {
                this.Text = "Add new user";
                labelPass1.Text = "Password :";
                labelPass2.Text = "Confirm Password :";
                checkBoxForgetPass.Enabled = false;
            }
            else if (ChangeUser)
            {
                this.Text = "Select User";
                labelPass1.Text = "Password :";
                labelPass2.Text = "New Password :";
                labelPass2.Enabled = textBoxPassword2.Enabled = false;
                labelEmail.Enabled = textBoxEmail.Enabled = false;
            }
            else if (ChangeInfo)
            {
                this.Text = "Change User Information";
                labelPass1.Text = "Old Password :";
                labelPass2.Text = "New Password :";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                #region Forgets the password

                if (checkBoxForgetPass.Enabled && checkBoxForgetPass.Checked)
                {
                    if (textBoxUsername.Text.Trim() == "")
                    {
                        errorProvider1.SetError(this.textBoxUsername, "Please enter your username");
                        textBoxUsername.Focus();
                        return;
                    }
                    errorProvider1.Clear();

                    var user = Variables.xDocument.Descendants("User").Where(q => q.Attribute("UserName").Value.ToLower() == textBoxUsername.Text.Trim().ToLower());

                    if (user.Count() < 1)
                    {
                        errorProvider1.SetError(this.textBoxUsername, "This username didn't exist in data base !");
                        return;
                    }

                    string password = user.First().Attribute("Password").Value;

                    try
                    {
                        NetworkCredential loginInfo = new NetworkCredential("username", "password");
                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("sth@gmail.com");
                        msg.To.Add(new MailAddress(user.First().Attribute("Email").Value));
                        msg.Subject = "Phonebook Password";
                        msg.Body = "Yours Password = " + password;
                        msg.IsBodyHtml = true;
                        SmtpClient client = new SmtpClient("smtp.gmail.com");
                        client.EnableSsl = true;
                        client.UseDefaultCredentials = false;
                        client.Credentials = loginInfo;
                        client.Send(msg);

                        MessageBox.Show("Your password have sended to your email", "Email sended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    return;
                }

                #endregion

                #region add new user

                else if (this.NewUser)
                {
                    if (textBoxUsername.Text.Trim() == "" && textBoxUsername.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxUsername, "Please enter username");
                        return;
                    }
                    else if (textBoxPassword1.Text.Trim() == "" && textBoxPassword1.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxPassword1, "Please enter password");
                        return;
                    }
                    else if (textBoxPassword2.Text.Trim() == "" && textBoxPassword2.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxPassword2, "Please enter confirm password");
                        return;
                    }
                    else if (textBoxPassword2.Text.Trim() != textBoxPassword1.Text.Trim())
                    {
                        errorProvider1.SetError(this.textBoxPassword1, "Your passwords must be match");
                        errorProvider1.SetError(this.textBoxPassword2, "Your passwords must be match");
                        return;
                    }
                    else if (textBoxEmail.Text.Trim() == "" && textBoxEmail.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxEmail, "Please enter a valid Email");
                        return;
                    }

                    if (!File.Exists(Variables.DBFile))
                    {
                        Variables.xDocument = new XDocument(

                            new XComment("\n Don't edit manually \n"),

                            new XElement("PhoneBook",

                                new XElement("Users",
                                    new XElement("User",
                                        new XAttribute("ID", "01"),
                                        new XAttribute("UserName", textBoxUsername.Text.Trim()),
                                        new XAttribute("Password", textBoxPassword1.Text.Trim()),
                                        new XAttribute("Email", textBoxEmail.Text.Trim()),
                                        new XAttribute("RegDate", DateTime.Now.ToString()))),

                                new XElement("Settings",
                                    new XElement("Setting",
                                        new XAttribute("UserID", "01"),
                                        new XAttribute("RightToLeft", "NO"),
                                        new XAttribute("Dates", "Persian"),
                                        new XAttribute("FontSize", "10"))),

                                new XElement("Items")));

                        Variables.CurrentUserID = "01";
                    }
                    else
                    {
                        Variables.xDocument = XDocument.Parse(TripleDES.DecryptFromFile(Variables.DBFile, TripleDES.ByteKey, TripleDES.IV));

                        var SameUserQuery = from q in Variables.xDocument.Descendants("User")
                                            where q.Attribute("UserName").Value.ToLower() == textBoxUsername.Text.Trim().ToLower()
                                            select q;
                        if (SameUserQuery.Count() >= 1)
                        {
                            errorProvider1.SetError(this.textBoxUsername, "This username has been existed, please choose another one");
                            return;
                        }

                        int maxID = 0;
                        try
                        {
                            maxID = (from q in Variables.xDocument.Descendants("User")
                                     select (int)q.Attribute("ID")).Max();
                        }
                        catch { }
                        maxID++;
                        Variables.CurrentUserID = maxID.ToString();

                        XElement xElement = new XElement("User",
                                                new XAttribute("ID", maxID),
                                                new XAttribute("UserName", textBoxUsername.Text.Trim()),
                                                new XAttribute("Password", textBoxPassword1.Text.Trim()),
                                                new XAttribute("Email", textBoxEmail.Text.Trim()),
                                                new XAttribute("RegDate", DateTime.Now.ToString()));
                        var usersElement = (from q in Variables.xDocument.Descendants("Users")
                                            select q).First();
                        usersElement.Add(xElement);

                        xElement = new XElement("Setting",
                                        new XAttribute("UserID", maxID),
                                        new XAttribute("RightToLeft", "NO"),
                                        new XAttribute("Dates", "Persian"),
                                        new XAttribute("FontSize", "10"));
                        var settingsElement = (from q in Variables.xDocument.Descendants("Settings")
                                               select q).First();
                        settingsElement.Add(xElement);
                    }

                    Variables.CurrentUserName = textBoxUsername.Text.Trim();

                    TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
                    //Variables.xDocument.Save("debug.xml");
                }

                #endregion

                #region change user

                else if (this.ChangeUser)
                {
                    if (Variables.xDocument == null)
                    {
                        MessageBox.Show("Your Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (textBoxUsername.Text.Trim() == "")
                    {
                        errorProvider1.SetError(this.textBoxUsername, "Please enter username");
                        return;
                    }
                    else if (textBoxPassword1.Text.Trim() == "" && textBoxPassword1.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxPassword1, "Please enter password");
                        return;
                    }

                    var query = from q in Variables.xDocument.Descendants("User")
                                where textBoxUsername.Text.Trim().ToLower() == q.Attribute("UserName").Value.ToLower()
                                && textBoxPassword1.Text.Trim().ToLower() == q.Attribute("Password").Value.ToLower()
                                select q;
                    if (query.Count() == 1)
                    {
                        Variables.CurrentUserID = query.First().Attribute("ID").Value;
                        Variables.CurrentUserName = textBoxUsername.Text.Trim();
                    }
                    else
                    {
                        Variables.CurrentUserID = "";
                        Variables.CurrentUserName = "";
                        MessageBox.Show("Your Username or Password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                #endregion

                #region change info

                else if (this.ChangeInfo)
                {
                    bool changePassword = true;

                    if (textBoxUsername.Text.Trim() == "" && textBoxUsername.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxUsername, "Please enter the username");
                        return;
                    }
                    else if (textBoxEmail.Text.Trim() == "" && textBoxEmail.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxEmail, "Please enter a valid Email");
                        return;
                    }
                    else if (textBoxPassword1.Text.Trim() == textBoxPassword2.Text.Trim() && textBoxPassword2.Text.Trim() == "")
                    {
                        changePassword = false;
                    }
                    else if (textBoxPassword1.Text.Trim() == "" && textBoxPassword1.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxPassword1, "Please enter old password");
                        return;
                    }
                    else if (textBoxPassword2.Text.Trim() == "" && textBoxPassword2.Enabled)
                    {
                        errorProvider1.SetError(this.textBoxPassword2, "Please enter new password");
                        return;
                    }

                    errorProvider1.Clear();

                    var query = (from q in Variables.xDocument.Descendants("User")
                                 where q.Attribute("ID").Value == Variables.CurrentUserID
                                 select q).First();
                    string oldPassword = query.Attribute("Password").Value;

                    if (oldPassword.ToLower() != textBoxPassword1.Text.Trim().ToLower() && changePassword)
                    {
                        errorProvider1.SetError(this.textBoxPassword1, "The old password is wrong");
                        return;
                    }
                    else if (oldPassword == textBoxPassword1.Text.Trim() && changePassword)
                    {
                        query.Attribute("UserName").Value = textBoxUsername.Text.Trim();
                        query.Attribute("Password").Value = textBoxPassword2.Text.Trim();
                        query.Attribute("Email").Value = textBoxEmail.Text.Trim();
                    }
                    else if (!changePassword)
                    {
                        query.Attribute("UserName").Value = textBoxUsername.Text.Trim();
                        query.Attribute("Email").Value = textBoxEmail.Text.Trim();
                    }

                    Variables.CurrentUserID = query.Attribute("ID").Value;
                    Variables.CurrentUserName = textBoxUsername.Text.Trim();

                    TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
                    //Variables.xDocument.Save("debug.xml");
                }

                #endregion

                this.Close();
            }
            catch (Exception ex)
            {
                Variables.CurrentUserID = Variables.CurrentUserName = "";
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }
    }
}
