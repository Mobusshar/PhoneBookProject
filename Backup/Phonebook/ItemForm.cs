using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Phonebook.Classes;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Imaging;

namespace Phonebook
{
    public partial class ItemForm : Form
    {
        public string ItemID = "";

        bool NewItem = false;
        bool EditItem = false;

        public ItemForm(bool newItem, bool editItem)
        {
            InitializeComponent();
            this.tableLayoutPanel1.CellPaint += new TableLayoutCellPaintEventHandler(tableLayoutPanel1_CellPaint);

            //////////////////////
            this.NewItem = newItem;
            this.EditItem = editItem;

            if (NewItem)
                this.Text = "Add New Item";

            else if (EditItem)
                this.Text = "Edit Item";

        }

        void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            try
            {
                if (e.Row % 2 == 0)
                {
                    Graphics g = e.Graphics;
                    Rectangle r = e.CellBounds;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(225, 225, 225)), r);
                }
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                #region add new item

                if (NewItem)
                {

                    if (textBoxName.Text.Trim() == "")
                    {
                        errorProvider1.SetError(textBoxName, "Please insert a name");
                        return;
                    }

                    int maxID = 0;
                    try
                    {
                        maxID = (from q in Variables.xDocument.Descendants("Item")
                                 where q.Attribute("UserID").Value == Variables.CurrentUserID
                                 select (int)q.Attribute("ID")).Max();
                    }
                    catch { }
                    maxID++;

                    XElement newItem = new XElement("Item",
                                   new XAttribute("ID", maxID),
                                   new XAttribute("UserID", Variables.CurrentUserID),
                                   new XAttribute("Name", textBoxName.Text.Trim()),
                                   new XAttribute("Mobile", textBoxMobile.Text.Trim()),
                                   new XAttribute("Phone", textBoxPhone.Text.Trim()),
                                   new XAttribute("Email", textBoxEMail.Text.Trim()),
                                   new XAttribute("Address", textBoxAddress.Text.Trim()),
                                   new XAttribute("RegDate", DateTime.Now.ToString()));

                    var ItemsElement = (from q in Variables.xDocument.Descendants("Items")
                                        select q).First();
                    ItemsElement.Add(newItem);
                }

                #endregion

                #region edit item

                else if (EditItem)
                {
                    if (textBoxName.Text.Trim() == "")
                    {
                        errorProvider1.SetError(textBoxName, "Please insert name");
                        return;
                    }

                    var theItem = (from q in Variables.xDocument.Descendants("Item")
                                   where q.Attribute("ID").Value == this.ItemID
                                   select q).First();

                    theItem.Attribute("Name").Value = textBoxName.Text.Trim();
                    theItem.Attribute("Mobile").Value = textBoxMobile.Text.Trim();
                    theItem.Attribute("Phone").Value = textBoxPhone.Text.Trim();
                    theItem.Attribute("Email").Value = textBoxEMail.Text.Trim();
                    theItem.Attribute("Address").Value = textBoxAddress.Text.Trim();
                }

                #endregion

                TripleDES.EncryptToFile(Variables.xDocument.ToString(SaveOptions.DisableFormatting), Variables.DBFile, TripleDES.ByteKey, TripleDES.IV);
                //Variables.xDocument.Save("debug.xml");

                this.Close();
            }
            catch (Exception ex)
            {
                StackFrame file_info = new StackFrame(true);
                Messages.error(ref file_info, ex.Message, this);
            }
        }

        #region

        Image ResizeImage(Image FullsizeImage, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            // Prevent using images internal thumbnail
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            if (OnlyResizeIfWider)
            {
                if (FullsizeImage.Width <= NewWidth)
                {
                    NewWidth = FullsizeImage.Width;
                }
            }

            int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
            if (NewHeight > MaxHeight)
            {
                // Resize with height instead
                NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                NewHeight = MaxHeight;
            }

            System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            FullsizeImage.Dispose();

            // Save resized picture
            return NewImage;
        }

        string ImageToBase64String(Image image, ImageFormat format)
        {
            MemoryStream memory = new MemoryStream();
            image.Save(memory, format);
            string base64 = Convert.ToBase64String(memory.ToArray());
            memory.Close();

            return base64;
        }

        Image ImageFromBase64String(string base64)
        {
            MemoryStream memory = new MemoryStream(Convert.FromBase64String(base64));
            Image result = Image.FromStream(memory);
            memory.Close();

            return result;
        }

        #endregion

    }
}
