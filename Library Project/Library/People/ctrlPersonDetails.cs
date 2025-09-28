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
	public partial class ctrlPersonDetails : UserControl
	{
		private int _PersonID;
		private clsPerson _Person = new clsPerson();
        public ctrlPersonDetails()
        {
            InitializeComponent();
        }
        public ctrlPersonDetails(int personID)
		{
			InitializeComponent();
			_PersonID = personID;
		}

		public void ResetValues()
		{
			lblPersonID.Text = "??";
			lblFirstName.Text = "??";
			lblSecondName.Text = "??";
			lblThirdName.Text = "??";
			lblLastName.Text = "??";
			lblAge.Text = "??";
			lblAddress.Text = "??";
			lblEmail.Text = "??";
			lblMobileNumber.Text = "??";
			pbGender.Image = Resources.Gender;
		}

		private void _LoadData()
		{
			_Person = clsPerson.Find(_PersonID);
			lblPersonID.Text = _PersonID.ToString();
			lblFirstName.Text = _Person.FirstName;
			lblSecondName.Text = _Person.SecondName;
			lblThirdName.Text = _Person.ThirdName;
			lblLastName.Text = _Person.LastName;
			lblAge.Text=_Person.Age.ToString();
			lblAddress.Text = _Person.Address;
			lblEmail.Text = _Person.Email;
			lblMobileNumber.Text = _Person.MobileNumber;
			if (_Person.Gender == "Male") {
				pbGender.Image = Resources.male;
					}
			else {
				pbGender.Image = Resources.female;
			}
		}

		public void LoadData(int PersonID)
		{
			_PersonID = PersonID;
			_LoadData();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
