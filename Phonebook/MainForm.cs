using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Phonebook.Classes;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using System.Globalization;

namespace Phonebook
{
    public partial class MainForm : Form
    {
        float FontSize = 10.0f;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Buttons

        void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                ItemForm newForm = new ItemForm(true, false);
                newForm.Font = new Font(this.Font.Name, this.FontSize, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
                newForm.Text = "Add New Item";
                newForm.lableRegDate.Text = christianToolStripMenuItem.Checked ? DateTime.Now.ToString() : ConvertToPersianDate(DateTime.Now.ToString());
                newForm.ShowDialog();
                LoadPhoneBookItems();
                int contactsNumbers = Variables.xDocument.Descendants("Item").Where(q => q.Attribute("UserID").Value == Variables.CurrentUserID).Count();
                this.Text = Variables.Caption + Variables.CurrentUserName + " : " + contactsNumbers.ToString() + " Contacts";
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void buttonClearSearchTextBox_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            LoadPhoneBookItems();
        }

        void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count < 1) return;

                string id = listView1.SelectedItems[0].Name.Replace("Item", "");

                var item = (from q in Variables.xDocument.Descendants("Item")
                            where q.Attribute("UserID").Value == Variables.CurrentUserID && q.Attribute("ID").Value == id
                            select q).First();
                if (item == null) return;

                ItemForm editForm = new ItemForm(false, true);

                editForm.Font = new Font(this.Font.Name, this.FontSize, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
                editForm.Text = "Edit Item";

                editForm.textBoxAddress.Text = item.Attribute("Address").Value;
                editForm.textBoxEMail.Text = item.Attribute("Email").Value;
                editForm.textBoxMobile.Text = item.Attribute("Mobile").Value;
                editForm.textBoxName.Text = item.Attribute("Name").Value;
                editForm.textBoxPhone.Text = item.Attribute("Phone").Value;
                editForm.lableRegDate.Text = christianToolStripMenuItem.Checked ? item.Attribute("RegDate").Value : ConvertToPersianDate(item.Attribute("RegDate").Value);

                editForm.ItemID = id;

                editForm.ShowDialog();

                LoadPhoneBookItems();
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count < 1) return;
                if (MessageBox.Show("Are you sure to delete the item ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                string id = listView1.SelectedItems[0].Name.Replace("Item", "");
                var item = (from q in Variables.xDocument.Descendants("Item")
                            where q.Attribute("UserID").Value == Variables.CurrentUserID && q.Attribute("ID").Value == id
                            select q).First();
                item.Remove();
                TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
                //Variables.xDocument.Save("debug.xml");
                LoadPhoneBookItems();
                int contactsNumbers = Variables.xDocument.Descendants("Item").Where(q => q.Attribute("UserID").Value == Variables.CurrentUserID).Count();
                this.Text = Variables.Caption + Variables.CurrentUserName + " : " + contactsNumbers.ToString() + " Contacts";
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        #endregion

        #region Menu Strip Events

        #region Settings

        void rightToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rightToLeftToolStripMenuItem.Checked = true;
                leftToRightToolStripMenuItem.Checked = false;
                textBoxSearch.RightToLeft = RightToLeft.Yes;
                listView1.RightToLeft = RightToLeft.Yes;

                var query = (from q in Variables.xDocument.Descendants("Setting")
                             where q.Attribute("UserID").Value == Variables.CurrentUserID
                             select q).First();
                query.Attribute("RightToLeft").Value = "Yes";
                TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
                //Variables.xDocument.Save("debug.xml");
            }
            catch { }
        }

        void leftToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                leftToRightToolStripMenuItem.Checked = true;
                rightToLeftToolStripMenuItem.Checked = false;
                textBoxSearch.RightToLeft = RightToLeft.No;
                listView1.RightToLeft = RightToLeft.No;

