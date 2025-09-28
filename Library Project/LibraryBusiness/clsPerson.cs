using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsPerson
	{

		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;
		public int PersonID { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string ThirdName { get; set; }
		public string LastName { get; set; }
		public byte Age { get; set; }
		public string Address { get; set; }
		public string Gender { get; set; }
		public string Email { get; set; }
		public string MobileNumber { get; set; }






		public clsPerson()
		{
			this.PersonID = -1;
			this.FirstName = "";
			this.SecondName = "";
			this.ThirdName = "";
			this.LastName = "";
			this.Age = 0;
			this.Address = "";
			this.Gender = "";
			this.Email = "";
			this.MobileNumber = "";
			Mode = enMode.AddNew;
		}

		private clsPerson(int personid, string firstname, string secondname, string thirdname, string lastname, byte age, string address, string gender, string email, string mobilenumber)
		{
			this.PersonID = personid;
			this.FirstName = firstname;
			this.SecondName = secondname;
			this.ThirdName = thirdname;
			this.LastName = lastname;
			this.Age = age;
			this.Address = address;
			this.Gender = gender;
			this.Email = email;
			this.MobileNumber = mobilenumber;
			Mode = enMode.Update;
		}



		public static DataTable GetAllPeople()
		{
			return clsPersonData.GetAllPeople();
		}



		public static clsPerson Find(int PersonID)
		{
			string FirstName = "";
			string SecondName = "";
			string ThirdName = "";
			string LastName = "";
			byte Age = 0;
			string Address = "";
			string Gender = "";
			string Email = "";
			string MobileNumber = "";

			bool IsFound = clsPersonData.FindPerson(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Age, ref Address, ref Gender, ref Email, ref MobileNumber);
			if (IsFound)
			{
				return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, Age, Address, Gender, Email, MobileNumber);
			}
			else
			{
				return null;
			}
		}

		private bool _AddNewPeople()
		{
			this.PersonID = clsPersonData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Age, this.Address, this.Gender, this.Email, this.MobileNumber);
			return this.PersonID != -1;
		}



		private bool _UpdatePeople()
		{

			return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Age, this.Address, this.Gender, this.Email, this.MobileNumber);
		}



		public static bool IsExistPeople(int PersonID)
		{
			return clsPersonData.IsPersonExist(PersonID);
		}



		public static bool DeletePeople(int PersonID)
		{
			return clsPersonData.DeletePerson(PersonID);
		}



		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewPeople())
					{
						Mode = enMode.Update;
						return true;
					}
					else { return false; }
				case enMode.Update:
					return _UpdatePeople();
			}
			return false;
		}


	}
}

