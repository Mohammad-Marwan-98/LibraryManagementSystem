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
using static Guna.UI2.Native.WinApi;

namespace Library
{
	public partial class ctrlAddUpdatePersonInfo : UserControl
	{

		private enum enMode { Addnew = 1, Update = 2 }
		private enMode _Mode;
		private clsPerson _Person=new clsPerson();
		public int PersonId { get; private set; }

		public ctrlAddUpdatePersonInfo()
		{
			InitializeComponent();
			_Mode = enMode.Addnew;
		}

		public ctrlAddUpdatePersonInfo(int PersonID)
		{
			InitializeComponent();
			_Mode = enMode.Update;
			PersonId = PersonID;
		}

		

		private void _ResetValues()
		{
			txtFirstName.Text = string.Empty;
			txtSecondName.Text = string.Empty;
			txtThirdName.Text = string.Empty;
			txtLastName.Text = string.Empty;
			txtAge.Text = string.Empty;
			txtAddress.Text = string.Empty;
			rbFemale.Checked = true;
			txtEmail.Text = string.Empty;
			txtMobileNumber.Text = string.Empty;
		}

		public void LoadData(int personID)
		{
			_Mode = enMode.Update;
			PersonId = personID;
			_LoadData(PersonId);
		}

		private void _LoadData(int personID)
		{
			_Person = clsPerson.Find(personID);
			lblPersonID.Text=personID.ToString();
			txtFirstName.Text = _Person.FirstName;
			txtSecondName.Text = _Person.SecondName;
			txtThirdName.Text	= _Person.ThirdName;
			txtLastName.Text = _Person.LastName;
			txtAge.Text=_Person.Age.ToString();
			txtAddress.Text = _Person.Address;
			txtEmail.Text=_Person.Email;
			txtMobileNumber.Text = _Person.MobileNumber;

			if (_Person.Gender.ToLower() == "male")
				rbMale.Checked = true;
			else
				rbFemale.Checked = true;
			lblTitle.Text = "Edit Personal Info";
			pbMode.Image = Resources.editPerson__2_;

		}

		private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
		{
			Guna2TextBox temp = (Guna2TextBox)sender;
			if (string.IsNullOrEmpty(temp.Text.Trim()))
			{
				e.Cancel = true;
				errorProvider1.SetError(temp, "This Field Is Required");
			}

			else
			{
				errorProvider1.SetError(temp, null);
			}
		}

		private void ctrlAddUpdatePersonInfo_Load(object sender, EventArgs e)
		{
			_ResetValues();
			if(_Mode == enMode.Update)
			{
				_LoadData(PersonId);
			}
		}

		public bool CheckRequiredControls()
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}
			return true;
		}

		public void Save()
		{

			if (!CheckRequiredControls())
			{
				return;
			}
			_Person.FirstName = txtFirstName.Text.Trim();
			_Person.SecondName = txtSecondName.Text.Trim();
			_Person.ThirdName = txtThirdName.Text.Trim();
			_Person.LastName = txtLastName.Text.Trim();
			_Person.Email = txtEmail.Text.Trim();
			_Person.MobileNumber = txtMobileNumber.Text.Trim();
			_Person.Age = Convert.ToByte(txtAge.Text);
			if (rbMale.Checked)
			{
				_Person.Gender = "Male";
			}
			else
			{
				_Person.Gender = "Female";
			}
			_Person.Address= txtAddress.Text.Trim();

			if (_Person.Save())
			{
				lblTitle.Text = "Update Personal Info";
				pbMode.Image = Resources.editPerson__2_;
				PersonId = _Person.PersonID;
				lblPersonID.Text = PersonId.ToString();
				MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