                var query = (from q in Variables.xDocument.Descendants("Setting")
                             where q.Attribute("UserID").Value == Variables.CurrentUserID
                             select q).First();
                query.Attribute("RightToLeft").Value = "NO";
                TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
            }
            catch { }
        }

        void toolStripMenuItemFontSize_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripMenuItemFontSize8.Checked = toolStripMenuItemFontSize10.Checked = toolStripMenuItemFontSize12.Checked = toolStripMenuItemFontSize14.Checked = toolStripMenuItemFontSize16.Checked = toolStripMenuItemFontSize18.Checked = false;
                ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
                menuItem.Checked = true;
                this.FontSize = float.Parse(menuItem.Text.Trim());
                if (this.Font.Size != this.FontSize)
                {
                    this.Font = new Font(this.Font.Name, this.FontSize, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
                    var query = (from q in Variables.xDocument.Descendants("Setting")
                                 where q.Attribute("UserID").Value == Variables.CurrentUserID
                                 select q).First();
                    query.Attribute("FontSize").Value = this.FontSize.ToString();
                    TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
                    //Variables.xDocument.Save("debug.xml");
                }
            }
            catch { }
        }

        void christianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            christianToolStripMenuItem.Checked = true;
            persianToolStripMenuItem.Checked = false;

            var query = (from q in Variables.xDocument.Descendants("Setting")
                         where q.Attribute("UserID").Value == Variables.CurrentUserID
                         select q).First();
            query.Attribute("Dates").Value = "Christian";
            TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
            //Variables.xDocument.Save("debug.xml");
        }

        void persianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            christianToolStripMenuItem.Checked = false;
            persianToolStripMenuItem.Checked = true;

            var query = (from q in Variables.xDocument.Descendants("Setting")
                         where q.Attribute("UserID").Value == Variables.CurrentUserID
                         select q).First();
            query.Attribute("Dates").Value = "Persian";
            TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
            //Variables.xDocument.Save("debug.xml");
        }

        #endregion

        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UserForm newUserForm = new UserForm(true, false, false);
                newUserForm.Font = new Font(this.Font.Name, this.FontSize, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
                newUserForm.ShowDialog();
                ApplySettings();
                LoadPhoneBookItems();

                if (Variables.CurrentUserName != "" && Variables.CurrentUserID != "")
                {
                    int contactsNumbers = Variables.xDocument.Descendants("Item").Where(q => q.Attribute("UserID").Value == Variables.CurrentUserID).Count();
                    this.Text = Variables.Caption + Variables.CurrentUserName + " : " + contactsNumbers.ToString() + " Contacts";
                    DisableEnableControls(true);
                }
                else
                    DisableEnableControls(false);
            }
            catch (Exception ex)
            {
                DisableEnableControls(false);
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UserForm userForm = new UserForm(false, true, false);
                userForm.Font = new Font(this.Font.Name, this.FontSize, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
                userForm.ShowDialog();
                ApplySettings();
                LoadPhoneBookItems();

                if (Variables.CurrentUserName != "" && Variables.CurrentUserID != "")
                {
                    int contactsNumbers = Variables.xDocument.Descendants("Item").Where(q => q.Attribute("UserID").Value == Variables.CurrentUserID).Count();
                    this.Text = Variables.Caption + Variables.CurrentUserName + " : " + contactsNumbers.ToString() + " Contacts";
                    DisableEnableControls(true);
                }
                else
                    DisableEnableControls(false);
            }
            catch (Exception ex)
            {
                DisableEnableControls(false);
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void changeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UserForm changeInfoForm = new UserForm(false, false, true);
                changeInfoForm.Font = new Font(this.Font.Name, this.FontSize, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);

                var userElement = from q in Variables.xDocument.Descendants("User")
                                  where q.Attribute("ID").Value == Variables.CurrentUserID
                                  select q;
                string username = userElement.First().Attribute("UserName").Value;
                string email = userElement.First().Attribute("Email").Value;

                changeInfoForm.textBoxUsername.Text = username;
                changeInfoForm.textBoxEmail.Text = email;
                changeInfoForm.ShowDialog();

                if (Variables.CurrentUserName != "" && Variables.CurrentUserID != "")
                {
                    int contactsNumbers = Variables.xDocument.Descendants("Item").Where(q => q.Attribute("UserID").Value == Variables.CurrentUserID).Count();
                    this.Text = Variables.Caption + Variables.CurrentUserName + " : " + contactsNumbers.ToString() + " Contacts";
                    DisableEnableControls(true);
                }
                else
                    DisableEnableControls(false);
            }
            catch (Exception ex)
            {
                DisableEnableControls(false);
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void aboutProgrammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mds-soft.persianblog.ir/");
        }

        #endregion

        void LoadPhoneBookItems()
        {
            try
            {
                listView1.Items.Clear();

                var items = from q in Variables.xDocument.Descendants("Item")
                            where q.Attribute("UserID").Value == Variables.CurrentUserID
                            select q;
                if (items.Count() < 1)
                    return;

                foreach (var item in items)
                {
                    ListViewItem listViewItems;

                    if (christianToolStripMenuItem.Checked)
                        listViewItems = new ListViewItem(new string[] 
                                        { item.Attribute("Name").Value, 
                                          item.Attribute("Phone").Value,  
                                          item.Attribute("Mobile").Value,  
                                          item.Attribute("Email").Value, 
                                          item.Attribute("Address").Value,
                                          item.Attribute("RegDate").Value});
                    else
                        listViewItems = new ListViewItem(new string[] 
                                        { item.Attribute("Name").Value, 
                                          item.Attribute("Phone").Value,  
                                          item.Attribute("Mobile").Value,  
                                          item.Attribute("Email").Value, 
                                          item.Attribute("Address").Value,
                                          ConvertToPersianDate(item.Attribute("RegDate").Value)});

                    listViewItems.Name = "Item" + item.Attribute("ID").Value;
                    listView1.Items.Add(listViewItems);
                }
            }
            catch (Exception ex)
            {
                DisableEnableControls(false);
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void ApplySettings()
        {
            try
            {
                if (Variables.xDocument == null)
                {
                    DisableEnableControls(false);
                    return;
                }

                var Settings = (from q in Variables.xDocument.Descendants("Setting")
                                where q.Attribute("UserID").Value == Variables.CurrentUserID
                                select q).First();

                if (Settings.Attribute("RightToLeft").Value == "Yes")
                    rightToLeftToolStripMenuItem_Click(null, null);
                else
                    leftToRightToolStripMenuItem_Click(null, null);

                if (Settings.Attribute("Dates").Value == "Persian")
                {
                    persianToolStripMenuItem.Checked = true;
                    christianToolStripMenuItem.Checked = false;
                }
                else
                {
                    persianToolStripMenuItem.Checked = false;
                    christianToolStripMenuItem.Checked = true;
                }

                this.FontSize = float.Parse(Settings.Attribute("FontSize").Value);
                this.Font = new Font(this.Font.Name, this.FontSize, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
                if (this.FontSize == 8)
                {
                    toolStripMenuItemFontSize8.Checked = true;
                    toolStripMenuItemFontSize10.Checked = false;
                    toolStripMenuItemFontSize12.Checked = false;
                    toolStripMenuItemFontSize14.Checked = false;
                    toolStripMenuItemFontSize16.Checked = false;
                    toolStripMenuItemFontSize18.Checked = false;
                }
                else if (this.FontSize == 10)
                {
                    toolStripMenuItemFontSize8.Checked = false;
                    toolStripMenuItemFontSize10.Checked = true;
                    toolStripMenuItemFontSize12.Checked = false;
                    toolStripMenuItemFontSize14.Checked = false;
                    toolStripMenuItemFontSize16.Checked = false;
                    toolStripMenuItemFontSize18.Checked = false;
                }
                else if (this.FontSize == 12)
                {
                    toolStripMenuItemFontSize8.Checked = false;
                    toolStripMenuItemFontSize10.Checked = false;
                    toolStripMenuItemFontSize12.Checked = true;
                    toolStripMenuItemFontSize14.Checked = false;
                    toolStripMenuItemFontSize16.Checked = false;
                    toolStripMenuItemFontSize18.Checked = false;
                }
                else if (this.FontSize == 14)
                {
                    toolStripMenuItemFontSize8.Checked = false;
                    toolStripMenuItemFontSize10.Checked = false;
                    toolStripMenuItemFontSize12.Checked = false;
                    toolStripMenuItemFontSize14.Checked = true;
                    toolStripMenuItemFontSize16.Checked = false;
                    toolStripMenuItemFontSize18.Checked = false;
                }
                else if (this.FontSize == 16)
                {
                    toolStripMenuItemFontSize8.Checked = false;
                    toolStripMenuItemFontSize10.Checked = false;
                    toolStripMenuItemFontSize12.Checked = false;
                    toolStripMenuItemFontSize14.Checked = false;
                    toolStripMenuItemFontSize16.Checked = true;
                    toolStripMenuItemFontSize18.Checked = false;
                }
                else if (this.FontSize == 18)
                {
                    toolStripMenuItemFontSize8.Checked = false;
                    toolStripMenuItemFontSize10.Checked = false;
                    toolStripMenuItemFontSize12.Checked = false;
                    toolStripMenuItemFontSize14.Checked = false;
                    toolStripMenuItemFontSize16.Checked = false;
                    toolStripMenuItemFontSize18.Checked = true;
                }
            }
            catch (Exception ex)
            {
                DisableEnableControls(false);
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Variables.DBFile))
                {
                    newUserToolStripMenuItem_Click(null, null);
                    return;
                }

                Variables.xDocument = XDocument.Parse(TripleDES.DecryptFromFile(Variables.DBFile, TripleDES.ByteKey, TripleDES.IV));

                var users = from q in Variables.xDocument.Descendants("User")
                            select q;

                if (users.Count() < 1)//No user exist
                {
                    newUserToolStripMenuItem_Click(null, null);
                    return;
                }
                else//More than one user exist
                {
                    changeUserToolStripMenuItem_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                DisableEnableControls(false);
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
                try
                {
                    File.Delete(Variables.DBFile);
                }
                catch
                {
                    MessageBox.Show("Please delete the DataBase file", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        void DisableEnableControls(bool enable)
        {
            if (enable)
            {
                changeInfoToolStripMenuItem.Enabled = settingsToolStripMenuItem.Enabled = true;
                textBoxSearch.Enabled = listView1.Enabled = true;
                buttonNew.Enabled = true;
            }
            else
            {
                changeInfoToolStripMenuItem.Enabled = settingsToolStripMenuItem.Enabled = false;
                textBoxSearch.Enabled = listView1.Enabled = false;
                buttonNew.Enabled = false;
            }
        }

        string ConvertToPersianDate(string stringDate)
        {
            try
            {
                DateTime dateTime = DateTime.Parse(stringDate);
                PersianCalendar persianCalendar = new PersianCalendar();
                var str = persianCalendar.GetYear(dateTime).ToString() + " / " +
                                            persianCalendar.GetMonth(dateTime).ToString() + " / " +
                                            persianCalendar.GetDayOfMonth(dateTime).ToString() + "   " +
                                            persianCalendar.GetHour(dateTime).ToString() + ":" +
                                            persianCalendar.GetMinute(dateTime).ToString() + ":" +
                                            persianCalendar.GetSecond(dateTime).ToString();
                return str;
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
                return "";
            }
        }

        #region listview

        void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text.Trim() == "")
                {
                    LoadPhoneBookItems();
                    return;
                }

                listView1.Items.Clear();

                var query = from q in Variables.xDocument.Descendants("Item")
                            where q.Attribute("UserID").Value == Variables.CurrentUserID &&
                                (q.Attribute("Name").Value.ToLower().Contains(textBoxSearch.Text.Trim().ToLower()) ||
                                 q.Attribute("Phone").Value.ToLower().Contains(textBoxSearch.Text.Trim().ToLower()) ||
                                 q.Attribute("Mobile").Value.ToLower().Contains(textBoxSearch.Text.Trim().ToLower()) ||
                                 q.Attribute("Email").Value.ToLower().Contains(textBoxSearch.Text.Trim().ToLower()) ||
                                 q.Attribute("Address").Value.ToLower().Contains(textBoxSearch.Text.Trim().ToLower()))
                            select q;
                if (query.Count() < 1) return;

                foreach (var item in query)
                {
                    ListViewItem listViewItems = new ListViewItem(new string[] 
                                                        { item.Attribute("Name").Value, 
                                                          item.Attribute("Phone").Value, 
                                                          item.Attribute("Mobile").Value, 
                                                          item.Attribute("Email").Value, 
                                                          item.Attribute("Address").Value,
                                                          item.Attribute("RegDate").Value});
                    listViewItems.Name = "Item" + item.Attribute("ID").Value;
                    listView1.Items.Add(listViewItems);
                }
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var item = listView1.GetItemAt(e.X, e.Y);
            buttonEdit_Click(null, null);
        }

        #endregion

    }
}
