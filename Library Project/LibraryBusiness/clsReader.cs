using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsReader
	{
		public enum enSubscriptionStatus { Active = 1, Expired = 2 ,Suspended = 3 ,Banned =4};
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;
		public int ReaderID { get; private set; }
		public int PersonID { get;  set; }
		public clsPerson Person { get; set; }
		public string LibraryCardNumber { get; set; }
		public byte SubscriptionStatus { get; set; }
		public byte SubscriptionPeriod {  get ; set; } 
		public DateTime JoinDate { get; private set; }
		public DateTime SubscriptionExpiryDate { get; private set; }
		public bool IsActive { get; set; }
		public string Notes { get; set; }






		public clsReader()
		{
			this.ReaderID = -1;
			this.PersonID = -1;
			this.LibraryCardNumber = "";
			this.SubscriptionStatus = 0;
			this.JoinDate = DateTime.MinValue;
			this.SubscriptionExpiryDate = DateTime.MinValue;
			this.IsActive = false;
			this.Notes = "";
			Mode = enMode.AddNew;
		}

		private clsReader(int readerid, int personid, string librarycardnumber, byte subscriptionstatus, DateTime joindate, DateTime subscriptionexpirydate, bool isactive, string notes)
		{
			this.ReaderID = readerid;
			this.PersonID = personid;
			this.LibraryCardNumber = librarycardnumber;
			this.SubscriptionStatus = subscriptionstatus;
			this.JoinDate = joindate;
			this.SubscriptionExpiryDate = subscriptionexpirydate;
			this.IsActive = isactive;
			this.Notes = notes;
			this.Person = clsPerson.Find(PersonID);
			Mode = enMode.Update;
		}



		public static DataTable GetAllReaders()
		{
			return clsReaderData.GetAllReaders();
		}



		public static clsReader Find(int ReaderID)
		{
			int PersonID = -1;
			string LibraryCardNumber = "";
			byte SubscriptionStatus = 0;
			DateTime JoinDate = DateTime.MinValue;
			DateTime SubscriptionExpiryDate = DateTime.MinValue;
			bool IsActive = false;
			string Notes = "";

			bool IsFound = clsReaderData.FindReader(ReaderID, ref PersonID, ref LibraryCardNumber, ref SubscriptionStatus, ref JoinDate, ref SubscriptionExpiryDate, ref IsActive, ref Notes);
			if (IsFound)
			{
				return new clsReader(ReaderID, PersonID, LibraryCardNumber, SubscriptionStatus, JoinDate, SubscriptionExpiryDate, IsActive, Notes);
			}
			else
			{
				return null;
			}
		}

		public static clsReader Find(string LibraryCardNumber)
		{
			int ReaderID = -1;
			int PersonID = -1;
			byte SubscriptionStatus = 0;
			DateTime JoinDate = DateTime.MinValue;
			DateTime SubscriptionExpiryDate = DateTime.MinValue;
			bool IsActive = false;
			string Notes = "";

			bool IsFound = clsReaderData.FindReaderByLibraryCard(ref ReaderID, ref PersonID, LibraryCardNumber, ref SubscriptionStatus, ref JoinDate, ref SubscriptionExpiryDate, ref IsActive, ref Notes);
			if (IsFound)
			{
				return new clsReader(ReaderID, PersonID, LibraryCardNumber, SubscriptionStatus, JoinDate, SubscriptionExpiryDate, IsActive, Notes);
			}
			else
			{
				return null;
			}
		}

		private bool _AddNewReaders()
		{
			this.ReaderID = clsReaderData.AddNewReader(this.PersonID, this.LibraryCardNumber, this.SubscriptionStatus, this.SubscriptionPeriod, this.IsActive, this.Notes);
			return this.ReaderID != -1;
		}
		private bool _UpdateReaders()
		{

			return clsReaderData.UpdateReader(this.ReaderID, this.SubscriptionStatus, this.IsActive, this.Notes);
		}



		public static bool IsExistReaders(int ReaderID)
		{
			return clsReaderData.IsReaderExist(ReaderID);
		}

		public static bool ExtendSubscription(int ReaderID,byte SubscriptionPeriod)
		{
			return clsReaderData.ExtendSubscription(ReaderID,SubscriptionPeriod);
		}



		public static bool DeleteReader(int ReaderID)
		{
			return clsReaderData.DeleteReader(ReaderID);
		}

		private void _GenerateLibraryCardNumber()
		{
			this.LibraryCardNumber = clsReaderData.GenerateLibraryCardNumber();
		}


		public bool Save()
		{


			switch (Mode)
			{
				case enMode.AddNew:
					_GenerateLibraryCardNumber();
					if (_AddNewReaders())
					{
						Mode = enMode.Update;
						return true;
					}
					else { return false; }
				case enMode.Update:
					return _UpdateReaders();
			}
			return false;
		}


	}
}

