using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsReservation
	{
		public enum enMode{AddNew = 0,Update = 1}
		private enMode _Mode;
		public int ReservationID { get; set; }
		public int ReaderID { get; set; }
		public int BookID { get; set; }
		public DateTime ReservationDate { get; set; }
		public int CreatedByUserID { get; set; }
		public bool IsActive { get; set; }
		public clsUser User { get; set; }
		public clsReader Reader { get; set; }






		public clsReservation()
		{
			this.ReservationID = -1;
			this.ReaderID = -1;
			this.BookID = -1;
			this.ReservationDate = DateTime.Now;
			this.CreatedByUserID = -1;
			this.IsActive = false;
			_Mode = enMode.AddNew;
		}

		private clsReservation(int reservationid, int readerid, int bookid, DateTime reservationdate, int createdbyuserid, bool isactive)
		{
			this.ReservationID = reservationid;
			this.ReaderID = readerid;
			this.BookID = bookid;
			this.ReservationDate = reservationdate;
			this.CreatedByUserID = createdbyuserid;
			this.IsActive = isactive;
			this.Reader = clsReader.Find(readerid);
			this.User = clsUser.Find(createdbyuserid);
			_Mode = enMode.Update;
		}



		public static DataTable GetAllReservations()
		{
			return clsReservationData.GetAllReservations();
		}



		public static clsReservation Find(int ReservationID)
		{
			int ReaderID = -1;
			int BookID = -1;
			DateTime ReservationDate = DateTime.Now;
			int CreatedByUserID = -1;
			bool IsActive = false;

			bool IsFound = clsReservationData.FindReservation(ReservationID, ref ReaderID, ref BookID, ref ReservationDate, ref CreatedByUserID, ref IsActive);
			if (IsFound)
			{
				return new clsReservation(ReservationID, ReaderID, BookID, ReservationDate, CreatedByUserID, IsActive);
			}
			else
			{
				return null;
			}
		}

		public static clsReservation GetFirstActiveReservation(int BookID)
		{
			DataTable dt = clsReservationData.GetFirstActiveReservation(BookID);

			if (dt.Rows.Count == 0)
				return null;

			int ReservationID = (int)dt.Rows[0]["ReservationID"];

			return clsReservation.Find(ReservationID);
		}


		private bool _AddNewReservation()
		{
			this.ReservationID = clsReservationData.AddNewReservation(this.ReaderID, this.BookID, this.CreatedByUserID);
			return this.ReservationID != -1;
		}

		private bool _UpdateReservation()
		{
			return clsReservationData.UpdateReservationStatus(this.ReservationID, this.IsActive);
		}



		public static bool DeleteReservation(int ReservationID)
		{
			return clsReservationData.DeleteReservation(ReservationID);
		}



		public bool Save()
		{
			switch (_Mode)
			{
				case enMode.AddNew:
					if (_AddNewReservation())
					{
						_Mode = enMode.Update;
						return true;
					}
					else { return false; }
				case enMode.Update:
					return _UpdateReservation();
			}
			return false;
		}

		private static bool _SendEmail(string toEmail, string bookTitle)
		{
			try
			{
				SmtpClient smtp = new SmtpClient("smtp.gmail.com")
				{
					Port = 587,
					Credentials = new NetworkCredential("mohammad.library98@gmail.com", "pqsieijlxseguzxo"),
					EnableSsl = true
				};

				MailMessage mail = new MailMessage();
				mail.From = new MailAddress("mohammad.library98@gmail.com", "Library System");
				mail.To.Add(toEmail);
				mail.Subject = "Book Now Available";
				mail.Body = $"The book \"{bookTitle}\" you reserved is now available. Please visit the library to borrow it.";

				smtp.Send(mail);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static bool NotifyFirstReservation(int BookID)
		{
			clsReservation reservation = GetFirstActiveReservation(BookID);

			if (reservation == null || reservation.Reader == null)
				return false;

			string email = reservation.Reader.Person.Email;
			clsBook book = clsBook.FindBookByID(BookID);
            if (book.NumberOfCopies == 0)
            {
				return false;   
            }
            string bookTitle = book.Title;

			if (_SendEmail(email, bookTitle))
			{
				reservation.IsActive = false;
				return reservation.Save();
			}

			return false;
		}


	}
}
