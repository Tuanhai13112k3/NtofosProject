using NtofosApplication.DataAccess;
using NtofosApplication.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NtofosApplication
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUser.Text;
			string password = txtPassword.Text;
			using var context = new NtofosContext();
			var account = context.Users.FirstOrDefault(em => (em.Username.ToLower() == username
			|| em.Email.ToLower() == username)
			&& em.Password.Equals(password));
			if (account != null)
			{
				UserSession.CurrentUser = account;
				if (account.Role.ToLower().Equals("admin"))
				{
					frmDashBoard frmDashBoard = new frmDashBoard();
					this.Hide();
					frmDashBoard.ShowDialog();
                    if (frmDashBoard.DialogResult == DialogResult.Cancel)
                    {
						this.Show();
                    }
                }
				else
				{
					frmHome frmHome = new frmHome();
					this.Hide();
					frmHome.ShowDialog();
					if (frmHome.DialogResult == DialogResult.Cancel)
					{
						this.Show();
					}
				}
				Clear();
			}
			else
			{
				MessageBox.Show("This account is not existed. Register to login.");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void Clear()
		{
			txtUser.Text = string.Empty; txtPassword.Text = string.Empty;
		}
		private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmRegister frmRegister = new frmRegister
			{
				ForgotOrRegister = false
			};
			frmRegister.ShowDialog();
		}

		private void llbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmRegister frmRegister = new frmRegister
			{
				ForgotOrRegister = true
			};
			frmRegister.ShowDialog();
		}

		private void picEye_Click(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
		}
	}
}
