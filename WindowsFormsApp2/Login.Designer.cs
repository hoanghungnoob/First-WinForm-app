namespace WindowsFormsApp2
{
    partial class Login
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
            this.username = new DevExpress.XtraEditors.TextEdit();
            this.User = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(81, 81);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(145, 20);
            this.username.TabIndex = 1;
            this.username.EditValueChanged += new System.EventHandler(this.onChange_Username);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(81, 62);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(49, 13);
            this.User.TabIndex = 2;
            this.User.Text = "UserName";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(81, 138);
            this.password.Name = "password";
            this.password.Properties.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(145, 20);
            this.password.TabIndex = 4;
            this.password.EditValueChanged += new System.EventHandler(this.onChange_password);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(118, 205);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Login";
            this.simpleButton1.Click += new System.EventHandler(this.Login_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(196, 182);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Register now";
            this.labelControl2.Click += new System.EventHandler(this.Open_Register);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "You don\'t have an account?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit username;
        private DevExpress.XtraEditors.LabelControl User;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Label label1;
    }
}