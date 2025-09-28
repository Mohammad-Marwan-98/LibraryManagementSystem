using Guna.UI2.WinForms;
using Library.Properties;
using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class frmAddUpdateBook : Form
	{

		private enum enMode { AddNew = 0, Update = 1 }
		private enMode _Mode;

		private int _BookId;

		private clsBook _Book= new clsBook();

		public frmAddUpdateBook()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
		}

		public frmAddUpdateBook(int BookID)
		{
			InitializeComponent();
			_BookId = BookID;
			_Mode = enMode.Update;

		}

		private void _ResetDefaultValues()
		{
			txtTitle.Text = string.Empty;
			txtAuthor.Text = string.Empty;
			txtISBN.Text = string.Empty;
			txtGenre.Text = string.Empty;
			txtDescription.Text = string.Empty;
			txtAdditionalDetails.Text = string.Empty;
			txtLanguage.Text = string.Empty;
			nudNumberOfCopies.Value = 0;
			dtpPublicationDate.Value = DateTime.Now;

		}

		private void _LoadData()
		{
			_Book = clsBook.FindBookByID(_BookId);
			lblTitle.Text = "Update Book";
			pbBook.Image = Resources.UpdateBook;
			lblBookID.Text = _Book.BookID.ToString();
			txtTitle.Text = _Book.Title;
			txtAuthor.Text = _Book.Author;
			txtISBN.Text = _Book.ISBN;
			txtDescription.Text = _Book.Description;
			txtLanguage.Text = _Book.Language;
			txtAdditionalDetails.Text = _Book.AdditionalDetails;
			txtGenre.Text = _Book.Genre;
			dtpPublicationDate.Value = _Book.PublicationDate;
			nudNumberOfCopies.Value = _Book.NumberOfCopies;
			nudNumberOfCopies.Enabled = false;
		}

		private void frmAddUpdateBook_Load(object sender, EventArgs e)
		{
			_ResetDefaultValues();

			if (_Mode == enMode.Update)
				_LoadData();

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			_Book.Title = txtTitle.Text.Trim();
			_Book.Author = txtAuthor.Text.Trim();
			_Book.ISBN = txtISBN.Text.Trim();
			_Book.Description = txtDescription.Text.Trim();
			_Book.Genre = txtGenre.Text.Trim();
			_Book.Language = txtLanguage.Text.Trim();
			_Book.PublicationDate = dtpPublicationDate.Value;
			_Book.AdditionalDetails = txtAdditionalDetails.Text.Trim();
			_Book.NumberOfCopies = Convert.ToInt16(nudNumberOfCopies.Value);
			if (_Book.Save())
			{
				lblTitle.Text = "Update Book";
				pbBook.Image = Resources.UpdateBook;
				_BookId = _Book.BookID;
				nudNumberOfCopies.Enabled = false;
				lblBookID.Text = _BookId.ToString();
				MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			

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

		private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true; 
			}
		}
	}
}
