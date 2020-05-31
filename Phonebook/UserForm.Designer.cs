namespace Phonebook
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.labelPass1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.checkBoxForgetPass = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50847F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.49152F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPass1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPass2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxForgetPass, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonSubmit, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword2.Location = new System.Drawing.Point(152, 109);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(312, 22);
            this.textBoxPassword2.TabIndex = 3;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword1.Location = new System.Drawing.Point(152, 61);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.PasswordChar = '*';
            this.textBoxPassword1.Size = new System.Drawing.Size(312, 22);
            this.textBoxPassword1.TabIndex = 2;
            // 
            // labelPass1
            // 
            this.labelPass1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPass1.AutoSize = true;
            this.labelPass1.Location = new System.Drawing.Point(4, 64);
            this.labelPass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass1.Name = "labelPass1";
            this.labelPass1.Size = new System.Drawing.Size(77, 16);
            this.labelPass1.TabIndex = 0;
            this.labelPass1.Text = "Password : ";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(4, 16);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 16);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "User Name : ";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUsername.Location = new System.Drawing.Point(152, 13);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(312, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(4, 160);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 16);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "E-Mail : ";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmail.Location = new System.Drawing.Point(152, 157);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(312, 22);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelPass2
            // 
            this.labelPass2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPass2.AutoSize = true;
            this.labelPass2.Location = new System.Drawing.Point(3, 112);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(104, 16);
            this.labelPass2.TabIndex = 0;
            this.labelPass2.Text = "New Password :";
            // 
            // checkBoxForgetPass
            // 
            this.checkBoxForgetPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxForgetPass.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxForgetPass, 2);
            this.checkBoxForgetPass.Location = new System.Drawing.Point(169, 256);
            this.checkBoxForgetPass.Name = "checkBoxForgetPass";
            this.checkBoxForgetPass.Size = new System.Drawing.Size(150, 20);
            this.checkBoxForgetPass.TabIndex = 6;
            this.checkBoxForgetPass.Text = "I forgot my password";
            this.checkBoxForgetPass.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonSubmit, 2);
            this.buttonSubmit.Location = new System.Drawing.Point(191, 195);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(107, 41);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(489, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Information";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPass1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword2;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.CheckBox checkBoxForgetPass;
        private System.Windows.Forms.Button buttonSubmit;
    }
}