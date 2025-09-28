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
	public partial class ctrlBookDetails : UserControl
	{
		

		private int _BookId;

		private clsBook _Book ;

		public ctrlBookDetails()
		{
			InitializeComponent();
			
		}

		private void _FillBookInfo()
		{
			lblID.Text = _Book.BookID.ToString();
			lblTitle.Text = _Book.Title.ToString();
			lblISBN.Text = _Book.ISBN.ToString();
			lblGenre.Text = _Book.Genre.ToString();
			lblAuthor.Text = _Book.Author.ToString();
			lblLanguage.Text = _Book.Language.ToString();
			lblNumberOfCopies.Text = _Book.NumberOfCopies.ToString();
			txtDescription.Text=_Book.Description.ToString();
			txtAdditionalDetails.Text = _Book.AdditionalDetails.ToString();
			lblPublicationDate.Text = _Book.PublicationDate.ToShortDateString();
		}

		private void _ResetPersonInfo()
		{
			lblID.Text = "??";
			lblTitle.Text = "??";
			lblISBN.Text = "??";
			lblGenre.Text = "??";
			lblAuthor.Text = "??";
			lblLanguage.Text = "??";
			lblNumberOfCopies.Text = "??";
			txtDescription.Text = string.Empty;
			txtAdditionalDetails.Text = string.Empty;
			lblPublicationDate.Text = "??";

		}

		public void LoadInfo(int BookID)
		{
			_Book = clsBook.FindBookByID(BookID);
			if(_Book == null)
			{
				_ResetPersonInfo();
				MessageBox.Show("No book was found with Book ID = " + BookID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillBookInfo();

		}

		
	}
}
