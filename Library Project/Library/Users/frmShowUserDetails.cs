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
	public partial class frmShowUserDetails : Form
	{
		private int _UserID;
		private clsUser _User = new clsUser();

		public frmShowUserDetails(int UserID)
		{
			InitializeComponent();
			_UserID = UserID;
		}

		private void _ResetValues()
		{
			ctrlPersonDetails1.ResetValues();
			lblUserID.Text = "??";
			lblUsername.Text = "??";
			chkIsActive.Checked = false;
		}

		private void _LoadData()
		{
			_User = clsUser.Find(_UserID);
			ctrlPersonDetails1.LoadData(_User.PersonID);

			lblUserID.Text = _User.UserID.ToString();
			lblUsername.Text = _User.Username;
			chkIsActive.Checked=_User.IsActive;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmShowUserDetails_Load(object sender, EventArgs e)
		{
			_ResetValues();
			_LoadData();
		}
	}
}
