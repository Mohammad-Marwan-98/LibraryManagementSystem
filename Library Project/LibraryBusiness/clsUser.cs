using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsUser
	{
		[Flags]
		public enum enPermissions
		{
			All = -1,
			Books = 1,
			Readers = 2,
			Users = 4,
			Borrows = 8,
			Payments = 16,
			Settings =32,
			Reservations=64
			
		}

		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;
		public int UserID { get; set; }
		public int PersonID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public short Permissions { get; set; }
		public bool IsActive { get; set; }
		public clsPerson Person { get; set; }



		public clsUser()
		{
			this.UserID = -1;
			this.PersonID = -1;
			this.Username = "";
			this.Password = "";
			this.Permissions = -1;
			this.IsActive = false; 
			Mode = enMode.AddNew;
		}


		private clsUser(int userid, int personid, string username, string password, short permissions, bool isActive)
		{
			this.UserID = userid;
			this.PersonID = personid;
			this.Username = username;
			this.Password = password;
			this.Permissions = permissions;
			this.IsActive = isActive;
			Mode = enMode.Update;
			this.Person = clsPerson.Find(PersonID);

		}


		public static string HashData(string text)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hashbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

				return BitConverter.ToString(hashbytes).Replace("-", "").ToLower();
			}
		}

		public static DataTable GetAllUsers()
		{
			return clsUserData.GetAllUsers();
		}



		public static clsUser Find(int UserID)
		{
			int PersonID = -1;
			string Username = "";
			string Password = "";
			short Permissions = -1;
			bool IsActive = true;

			bool IsFound = clsUserData.FindUser(UserID, ref PersonID, ref Username, ref Password, ref Permissions, ref IsActive);

			if (IsFound)
			{
				return new clsUser(UserID, PersonID, Username,Password, Permissions, IsActive);
			}
			else
			{
				return null;
			}
		}


		private bool _AddNewUser()
		{
			this.UserID = clsUserData.AddNewUser(this.PersonID, this.Username, HashData(this.Password), this.Permissions, this.IsActive);
			return this.UserID != -1;
		}

		private bool _UpdateUser()
		{
			return clsUserData.UpdateUser(this.UserID, this.PersonID, this.Username, this.Password , this.Permissions, this.IsActive);
		}




		public static bool IsUserExist(int UserID)
		{
			return clsUserData.IsUserExist(UserID);
		}



		public static bool DeleteUser(int UserID)
		{
			return clsUserData.DeleteUser(UserID);
		}


		public static clsUser Login(string Username, string Password)
		{
			int UserID = -1;
			int PersonID = -1;
			short Permissions = -1;

			bool IsAuthenticated = clsUserData.Login(Username, HashData(Password), ref UserID, ref PersonID, ref Permissions);

			if (IsAuthenticated)
			{
				return new clsUser(UserID, PersonID, Username,Password, Permissions, true); 
			}

			return null;
		}




		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewUser())
					{
						Mode = enMode.Update;
						return true;
					}
					else { return false; }
				case enMode.Update:
					return _UpdateUser();
			}
			return false;
		}


	}
}
