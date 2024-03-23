namespace NtofosApplication
{
    partial class frmRegister
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
			btnCancel = new Button();
			btnSave = new Button();
			txtPassword = new TextBox();
			txtEmail = new TextBox();
			picUser = new PictureBox();
			btnSend = new Button();
			txtCfPassword = new TextBox();
			txtUser = new TextBox();
			txtVerify = new TextBox();
			btnVerify = new Button();
			picPasword = new PictureBox();
			picCfPassword = new PictureBox();
			((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
			((System.ComponentModel.ISupportInitialize)picPasword).BeginInit();
			((System.ComponentModel.ISupportInitialize)picCfPassword).BeginInit();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(274, 388);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(94, 29);
			btnCancel.TabIndex = 9;
			btnCancel.Text = "&Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnSave
			// 
			btnSave.DialogResult = DialogResult.OK;
			btnSave.Location = new Point(120, 388);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 29);
			btnSave.TabIndex = 8;
			btnSave.Text = "&Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(120, 291);
			txtPassword.Name = "txtPassword";
			txtPassword.PlaceholderText = "Password...";
			txtPassword.Size = new Size(248, 27);
			txtPassword.TabIndex = 7;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(120, 198);
			txtEmail.Name = "txtEmail";
			txtEmail.PlaceholderText = "Email...";
			txtEmail.Size = new Size(248, 27);
			txtEmail.TabIndex = 6;
			// 
			// picUser
			// 
			picUser.Image = (Image)resources.GetObject("picUser.Image");
			picUser.Location = new Point(197, 23);
			picUser.Name = "picUser";
			picUser.Size = new Size(94, 100);
			picUser.SizeMode = PictureBoxSizeMode.Zoom;
			picUser.TabIndex = 5;
			picUser.TabStop = false;
			// 
			// btnSend
			// 
			btnSend.Location = new Point(399, 196);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(94, 29);
			btnSend.TabIndex = 10;
			btnSend.Text = "&Send";
			btnSend.UseVisualStyleBackColor = true;
			btnSend.Click += btnSend_Click;
			// 
			// txtCfPassword
			// 
			txtCfPassword.Location = new Point(120, 340);
			txtCfPassword.Name = "txtCfPassword";
			txtCfPassword.PlaceholderText = "Confirm Password...";
			txtCfPassword.Size = new Size(248, 27);
			txtCfPassword.TabIndex = 11;
			txtCfPassword.UseSystemPasswordChar = true;
			// 
			// txtUser
			// 
			txtUser.Location = new Point(120, 149);
			txtUser.Name = "txtUser";
			txtUser.PlaceholderText = "Username...";
			txtUser.Size = new Size(248, 27);
			txtUser.TabIndex = 12;
			// 
			// txtVerify
			// 
			txtVerify.Location = new Point(120, 244);
			txtVerify.Name = "txtVerify";
			txtVerify.PlaceholderText = "Verification Code...";
			txtVerify.Size = new Size(248, 27);
			txtVerify.TabIndex = 13;
			// 
			// btnVerify
			// 
			btnVerify.Location = new Point(399, 244);
			btnVerify.Name = "btnVerify";
			btnVerify.Size = new Size(94, 29);
			btnVerify.TabIndex = 14;
			btnVerify.Text = "&Verify";
			btnVerify.UseVisualStyleBackColor = true;
			btnVerify.Click += btnVerify_Click;
			// 
			// picPasword
			// 
			picPasword.Image = (Image)resources.GetObject("picPasword.Image");
			picPasword.Location = new Point(338, 295);
			picPasword.Name = "picPasword";
			picPasword.Size = new Size(30, 20);
			picPasword.SizeMode = PictureBoxSizeMode.Zoom;
			picPasword.TabIndex = 15;
			picPasword.TabStop = false;
			picPasword.Click += picPasword_Click;
			// 
			// picCfPassword
			// 
			picCfPassword.Image = (Image)resources.GetObject("picCfPassword.Image");
			picCfPassword.Location = new Point(338, 344);
			picCfPassword.Name = "picCfPassword";
			picCfPassword.Size = new Size(30, 20);
			picCfPassword.SizeMode = PictureBoxSizeMode.Zoom;
			picCfPassword.TabIndex = 16;
			picCfPassword.TabStop = false;
			picCfPassword.Click += picCfPassword_Click;
			// 
			// frmRegister
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(516, 450);
			Controls.Add(picCfPassword);
			Controls.Add(picPasword);
			Controls.Add(btnVerify);
			Controls.Add(txtVerify);
			Controls.Add(txtUser);
			Controls.Add(txtCfPassword);
			Controls.Add(btnSend);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(txtPassword);
			Controls.Add(txtEmail);
			Controls.Add(picUser);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmRegister";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Register";
			Load += frmRegister_Load;
			((System.ComponentModel.ISupportInitialize)picUser).EndInit();
			((System.ComponentModel.ISupportInitialize)picPasword).EndInit();
			((System.ComponentModel.ISupportInitialize)picCfPassword).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnCancel;
        private Button btnSave;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private PictureBox picUser;
        private Button btnSend;
        private TextBox txtCfPassword;
        private TextBox txtUser;
        private TextBox txtVerify;
        private Button btnVerify;
        private PictureBox picPasword;
        private PictureBox picCfPassword;
    }
}