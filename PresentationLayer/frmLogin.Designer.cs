namespace NtofosApplication
{
    partial class frmLogin
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
			picUser = new PictureBox();
			txtUser = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			btnCancel = new Button();
			lbNew = new Label();
			llbRegister = new LinkLabel();
			llbForgot = new LinkLabel();
			picEye = new PictureBox();
			((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
			((System.ComponentModel.ISupportInitialize)picEye).BeginInit();
			SuspendLayout();
			// 
			// picUser
			// 
			picUser.Image = Properties.Resources.user;
			picUser.Location = new Point(154, 42);
			picUser.Name = "picUser";
			picUser.Size = new Size(94, 100);
			picUser.SizeMode = PictureBoxSizeMode.Zoom;
			picUser.TabIndex = 0;
			picUser.TabStop = false;
			// 
			// txtUser
			// 
			txtUser.Location = new Point(77, 177);
			txtUser.Name = "txtUser";
			txtUser.PlaceholderText = "Username or email...";
			txtUser.Size = new Size(248, 27);
			txtUser.TabIndex = 1;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(77, 233);
			txtPassword.Name = "txtPassword";
			txtPassword.PlaceholderText = "Password";
			txtPassword.Size = new Size(248, 27);
			txtPassword.TabIndex = 2;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.Cursor = Cursors.AppStarting;
			btnLogin.Location = new Point(77, 305);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(94, 29);
			btnLogin.TabIndex = 3;
			btnLogin.Text = "&Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(231, 305);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(94, 29);
			btnCancel.TabIndex = 4;
			btnCancel.Text = "&Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// lbNew
			// 
			lbNew.AutoSize = true;
			lbNew.Location = new Point(79, 348);
			lbNew.Name = "lbNew";
			lbNew.Size = new Size(89, 20);
			lbNew.TabIndex = 5;
			lbNew.Text = "New Users ?";
			// 
			// llbRegister
			// 
			llbRegister.AutoSize = true;
			llbRegister.Location = new Point(174, 348);
			llbRegister.Name = "llbRegister";
			llbRegister.Size = new Size(95, 20);
			llbRegister.TabIndex = 6;
			llbRegister.TabStop = true;
			llbRegister.Text = "Register now";
			llbRegister.LinkClicked += llbRegister_LinkClicked;
			// 
			// llbForgot
			// 
			llbForgot.AutoSize = true;
			llbForgot.Location = new Point(207, 274);
			llbForgot.Name = "llbForgot";
			llbForgot.Size = new Size(118, 20);
			llbForgot.TabIndex = 7;
			llbForgot.TabStop = true;
			llbForgot.Text = "Forgot Password";
			llbForgot.LinkClicked += llbForgot_LinkClicked;
			// 
			// picEye
			// 
			picEye.Image = Properties.Resources.eye;
			picEye.Location = new Point(295, 237);
			picEye.Name = "picEye";
			picEye.Size = new Size(30, 20);
			picEye.SizeMode = PictureBoxSizeMode.Zoom;
			picEye.TabIndex = 8;
			picEye.TabStop = false;
			picEye.Click += picEye_Click;
			// 
			// frmLogin
			// 
			AcceptButton = btnLogin;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Center;
			CancelButton = btnCancel;
			ClientSize = new Size(414, 397);
			Controls.Add(picEye);
			Controls.Add(llbForgot);
			Controls.Add(llbRegister);
			Controls.Add(lbNew);
			Controls.Add(btnCancel);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUser);
			Controls.Add(picUser);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)picUser).EndInit();
			((System.ComponentModel.ISupportInitialize)picEye).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox picUser;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private Label lbNew;
        private LinkLabel llbRegister;
        private LinkLabel llbForgot;
        private PictureBox picEye;
    }
}