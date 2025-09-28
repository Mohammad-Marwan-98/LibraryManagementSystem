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

namespace Library
{
	public partial class frmAddUpdateReader : Form
	{
		private enum enMode { AddNew = 1, Update = 2 };
		private enMode _Mode;

		private int _PersonID;
		private int _ReaderID;
		private clsReader _Reader = new clsReader();

		public frmAddUpdateReader()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;

		}

		public frmAddUpdateReader(int ReaderID)
		{
			InitializeComponent();
			_ReaderID = ReaderID;
			_Mode = enMode.Update;
		}

		private void _ResetValues()
		{

			lblPersonID.Text = "??";
			lblReaderID.Text = "??";
			lblLibraryCard.Text = "??";
			dtpJoinDate.Value = DateTime.Now;
			dtpExpirtyDate.Value = DateTime.Now;
			txtNotes.Text = string.Empty;
			if(_Mode == enMode.AddNew)
			{
				lblTitle.Text = "Add New Reader";
				pbMode.Image = Resources.Add64_2_;
				chkIsActive.Enabled = false;
				dtpJoinDate.Enabled=false;
				dtpExpirtyDate.Enabled=false;
				cbSubscriptionStatus.Enabled = false;
				cbSubscriptionStatus.Enabled=false;
			}
			else
			{
				lblTitle.Text = "Update Reader Info";
				pbMode.Image = Resources.editPerson__2_;
				dtpJoinDate.Enabled = false;
				

			}

		}

		private void _LoadData(int ReaderID)
		{
			
			_Reader=clsReader.Find(ReaderID);

			ctrlAddUpdatePersonInfo1.LoadData(_Reader.PersonID);

			lblReaderID.Text = _Reader.ReaderID.ToString();
			lblPersonID.Text= _Reader.PersonID.ToString();
			lblLibraryCard.Text=_Reader.LibraryCardNumber.ToString();
			dtpJoinDate.Value=_Reader.JoinDate;
			dtpExpirtyDate.Value = _Reader.SubscriptionExpiryDate;
			txtNotes.Text= _Reader.Notes;
			switch ((clsReader.enSubscriptionStatus)_Reader.SubscriptionStatus)
			{
				case clsReader.enSubscriptionStatus.Active:
					cbSubscriptionStatus.SelectedIndex = 0;
					break;

				case clsReader.enSubscriptionStatus.Expired:
					cbSubscriptionStatus.SelectedIndex = 1;
					break;

				case clsReader.enSubscriptionStatus.Suspended:
					cbSubscriptionStatus.SelectedIndex = 2;
					break;

				case clsReader.enSubscriptionStatus.Banned:
					cbSubscriptionStatus.SelectedIndex = 3;
					break;

				default:
					cbSubscriptionStatus.SelectedIndex = -1;
					break;

			}
			switch(_Reader.SubscriptionPeriod)
			{
				case 1:
					cbSubscriptionPeriod.SelectedIndex = 0;
					break;
				case 2:
					cbSubscriptionPeriod.SelectedIndex = 1;
					break;
				case 3:
					cbSubscriptionPeriod.SelectedIndex = 2;
					break;
				
			}
			cbSubscriptionPeriod.Enabled = false;
		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
		{

		}

		private void cbSubscriptionPeriod_SelectedIndexChanged(object sender, EventArgs e)
		{

			switch (cbSubscriptionPeriod.Text)
			{
				case "1 - Month Subscription":
					dtpExpirtyDate.Value = DateTime.Now.AddMonths(1);
					break;
				case "3 - Month Subscription":
					dtpExpirtyDate.Value = DateTime.Now.AddMonths(3);
					break;
				case "1 - Year Subscription":
					dtpExpirtyDate.Value = DateTime.Now.AddYears(1);
					break;
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
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!_CheckRequiredControls())
			{
				return;
			}
			ctrlAddUpdatePersonInfo1.Save();
			_PersonID = ctrlAddUpdatePersonInfo1.PersonId;

			switch (cbSubscriptionPeriod.Text)
			{
				case "1-Month Subscription":
					_Reader.SubscriptionPeriod = 1;
					break;
				case "3-Month Subscription":
					_Reader.SubscriptionPeriod = 3;
					break;
				case "1-Year Subscription":
					_Reader.SubscriptionPeriod = 12;
					break;
			}

			switch (cbSubscriptionStatus.Text)
			{
				case "Active":
					_Reader.SubscriptionStatus = Convert.ToByte(clsReader.enSubscriptionStatus.Active);
					break;

				case "Expired":
					_Reader.SubscriptionStatus = Convert.ToByte(clsReader.enSubscriptionStatus.Expired);
					_Reader.IsActive = false;
					break;

				case "Suspended":
					_Reader.SubscriptionStatus = Convert.ToByte(clsReader.enSubscriptionStatus.Suspended);
					_Reader.IsActive = false;
					break;

				case "Banned":
					_Reader.SubscriptionStatus = Convert.ToByte(clsReader.enSubscriptionStatus.Banned);
					_Reader.IsActive = false;
					break;
			}
			_Reader.PersonID=_PersonID;
			_Reader.IsActive = chkIsActive.Checked;
			_Reader.Notes = txtNotes.Text.Trim();

			if (_Reader.Save())
			{
				lblTitle.Text = "Update Reader Info";
				pbMode.Image = Resources.editPerson__2_;
				_ReaderID = _Reader.ReaderID;
				lblReaderID.Text = _ReaderID.ToString();
				lblPersonID.Text = _Reader.ReaderID.ToString();
				lblLibraryCard.Text=_Reader.LibraryCardNumber.ToString();
				DateTime today = DateTime.Now;
				DateTime endDate = today.AddMonths(_Reader.SubscriptionPeriod);

				dtpExpirtyDate.Value = endDate;
				
				MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void cbSubscriptionPeriod_Validating(object sender, CancelEventArgs e)
		{
			if (cbSubscriptionPeriod.SelectedIndex == -1)
			{
				e.Cancel = true;
				errorProvider1.SetError(cbSubscriptionPeriod, "Please select a value.");
			}
			else
			{
				errorProvider1.SetError(cbSubscriptionPeriod , null);
			}
		}

		private void tabCompleteInfo_Validating(object sender, CancelEventArgs e)
		{
			
		}

		private void tbReaderInfo_Enter(object sender, EventArgs e)
		{
			if (!ctrlAddUpdatePersonInfo1.CheckRequiredControls())
			{
				//MessageBox.Show("Please fill in the personal information to complete registration.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tabCompleteInfo.SelectedTab = tbPersonalInfo;
			}
		}

		private void frmAddNewReader_Load(object sender, EventArgs e)
		{
			_ResetValues();
			if (_Mode == enMode.Update)
			{
				_LoadData(_ReaderID);
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void chkIsActive_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void cbSubscriptionStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			chkIsActive.Checked = cbSubscriptionStatus.Text == "Active";
		}
	}
}
