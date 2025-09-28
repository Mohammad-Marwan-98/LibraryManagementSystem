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
	public partial class frmChangePassword : Form
	{
		private clsUser _User=new clsUser();
		private int _UserID;
		public frmChangePassword(int UserID)
		{
			InitializeComponent();
			_UserID = UserID;

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmChangePassword_Load(object sender, EventArgs e)
		{
			_User = clsUser.Find(_UserID);
			lblUserID.Text = _UserID.ToString();
			lblUsername.Text=_User.Username;
		}


		private void _ResetDefualtValues()
		{

			txtCurrentPassword.Text = "";
			txtNewPassword.Text = "";
			txtConfirmPassword.Text = "";

		}


		private void btnSave_Click(object sender, EventArgs e)
		{
			string currentHashedPassword = clsUser.HashData(txtCurrentPassword.Text.Trim());

			if (_User.Password != currentHashedPassword)
			{
				MessageBox.Show("The current password is incorrect.",
					"Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (txtNewPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("The new password and confirmation do not match.",
					"Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_User.Password = clsUser.HashData(txtConfirmPassword.Text.Trim());

			if (_User.Save())
			{
				MessageBox.Show("Password Changed Successfully.",
					"Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_ResetDefualtValues();
			}
		}

	}
}
