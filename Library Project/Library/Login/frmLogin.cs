using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class frmLogin : Form
	{
		private clsUser _User;
		public frmLogin()
		{
			InitializeComponent();
		}

		

		private void guna2TextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			_User=clsUser.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
			if(_User!=null )
			{
				if (chkRememberMe.Checked)
				{
					clsGlobal.RememberUserNameAndPasswordWR(txtUsername.Text.Trim(), txtPassword.Text.Trim());
				}
				else
				{
					clsGlobal.RememberUserNameAndPasswordWR("", "");
				}
				if (!_User.IsActive)
				{

					txtUsername.Focus();
					MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				clsGlobal.CurrentUser = _User;
				clsGlobal.Settings=clsSettings.GetSettings();
				this.Hide();
				frmMain frm = new frmMain(this);
				frm.ShowDialog();
			}
			else
			{
				txtUsername.Focus();
				MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{
			string Username = "", Password = "";

			if (clsGlobal.GetStoredCredentialWR(ref Username, ref Password))
			{
				txtUsername.Text = Username;
				txtPassword.Text = Password;
				chkRememberMe.Checked = true;
			}
			else
				chkRememberMe.Checked = false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
