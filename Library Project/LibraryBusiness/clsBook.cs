using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsBook
	{
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;

		public int BookID { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Description { get; set; }
		public bool IsAvailable { get; private set; }
		public string ISBN { get; set; }
		public DateTime PublicationDate { get; set; }
		public string Genre { get; set; }
		public string AdditionalDetails { get; set; }
		public short NumberOfCopies { get; set; }
		public string Language { get; set; }

		public clsBook()
		{
			this.BookID = -1;
			this.Title = "";
			this.Author = "";
			this.ISBN = "";
			this.PublicationDate = DateTime.MinValue;
			this.Genre = "";
			this.Description = "";
			this.AdditionalDetails = "";
			this.IsAvailable = true;
			this.Language = "";
			NumberOfCopies = -1;
			Mode = enMode.AddNew;
		}

		private clsBook(int bookid, string title, string author, string isbn,
				 DateTime publicationdate, string genre, string description,
				 string additionaldetails, bool isAvailable,
				 string language, short numberOfCopies)
		{
			this.BookID = bookid;
			this.Title = title;
			this.Author = author;
			this.ISBN = isbn;
			this.PublicationDate = publicationdate;
			this.Genre = genre;
			this.Description = description;
			this.AdditionalDetails = additionaldetails;
			this.IsAvailable = isAvailable;
			this.Language = language;
			this.NumberOfCopies = numberOfCopies;

			Mode = enMode.Update;
		}


		public static int GetNumberOfAvailableCopies(int BookID)
		{
			return clsBookData.GetNumberOfAvailableCopies(BookID);
		}



		public static DataTable GetAllBooks()
		{
			return clsBookData.GetAllBooks();
		}

		public static DataTable GetBooksWithZeroCopies()
		{
			return clsBookData.GetBooksWithZeroCopies();
		}



		public static clsBook FindBookByID(int BookID)
		{
			string Title = "";
			string Author = "";
			string ISBN = "";
			DateTime PublicationDate = DateTime.Now;
			string Genre = "";
			string Description = "";
			string AdditionalDetails = "";
			bool IsAvailable = false;
			string Language = "";
			short NumberOfCopies = -1;

			bool IsFound = clsBookData.FindBookByID(BookID, ref Title, ref ISBN, ref PublicationDate,
													ref Genre, ref AdditionalDetails, ref Author,
													ref Description, ref IsAvailable,
													ref Language, ref NumberOfCopies);

			if (IsFound)
			{
				return new clsBook(BookID, Title, Author, ISBN, PublicationDate, Genre,
									Description, AdditionalDetails, IsAvailable, Language, NumberOfCopies);
			}
			else
			{
				return null;
			}
		}




		public static clsBook FindBookByTitle(string Title)
		{
			int BookID = -1;
			string ISBN = "";
			DateTime PublicationDate = DateTime.Now;
			string Genre = "";
			string AdditionalDetails = "";
			string Author = "";
			string Description = "";
			bool IsAvailable = false;
			string Language = "";
			short NumberOfCopies = -1;

			bool IsFound = clsBookData.FindBookByTitle(ref BookID, Title, ref ISBN, ref PublicationDate,
													   ref Genre, ref AdditionalDetails, ref Author,
													   ref Description, ref IsAvailable,
													   ref Language, ref NumberOfCopies);

			if (IsFound)
			{
				return new clsBook(BookID, Title, Author, ISBN, PublicationDate, Genre,
									Description, AdditionalDetails, IsAvailable, Language, NumberOfCopies);
			}
			else
			{
				return null;
			}
		}


		public static clsBook FindBookByISBN(string ISBN)
		{
			int BookID = -1;
			string Title = "";
			DateTime PublicationDate = DateTime.Now;
			string Genre = "";
			string AdditionalDetails = "";
			string Author = "";
			string Description = "";
			bool IsAvailable = false;
			string Language = "";
			short NumberOfCopies = -1;

			bool IsFound = clsBookData.FindBookByISBN(ref BookID, ref Title, ISBN, ref PublicationDate,
													  ref Genre, ref AdditionalDetails, ref Author,
													  ref Description, ref IsAvailable,
													  ref Language, ref NumberOfCopies);

			if (IsFound)
			{
				return new clsBook(BookID, Title, Author, ISBN, PublicationDate, Genre,
									Description, AdditionalDetails, IsAvailable, Language, NumberOfCopies);
			}
			else
			{
				return null;
			}
		}




		private bool _AddNewBooks()
		{
			this.BookID = clsBookData.AddNewBook(this.Title, this.Author, this.ISBN,
												 this.PublicationDate, this.Genre,
												 this.Description, this.AdditionalDetails,
												 this.Language,
												 this.NumberOfCopies);

			return this.BookID != -1;
		}



		private bool _UpdateBooks()
		{
			return clsBookData.UpdateBook(this.BookID, this.Title, this.Author, this.ISBN,
										  this.PublicationDate, this.Genre,
										  this.Description, this.AdditionalDetails,
										  this.Language); 
		}






		public static bool IsBookExsistByID(int BookID)
		{
			return clsBookData.IsBookExistByID(BookID);
		}



		public static bool DeleteBook(int BookID)
		{
			return clsBookData.DeleteBook(BookID);
		}

		

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewBooks())
					{
						Mode = enMode.Update;
						return true;
					}
					else { return false; }
				case enMode.Update:
					return _UpdateBooks();
			}
			return false;
		}

		


	}
}
