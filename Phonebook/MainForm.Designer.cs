using System.Windows.Forms;
namespace Phonebook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonClearSearchTextBox = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPhone = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMobile = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEmail = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAddress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRegDate = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.christianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize18 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.481482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.40741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.76487F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.23513F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.Controls.Add(this.labelSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClearSearchTextBox, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(5, 6);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(60, 16);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "Search : ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Location = new System.Drawing.Point(74, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(585, 22);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonClearSearchTextBox
            // 
            this.buttonClearSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearSearchTextBox.Location = new System.Drawing.Point(690, 3);
            this.buttonClearSearchTextBox.Name = "buttonClearSearchTextBox";
            this.buttonClearSearchTextBox.Size = new System.Drawing.Size(60, 23);
            this.buttonClearSearchTextBox.TabIndex = 6;
            this.buttonClearSearchTextBox.Text = "Clear";
            this.buttonClearSearchTextBox.UseVisualStyleBackColor = true;
            this.buttonClearSearchTextBox.Click += new System.EventHandler(this.buttonClearSearchTextBox_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonNew, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEdit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 483);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 54);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.Location = new System.Drawing.Point(598, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNew.Enabled = false;
            this.buttonNew.Location = new System.Drawing.Point(79, 7);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 40);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(338, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 40);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPhone,
            this.columnHeaderMobile,
            this.columnHeaderEmail,
            this.columnHeaderAddress,
            this.columnHeaderRegDate});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Enabled = false;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(778, 439);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 118;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Phone";
            this.columnHeaderPhone.Width = 120;
            // 
            // columnHeaderMobile
            // 
            this.columnHeaderMobile.Text = "Mobile";
            this.columnHeaderMobile.Width = 127;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 172;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Address";
            this.columnHeaderAddress.Width = 300;
            // 
            // columnHeaderRegDate
            // 
            this.columnHeaderRegDate.Text = "Register Date";
            this.columnHeaderRegDate.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgrammerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutProgrammerToolStripMenuItem
            // 
            this.aboutProgrammerToolStripMenuItem.Name = "aboutProgrammerToolStripMenuItem";
            this.aboutProgrammerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutProgrammerToolStripMenuItem.Text = "About Programmer";
            this.aboutProgrammerToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.changeUserToolStripMenuItem,
            this.changeInfoToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newUserToolStripMenuItem.Text = "Create New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changeUserToolStripMenuItem.Text = "Change User";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // changeInfoToolStripMenuItem
            // 
            this.changeInfoToolStripMenuItem.Enabled = false;
            this.changeInfoToolStripMenuItem.Name = "changeInfoToolStripMenuItem";
            this.changeInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changeInfoToolStripMenuItem.Text = "Change Info";
            this.changeInfoToolStripMenuItem.Click += new System.EventHandler(this.changeInfoToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightToLeftToolStripMenuItem,
            this.leftToRightToolStripMenuItem,
            this.datesToolStripMenuItem,
            this.fontSizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // rightToLeftToolStripMenuItem
            // 
            this.rightToLeftToolStripMenuItem.CheckOnClick = true;
            this.rightToLeftToolStripMenuItem.Name = "rightToLeftToolStripMenuItem";
            this.rightToLeftToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rightToLeftToolStripMenuItem.Text = "Right To Left";
            this.rightToLeftToolStripMenuItem.Click += new System.EventHandler(this.rightToLeftToolStripMenuItem_Click);
            // 
            // leftToRightToolStripMenuItem
            // 
            this.leftToRightToolStripMenuItem.Checked = true;
            this.leftToRightToolStripMenuItem.CheckOnClick = true;
            this.leftToRightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftToRightToolStripMenuItem.Name = "leftToRightToolStripMenuItem";
            this.leftToRightToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.leftToRightToolStripMenuItem.Text = "Left To Right";
            this.leftToRightToolStripMenuItem.Click += new System.EventHandler(this.leftToRightToolStripMenuItem_Click);
            // 
            // datesToolStripMenuItem
            // 
            this.datesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.christianToolStripMenuItem,
            this.persianToolStripMenuItem});
            this.datesToolStripMenuItem.Name = "datesToolStripMenuItem";
            this.datesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.datesToolStripMenuItem.Text = "Dates";
            // 
            // christianToolStripMenuItem
            // 
            this.christianToolStripMenuItem.CheckOnClick = true;
            this.christianToolStripMenuItem.Name = "christianToolStripMenuItem";
            this.christianToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.christianToolStripMenuItem.Text = "Christian";
            this.christianToolStripMenuItem.Click += new System.EventHandler(this.christianToolStripMenuItem_Click);
            // 
            // persianToolStripMenuItem
            // 
            this.persianToolStripMenuItem.Checked = true;
            this.persianToolStripMenuItem.CheckOnClick = true;
            this.persianToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.persianToolStripMenuItem.Name = "persianToolStripMenuItem";
            this.persianToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.persianToolStripMenuItem.Text = "Persian";
            this.persianToolStripMenuItem.Click += new System.EventHandler(this.persianToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFontSize8,
            this.toolStripMenuItemFontSize10,
            this.toolStripMenuItemFontSize12,
            this.toolStripMenuItemFontSize14,
            this.toolStripMenuItemFontSize16,
            this.toolStripMenuItemFontSize18});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fontSizeToolStripMenuItem.Text = "Font Size ";
            // 
            // toolStripMenuItemFontSize8
            // 
            this.toolStripMenuItemFontSize8.CheckOnClick = true;
            this.toolStripMenuItemFontSize8.Name = "toolStripMenuItemFontSize8";
            this.toolStripMenuItemFontSize8.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize8.Text = "8";
            this.toolStripMenuItemFontSize8.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize10
            // 
            this.toolStripMenuItemFontSize10.Checked = true;
            this.toolStripMenuItemFontSize10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemFontSize10.Name = "toolStripMenuItemFontSize10";
            this.toolStripMenuItemFontSize10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize10.Text = "10";
            this.toolStripMenuItemFontSize10.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize12
            // 
            this.toolStripMenuItemFontSize12.CheckOnClick = true;
            this.toolStripMenuItemFontSize12.Name = "toolStripMenuItemFontSize12";
            this.toolStripMenuItemFontSize12.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize12.Text = "12";
            this.toolStripMenuItemFontSize12.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize14
            // 
            this.toolStripMenuItemFontSize14.CheckOnClick = true;
            this.toolStripMenuItemFontSize14.Name = "toolStripMenuItemFontSize14";
            this.toolStripMenuItemFontSize14.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize14.Text = "14";
            this.toolStripMenuItemFontSize14.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize16
            // 
            this.toolStripMenuItemFontSize16.CheckOnClick = true;
            this.toolStripMenuItemFontSize16.Name = "toolStripMenuItemFontSize16";
            this.toolStripMenuItemFontSize16.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize16.Text = "16";
            this.toolStripMenuItemFontSize16.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize18
            // 
            this.toolStripMenuItemFontSize18.CheckOnClick = true;
            this.toolStripMenuItemFontSize18.Name = "toolStripMenuItemFontSize18";
            this.toolStripMenuItemFontSize18.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize18.Text = "18";
            this.toolStripMenuItemFontSize18.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToRightToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderMobile;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize10;
        private System.Windows.Forms.ToolStripMenuItem changeInfoToolStripMenuItem;
        private System.Windows.Forms.Button buttonClearSearchTextBox;
        private System.Windows.Forms.ColumnHeader columnHeaderRegDate;
        private System.Windows.Forms.ToolStripMenuItem datesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem christianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persianToolStripMenuItem;
    }
}

