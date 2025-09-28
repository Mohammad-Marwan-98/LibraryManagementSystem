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
	public partial class frmAddBorrowRecord : Form
	{
		private clsReader _Reader = new clsReader();
		private DataTable _dtCopies;
		private clsBorrowingRecord _BorrowingRecord = new clsBorrowingRecord();
		public frmAddBorrowRecord()
		{
			InitializeComponent();
		}

		private void txtBookId_Validating(object sender, CancelEventArgs e)
		{
			if(string.IsNullOrEmpty(txtLibraryCardNumber.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtLibraryCardNumber, "This Field Is Required");
			}
			else
			{
				errorProvider1.SetError(txtLibraryCardNumber, null);
			}
		}

		private void txtBookId_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
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
			txtNotes.Text=_Reader.Notes;
			lblReaderID.Text = _Reader.ReaderID.ToString();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_LoadReaderInfo(txtLibraryCardNumber.Text);

		}

		private void frmAddBorrowRecord_Load(object sender, EventArgs e)
		{
			ctrlFindBook1.OnBookSelected += OnBookSelected;

		}

		private void OnBookSelected(int bookID)
		{
			cbCopies.Items.Clear();
			_dtCopies = clsBookCopy.GetAllCopies(bookID);
			foreach (DataRow row in _dtCopies.Rows)
			{
				cbCopies.Items.Add(row["CopyID"].ToString());
			}
		}

		private void _FillBorrowingRecord()
		{
			_BorrowingRecord.ReaderID=_Reader.ReaderID;
			_BorrowingRecord.CopyID=Convert.ToInt32(cbCopies.Text);
			_BorrowingRecord.BorrowingDate=DateTime.Now;
			_BorrowingRecord.DueDate = DateTime.Now.AddDays(clsGlobal.Settings.DefaultBorrowDays);
			_BorrowingRecord.Notes= txtNotes.Text;
			_BorrowingRecord.BorrowStatus = Convert.ToByte(clsBorrowingRecord.enStatus.Borrowed);
			_BorrowingRecord.CreatedByUserID=clsGlobal.CurrentUser.UserID;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_FillBorrowingRecord();
			if (_BorrowingRecord.Save())
			{
				clsBookCopy.UpdateCopy(Convert.ToInt32(cbCopies.Text),false);
				MessageBox.Show("The borrowing record has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Failed to save the borrowing record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbCopies.Text))
			{
				MessageBox.Show("Please select a specific copy.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			tabBorrowRecord.SelectedIndex = 1;
		}

		private void tpReaderInfo_Enter(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbCopies.Text))
			{
				MessageBox.Show("Please select a specific copy.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tabBorrowRecord.SelectedIndex = 0;

			}
		}
	}
}
