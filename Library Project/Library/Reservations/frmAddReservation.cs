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
	public partial class frmAddReservation : Form
	{
		private DataTable _dtBooksWithZeroCopies;
		private clsReader _Reader;
		private clsReservation _Reservation = new clsReservation();

		public frmAddReservation()
		{
			InitializeComponent();
		}

		private void frmAddReservation_Load(object sender, EventArgs e)
		{
			_dtBooksWithZeroCopies = clsBook.GetBooksWithZeroCopies();
			foreach(DataRow row in _dtBooksWithZeroCopies.Rows)
			{
				cbBooks.Items.Add(row["Title"].ToString());
			}
		}

		private void _LoadReaderInfo(string LibraryCardNumber)
		{
			_Reader = clsReader.Find(LibraryCardNumber);
			if (_Reader == null)
			{
				ctrlPersonDetails1.ResetValues();
				chkIsActive.Checked = false;
				lblReaderID.Text = "??";
				txtNotes.Text = string.Empty;
				MessageBox.Show("No Reader with Library Card No. = " + LibraryCardNumber.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			ctrlPersonDetails1.LoadData(_Reader.PersonID);
			chkIsActive.Checked = _Reader.IsActive;
			txtNotes.Text = _Reader.Notes;
			lblReaderID.Text = _Reader.ReaderID.ToString();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			_LoadReaderInfo(txtLibraryCardNumber.Text);
		}

		private void txtLibraryCardNumber_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtLibraryCardNumber.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtLibraryCardNumber, "This Field Is Required");
			}
			else
			{
				errorProvider1.SetError(txtLibraryCardNumber , null);
			}
		}

		private void cbBooks_Validating(object sender, CancelEventArgs e)
		{
			if (cbBooks.SelectedIndex == -1)
			{
				e.Cancel = true;
				errorProvider1.SetError(cbBooks, "Please select a value.");
			}
			else
			{
				errorProvider1.SetError(cbBooks, null);
			}
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
			_Reservation.CreatedByUserID=clsGlobal.CurrentUser.UserID;
			_Reservation.ReaderID = _Reader.ReaderID;
			_Reservation.BookID = (int)_dtBooksWithZeroCopies.Rows[cbBooks.SelectedIndex]["BookID"];
			if (_Reservation.Save())
			{
				lblReservationID.Text = _Reservation.ReservationID.ToString();
				MessageBox.Show("Reservation has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Reservation could not be saved.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
	}
}
