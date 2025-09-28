using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsFine
	{
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;
		public int FineID { get; set; }
		private int ReaderID { get; set; }
		private int BorrowingRecordID { get; set; }
		private byte FineReason { get; set; }
		private byte NumberOfLateDays { get; set; }
		private decimal FineAmount { get; set; }
		public bool PaymentStatus { get; set; }
		private DateTime CreatedDate { get; set; }
		private int CreatedByUserID { get; set; }






		public clsFine()
		{
			this.FineID = -1;
			this.ReaderID = -1;
			this.BorrowingRecordID = -1;
			this.FineReason = 0;
			this.NumberOfLateDays = 0;
			this.FineAmount = -1;
			this.PaymentStatus = false;
			this.CreatedDate = DateTime.Now;
			this.CreatedByUserID = -1;
			Mode = enMode.AddNew;
		}

		private clsFine(int fineid, int readerid, int borrowingrecordid, byte finereason, byte numberoflatedays, decimal fineamount, bool paymentstatus, DateTime createddate, int createdbyuserid)
		{
			this.FineID = fineid;
			this.ReaderID = readerid;
			this.BorrowingRecordID = borrowingrecordid;
			this.FineReason = finereason;
			this.NumberOfLateDays = numberoflatedays;
			this.FineAmount = fineamount;
			this.PaymentStatus = paymentstatus;
			this.CreatedDate = createddate;
			this.CreatedByUserID = createdbyuserid;
			Mode = enMode.Update;
		}



		public static DataTable GetAllFines()
		{
			return clsFineData.GetAllFines();
		}



		public static clsFine Find(int FineID)
		{
			int ReaderID = -1;
			int BorrowingRecordID = -1;
			byte FineReason = 0;
			byte NumberOfLateDays = 0;
			decimal FineAmount = -1;
			bool PaymentStatus = false;
			DateTime CreatedDate = DateTime.Now;
			int CreatedByUserID = -1;

			bool IsFound = clsFineData.FindFine(FineID, ref ReaderID, ref BorrowingRecordID, ref FineReason, ref NumberOfLateDays, ref FineAmount, ref PaymentStatus, ref CreatedDate, ref CreatedByUserID);
			if (IsFound)
			{
				return new clsFine(FineID, ReaderID, BorrowingRecordID, FineReason, NumberOfLateDays, FineAmount, PaymentStatus, CreatedDate, CreatedByUserID);
			}
			else
			{
				return null;
			}
		}

		private bool _AddNewFines()
		{
			this.FineID = clsFineData.AddNewFine(this.ReaderID, this.BorrowingRecordID, this.FineReason, this.NumberOfLateDays, this.FineAmount,this.CreatedByUserID);
			return this.FineID != -1;
		}
		private bool _UpdateFines()
		{

			return clsFineData.UpdateFine(this.FineID,this.PaymentStatus);
		}





		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewFines())
					{
						Mode = enMode.Update;
						return true;
					}
					else { return false; }
				case enMode.Update:
					return _UpdateFines();
			}
			return false;
		}

	}
}
