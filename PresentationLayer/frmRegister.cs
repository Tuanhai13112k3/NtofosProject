using NtofosApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NtofosApplication
{
	public partial class frmRegister : Form
	{
		public bool ForgotOrRegister { get; set; } = false; //T : Forget, F: Register
		private string AuthenCode = null;
		private NtofosContext context;
		public frmRegister()
		{
			InitializeComponent();
			context = new NtofosContext();
		}
		private void frmRegister_Load(object sender, EventArgs e)
		{
			txtCfPassword.Visible = false;
			txtPassword.Visible = false;
			txtVerify.Visible = false;
			btnVerify.Visible = false;
			picPasword.Visible = false;
			picCfPassword.Visible = false;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			var username = txtUser.Text;
			var password = txtPassword.Text;
			var cfPassword = txtCfPassword.Text;
			bool cf = password.Equals(cfPassword);
			var email = txtEmail.Text;
			if (cf)
			{
				if (ForgotOrRegister == false)
				{
					var user = context.Users.FirstOrDefault(x => x.Email == email || x.Username == username);
					if (user == null)
					{

						context.Users.Add(new User
						{
							Username = username,
							Fullname = username,
							Password = password,
							Email = email,
						});
						context.SaveChanges();
					}
					else
					{
						MessageBox.Show("This account is already existed.");
					}
				}
				if (ForgotOrRegister)
				{
					var user = context.Users.FirstOrDefault(x => x.Email == email && x.Username == username);
					if (user != null)
					{
						user.Password = password;
						context.Users.Update(user);
						context.SaveChanges();
					}
					else
					{
						MessageBox.Show("This account is already existed.");
					}
				}
			}
			else
			{
				MessageBox.Show("Password does not match.");
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			for (int i = 0; i < 1; i++)
			{
				var randomUpperChar = (char)(rnd.Next(48, 122));
				AuthenCode += randomUpperChar;
			}
			if (Email.IsEmailValid(txtEmail.Text))
			{
				Email.Send("tuanhai13112003@gmail.com", "Email Authencation", AuthenCode);
				txtVerify.Visible = true;
				btnVerify.Visible = true;
			}
			else
			{
				MessageBox.Show("Email is not formatted.");
			}

		}

		private void btnVerify_Click(object sender, EventArgs e)
		{
			var verification = txtVerify.Text;
			if (verification.Equals(AuthenCode))
			{
				txtCfPassword.Visible = true;
				txtPassword.Visible = true;
				picPasword.Visible = true;
				picCfPassword.Visible = true;
			}
			else
			{
				MessageBox.Show("Authentication code is incorrect.", "Register",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void picPasword_Click(object sender, EventArgs e)
		{

			txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
		}

		private void picCfPassword_Click(object sender, EventArgs e)
		{
			txtCfPassword.UseSystemPasswordChar = !txtCfPassword.UseSystemPasswordChar;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
