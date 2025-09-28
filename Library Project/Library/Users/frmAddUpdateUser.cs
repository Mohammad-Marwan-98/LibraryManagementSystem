using Guna.UI2.WinForms;
using Library.Properties;
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
using static LibraryBusiness.clsReader;

namespace Library
{
	public partial class frmAddUpdateUser : Form
	{

		private enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode;

		private byte counter =0 ;
		private int _PersonID;
		private int _UserID;
		private clsUser _User = new clsUser();

		public frmAddUpdateUser()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
		}

		public frmAddUpdateUser(int UserID)
		{
			InitializeComponent();
			_UserID = UserID;
			_Mode = enMode.Update;
		}

		private int GetPermissionsValue()
		{
			int permissions = 0;

			if(chkFullAccess.Checked)
			{
				permissions = -1;
				return permissions;
			}
			foreach (CheckBox chk in gbPermissions.Controls.OfType<CheckBox>())
			{
				if (chk.Checked && chk.Tag != null)
				{
					permissions |= Convert.ToInt32(chk.Tag);
				}
			}

			return permissions;
		}


		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!_CheckRequiredControls())
			{
				return;
			}
			if (!_CheckBoxex())
			{
				MessageBox.Show("Please select at least one permission.", "Missing Permissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (txtPassword.Visible && txtConfirmPassword.Visible)
			{
				if (txtPassword.Text != txtConfirmPassword.Text)
				{
					MessageBox.Show("The new password and confirmation do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}


			ctrlAddUpdatePersonInfo1.Save();

			_User.Username=txtUsername.Text.Trim();
			_User.Password=txtPassword.Text.Trim();
			_User.PersonID = ctrlAddUpdatePersonInfo1.PersonId;
			_User.Permissions=Convert.ToInt16(GetPermissionsValue());
			_User.IsActive=chkIsActive.Checked;

			if (_User.Save())
			{
				if (_User.UserID == clsGlobal.CurrentUser.UserID)
				{
					clsGlobal.CurrentUser = clsUser.Find(_User.UserID);
				}
				lblTitle.Text = "Update User Info";
				pbMode.Image = Resources.editPerson__2_;
				_UserID = _User.UserID;
				lblUserID.Text = _UserID.ToString();
				MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
				lblPassword.Visible = false;
				lblConfirmPassword.Visible = false;
				txtPassword.Visible = false;
				txtConfirmPassword.Visible = false;
				pbPassword.Visible = false;
				pbConfirmPassword.Visible = false;
				gbPermissions.Location = new System.Drawing.Point(40, 275);
				chkIsActive.Enabled = true;
			}
			else
			{
				MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void _CheckBoxexCounter()
		{
			counter = 0;
			foreach(CheckBox chk in gbPermissions.Controls.OfType<CheckBox>())
				if (chk.Checked)
				{
					if (chk == chkFullAccess)
						continue;
					counter++;
				}
		}

		private void frmAddUpdateUser_Load(object sender, EventArgs e)
		{
			_ResetValues();
			if (_Mode == enMode.Update)
			{
				_LoadData(_UserID);
			}
			_CheckBoxexCounter();
		}

		private void _ResetValues()
		{
			foreach (CheckBox chk in gbPermissions.Controls.OfType<CheckBox>())
			{
				chk.Checked = false;
			}
			counter = 0;
			lblUserID.Text = "??";
			txtUsername.Text=string.Empty; 
			txtPassword.Text=string.Empty;
			txtConfirmPassword.Text=string.Empty;


			if (_Mode == enMode.AddNew)
			{
				lblTitle.Text = "Add New User";
				pbMode.Image = Resources.Add64_2_;
				chkIsActive.Enabled = false;
			}
			else
			{
				lblTitle.Text = "Update User Info";
				pbMode.Image = Resources.editPerson__2_;

			}

		}

		private void _LoadData(int UserID)
		{
			_User=clsUser.Find(UserID);
			ctrlAddUpdatePersonInfo1.LoadData(_User.PersonID);
			lblUserID.Text=_User.UserID.ToString();
			txtUsername.Text = _User.Username;
			txtPassword.Text = _User.Password;
			lblPassword.Visible = false;
			lblConfirmPassword.Visible = false;
			txtPassword.Visible = false;
			txtConfirmPassword.Visible = false;
			pbPassword.Visible = false;
			pbConfirmPassword.Visible = false;
			gbPermissions.Location = new System.Drawing.Point(40, 275);
			chkIsActive.Enabled = true;

			if (_User.Permissions == -1)
			{
				chkFullAccess.Checked = true;
			}
			else
			{
				if (((clsUser.enPermissions)_User.Permissions).HasFlag(clsUser.enPermissions.Books))
				{
					chkManageBooks.Checked = true;
				}
				if (((clsUser.enPermissions)_User.Permissions).HasFlag(clsUser.enPermissions.Readers))
				{
					chkManageReaders.Checked = true;
				}
				if (((clsUser.enPermissions)_User.Permissions).HasFlag(clsUser.enPermissions.Users))
				{
					chkManageUsers.Checked = true;
				}
				if (((clsUser.enPermissions)_User.Permissions).HasFlag(clsUser.enPermissions.Payments))
				{
					chkManagePayments.Checked = true;
				}
				if (((clsUser.enPermissions)_User.Permissions).HasFlag(clsUser.enPermissions.Borrows))
				{
					chkManageBorrows.Checked = true;
				}
				if (((clsUser.enPermissions)_User.Permissions).HasFlag(clsUser.enPermissions.Settings))
				{
					chkManageSettings.Checked = true;
				}
				if (((clsUser.enPermissions)_User.Permissions).HasFlag(clsUser.enPermissions.Reservations))
				{
					chkManageSettings.Checked = true;
				}

			}


		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (ctrlAddUpdatePersonInfo1.CheckRequiredControls())
			{
				tabCompleteInfo.SelectedIndex = 1;
			}
		}

		private bool _CheckRequiredControls()
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}
			return true;
		}

		private void tbReaderInfo_Enter(object sender, EventArgs e)
		{
			if (!ctrlAddUpdatePersonInfo1.CheckRequiredControls())
			{
				//MessageBox.Show("Please fill in the personal information to complete registration.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tabCompleteInfo.SelectedTab = tbPersonalInfo;
			}
		}

		private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
		{
			Guna2TextBox temp = (Guna2TextBox)sender;

			if (!temp.Visible)
			{
				e.Cancel = false;
				errorProvider1.SetError(temp, null);
				return;
			}

			if (string.IsNullOrEmpty(temp.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(temp, "This Field Is Required");
			}
			else
			{
				e.Cancel = false;
				errorProvider1.SetError(temp, null);
			}
		}


		private bool _CheckBoxex()
		{
			bool AtLeastOneChecked = gbPermissions.Controls.OfType<CheckBox>().Any(cb=>cb.Checked);
			return AtLeastOneChecked;
		}

		private void chkFullAccess_CheckedChanged(object sender, EventArgs e)
		{
			

			if (chkFullAccess.Checked)
			{
				counter = 0;
				foreach (CheckBox chk in gbPermissions.Controls.OfType<CheckBox>())
				{
					chk.Checked = true;
					
				}
				counter = 7;
			}
			else
			{
				if (counter == 7)
				{
					
					foreach (CheckBox chk in gbPermissions.Controls.OfType<CheckBox>())
					{
						chk.Checked = false;
					}
					counter = 0;
				}
			}
		}
		private void checkbox_CheckedChanged(object sender, EventArgs e)
		{
			
			CheckBox temp = (CheckBox)sender;

			if (temp.Checked)
				counter++;
			else
				counter--;

			if(!temp.Checked)
				chkFullAccess.Checked = false;
			if(counter ==7) 
				chkFullAccess.Checked = true; 
		}
	}
}
