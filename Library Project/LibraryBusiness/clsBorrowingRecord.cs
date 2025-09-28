using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsBorrowingRecord
	{
		public enum enStatus { Borrowed = 0, Returned = 1, OverDue = 2, Lost = 3, Extended = 4, Damaged = 5 }
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;
		public int BorrowingRecordID { get; set; }
		public int ReaderID { get; set; }
		public int CopyID { get; set; }
		public DateTime BorrowingDate { get; set; }
		public DateTime DueDate { get; set; }
		public DateTime ActualReturnDate { get; set; }
		public byte BorrowStatus { get; set; }
		public byte ExtensionCount { get; set; }
		public string Notes { get; set; }
		public int CreatedByUserID { get; set; }
		public int LastModifiedByUserID { get; set; }
		public DateTime LastModifiedDate { get; set; }
		public clsReader Reader { get; set; }





		public clsBorrowingRecord()
		{
			this.BorrowingRecordID = -1;
			this.ReaderID = -1;
			this.CopyID = -1;
			this.BorrowingDate = DateTime.MinValue;
			this.DueDate = DateTime.MinValue;
			this.ActualReturnDate = DateTime.MinValue;
			this.BorrowStatus = 0;
			this.ExtensionCount = 0;
			this.Notes = "";
			this.CreatedByUserID = -1;
			this.LastModifiedByUserID = -1;
			this.LastModifiedDate = DateTime.MinValue;
			Mode = enMode.AddNew;
		}

		private clsBorrowingRecord(int borrowingrecordid, int readerid, int copyid, DateTime borrowingdate, DateTime duedate, DateTime actualreturndate, byte borrowstatus, byte extensioncount, string notes, int createdbyuserid, int lastmodifiedbyuserid, DateTime lastmodifieddate)
		{
			this.BorrowingRecordID = borrowingrecordid;
			this.ReaderID = readerid;
			this.CopyID = copyid;
			this.BorrowingDate = borrowingdate;
			this.DueDate = duedate;
			this.ActualReturnDate = actualreturndate;
			this.BorrowStatus = borrowstatus;
			this.ExtensionCount = extensioncount;
			this.Notes = notes;
			this.CreatedByUserID = createdbyuserid;
			this.LastModifiedByUserID = lastmodifiedbyuserid;
			this.LastModifiedDate = lastmodifieddate;
			Reader = clsReader.Find(readerid);
			Mode = enMode.Update;
		}



		public static DataTable GetAllBorrowingRecords()
		{
			return clsBorrowingRecordData.GetAllBorrowingRecords();
		}



		public static clsBorrowingRecord Find(int BorrowingRecordID)
		{
			int ReaderID = -1;
			int CopyID = -1;
			DateTime BorrowingDate = DateTime.MinValue;
			DateTime DueDate = DateTime.MinValue;
			DateTime ActualReturnDate = DateTime.MinValue;
			byte BorrowStatus = 0;
			byte ExtensionCount = 0;
			string Notes = "";
			int CreatedByUserID = -1;
			int LastModifiedByUserID = -1;
			DateTime LastModifiedDate = DateTime.MinValue;

			bool IsFound = clsBorrowingRecordData.FindBorrowingRecord(BorrowingRecordID, ref ReaderID, ref CopyID, ref BorrowingDate, ref DueDate, ref ActualReturnDate, ref BorrowStatus, ref ExtensionCount, ref Notes, ref CreatedByUserID, ref LastModifiedByUserID, ref LastModifiedDate);
			if (IsFound)
			{
				return new clsBorrowingRecord(BorrowingRecordID, ReaderID, CopyID, BorrowingDate, DueDate, ActualReturnDate, BorrowStatus, ExtensionCount, Notes, CreatedByUserID, LastModifiedByUserID, LastModifiedDate);
			}
			else
			{
				return null;
			}
		}

		private bool _AddNewBorrowingRecords()
		{
			this.BorrowingRecordID = clsBorrowingRecordData.AddNewBorrowingRecord(this.ReaderID, this.CopyID, this.BorrowingDate, this.DueDate, this.ActualReturnDate, this.BorrowStatus, this.Notes, this.CreatedByUserID);
			return this.BorrowingRecordID != -1;
		}



		private bool _UpdateBorrowingRecords()
		{

			return clsBorrowingRecordData.UpdateBorrowingRecord(this.BorrowingRecordID, this.BorrowingDate, this.DueDate, this.ActualReturnDate, this.BorrowStatus, this.ExtensionCount, this.Notes, this.LastModifiedByUserID, this.LastModifiedDate);
		}



		public static bool IsBorrowingRecordExist(int BorrowingRecordID)
		{
			return clsBorrowingRecordData.IsBorrowingRecordExist(BorrowingRecordID);
		}





		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewBorrowingRecords())
					{
						Mode = enMode.Update;
						return true;
					}
					else { return false; }
				case enMode.Update:
					return _UpdateBorrowingRecords();
			}
			return false;
		}

	}
}
