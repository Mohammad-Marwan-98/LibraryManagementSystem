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
	public partial class frmBorrowingRecordNotes : Form
	{
		private int _RecordID;
		private clsBorrowingRecord _BorrowingRecord = new clsBorrowingRecord();
		public frmBorrowingRecordNotes(int RecordID)
		{
			InitializeComponent();
			_RecordID = RecordID;
		}

		private void frmBorrowingRecordNotes_Load(object sender, EventArgs e)
		{
			_BorrowingRecord = clsBorrowingRecord.Find(_RecordID);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_BorrowingRecord.Notes))
			{
				_BorrowingRecord.Notes = txtNotes.Text;
			}
			else
			{
				_BorrowingRecord.Notes += " , " + txtNotes.Text;
			}
			if (_BorrowingRecord.Save())
			{
				MessageBox.Show("The notes have been saved successfully.", "Notes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Failed to save the notes.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
