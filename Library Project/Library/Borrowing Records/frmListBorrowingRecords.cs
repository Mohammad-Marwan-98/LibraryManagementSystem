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
	public partial class frmListBorrowingRecords : Form
	{
		private clsBorrowingRecord _BorrowingRecord = new clsBorrowingRecord();
		private DataTable _dtBorrowingRecords;

		public frmListBorrowingRecords()
		{
			InitializeComponent();
		}

		private void _AdjustDgvSize()
		{
			int mergin = 50;
			dgvBorrowingRecords.Left = mergin;
			dgvBorrowingRecords.Width = this.ClientSize.Width - (mergin * 2);

		}

		private void _RefreshBorroingRecordsList()
		{
			_dtBorrowingRecords = clsBorrowingRecord.GetAllBorrowingRecords();
			dgvBorrowingRecords.DataSource = _dtBorrowingRecords;
			lblRecords.Text = dgvBorrowingRecords.Rows.Count.ToString();
		}

		private void frmListBorrowingRecords_Load(object sender, EventArgs e)
		{
			_RefreshBorroingRecordsList();
			_AdjustDgvSize();
			dgvBorrowingRecords.DataSource = _dtBorrowingRecords;

			if (dgvBorrowingRecords.Rows.Count > 0)
			{
				dgvBorrowingRecords.Columns[0].HeaderText = "Record ID";
				dgvBorrowingRecords.Columns[0].Width = 60;

				dgvBorrowingRecords.Columns[1].HeaderText = "Full Name";
				dgvBorrowingRecords.Columns[1].Width = 100;

				dgvBorrowingRecords.Columns[2].HeaderText = "Book Title";
				dgvBorrowingRecords.Columns[2].Width = 100;

				dgvBorrowingRecords.Columns[3].HeaderText = "Borrowing Date";
				dgvBorrowingRecords.Columns[3].Width = 65;

				dgvBorrowingRecords.Columns[4].HeaderText = "Due Date";
				dgvBorrowingRecords.Columns[4].Width = 65;

				dgvBorrowingRecords.Columns[5].HeaderText = "Return Date";
				dgvBorrowingRecords.Columns[5].Width = 65;

				dgvBorrowingRecords.Columns[6].HeaderText = "Borrow Status";
				dgvBorrowingRecords.Columns[6].Width = 70;

				dgvBorrowingRecords.Columns[7].HeaderText = "   Extension Count";
				dgvBorrowingRecords.Columns[7].Width = 80;
				dgvBorrowingRecords.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				dgvBorrowingRecords.Columns[8].HeaderText = "Notes";
				dgvBorrowingRecords.Columns[8].Width = 60;

				dgvBorrowingRecords.Columns[9].HeaderText = "Created By";
				dgvBorrowingRecords.Columns[9].Width = 85;

				dgvBorrowingRecords.Columns[10].HeaderText = "Modified By";
				dgvBorrowingRecords.Columns[10].Width = 55;

				dgvBorrowingRecords.Columns[11].HeaderText = "Modified Date";
				dgvBorrowingRecords.Columns[11].Width = 85;

			}
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{

			string FilterColumn = "";

			switch (cbFilter.Text)
			{
				case "None":
					FilterColumn = "None";
					break;
				case "Book Title":
					FilterColumn = "Title";
					break;

				case "Borrower's Name":
					FilterColumn = "FullName";
					break;

			}

			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtBorrowingRecords.DefaultView.RowFilter = "";
				lblRecords.Text = _dtBorrowingRecords.Rows.Count.ToString();
				return;
			}
			if (cbFilter.Text.Trim() == "Book Title" || cbFilter.Text.Trim() == "Borrower's Name")
				_dtBorrowingRecords.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
			lblRecords.Text = dgvBorrowingRecords.Rows.Count.ToString();

		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFilter.SelectedIndex == 0)
			{
				cbStatus.SelectedIndex = 0;
				txtFilter.Text = string.Empty;
				txtFilter.Visible = false;
				cbStatus.Visible = false;
				return;
			}
			if (cbFilter.Text == "Borrow Status")
			{
				txtFilter.Text = string.Empty;
				txtFilter.Visible = false;
				cbStatus.Visible = true;
			}
			else
			{
				txtFilter.Visible = true;
				cbStatus.Visible = false;
			}
		}

		private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
		{

			string FilterColumn = "BorrowStatus";
			string status = cbStatus.Text.Trim();

			if (!string.IsNullOrEmpty(status)&& status!="None")
			{
				_dtBorrowingRecords.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, status);
			}
			else
			{
				
				_dtBorrowingRecords.DefaultView.RowFilter = "";
				lblRecords.Text = _dtBorrowingRecords.Rows.Count.ToString();
				return;
				
			}
			lblRecords.Text = dgvBorrowingRecords.Rows.Count.ToString();
		}


		private void btnAddBorrowingRecord_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddBorrowRecord();
			frm.ShowDialog();
			_RefreshBorroingRecordsList();
		}

		private bool Extend_Borrow()
		{
			_BorrowingRecord = clsBorrowingRecord.Find((int)dgvBorrowingRecords.CurrentRow.Cells[0].Value);
			if (_BorrowingRecord.ExtensionCount >= clsGlobal.Settings.ExtendTimesPerBorrow)
			{
				MessageBox.Show("You have exceeded the allowed number of extensions for this borrowing.", "Extension Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			_BorrowingRecord.DueDate = _BorrowingRecord.DueDate.AddDays(clsGlobal.Settings.ExtendBorrowDays);
			_BorrowingRecord.ExtensionCount = 1;
			_BorrowingRecord.BorrowStatus = Convert.ToByte(clsBorrowingRecord.enStatus.Extended);
			_BorrowingRecord.LastModifiedByUserID = clsGlobal.CurrentUser.UserID;
			_BorrowingRecord.LastModifiedDate = DateTime.Now;
			return _BorrowingRecord.Save();
		}

		private void extendBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Extend_Borrow())
			{
				MessageBox.Show("The borrowing period has been extended successfully.", "Extension Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_RefreshBorroingRecordsList();
			}
			else
			{
				MessageBox.Show("Failed to extend the borrowing period.", "Extension Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void notesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmBorrowingRecordNotes((int)dgvBorrowingRecords.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshBorroingRecordsList();
		}

		private bool _EndBorrowingRecord(int RecordID)
		{
			_BorrowingRecord = clsBorrowingRecord.Find(RecordID);
			_BorrowingRecord.BorrowStatus = Convert.ToByte(clsBorrowingRecord.enStatus.Returned);
			_BorrowingRecord.ActualReturnDate= DateTime.Now;
			_BorrowingRecord.LastModifiedByUserID = clsGlobal.CurrentUser.UserID;
			_BorrowingRecord.LastModifiedDate = DateTime.Now;
			return _BorrowingRecord.Save();
		}

		private void endBorrowingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
			"Are you sure the borrowing process has been completed?",
			"Confirm Ending Borrowing",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				if(_EndBorrowingRecord((int)dgvBorrowingRecords.CurrentRow.Cells[0].Value))
					MessageBox.Show("The return process has been completed successfully.", "Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Failed to complete the return process.", "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				return;
			}
			_RefreshBorroingRecordsList();


		}

		private void cmsBorrowingRecords_Opening(object sender, CancelEventArgs e)
		{
			if (dgvBorrowingRecords.CurrentRow != null&&dgvBorrowingRecords.CurrentRow != null)
			{
				endBorrowingToolStripMenuItem.Enabled = true;
				extendBorrowingToolStripMenuItem.Enabled = true;
				lostToolStripMenuItem.Enabled = true;
				damagedToolStripMenuItem.Enabled = true;

				string status = dgvBorrowingRecords.CurrentRow.Cells["BorrowStatus"].Value.ToString();

				if (status == "Returned" || status == "Lost" || status == "Damaged")
				{
					endBorrowingToolStripMenuItem.Enabled = false;
					extendBorrowingToolStripMenuItem.Enabled = false;
					lostToolStripMenuItem.Enabled = false;
					damagedToolStripMenuItem.Enabled = false;
				}

				if (status == "Extended" &&
					(byte)dgvBorrowingRecords.CurrentRow.Cells[7].Value == clsGlobal.Settings.ExtendTimesPerBorrow)
				{
					extendBorrowingToolStripMenuItem.Enabled = false;
				}
			}
		}

		private bool _Lost(int RecordID)
		{
			_BorrowingRecord = clsBorrowingRecord.Find(RecordID);
			_BorrowingRecord.BorrowStatus = Convert.ToByte(clsBorrowingRecord.enStatus.Lost);
			_BorrowingRecord.LastModifiedByUserID = clsGlobal.CurrentUser.UserID;
			_BorrowingRecord.LastModifiedDate = DateTime.Now;
			return _BorrowingRecord.Save();

		}

		private bool _Damaged(int RecordID)
		{
			_BorrowingRecord = clsBorrowingRecord.Find(RecordID);
			_BorrowingRecord.BorrowStatus = Convert.ToByte(clsBorrowingRecord.enStatus.Damaged);
			_BorrowingRecord.ActualReturnDate = DateTime.Now;
			_BorrowingRecord.LastModifiedByUserID = clsGlobal.CurrentUser.UserID;
			_BorrowingRecord.LastModifiedDate = DateTime.Now;
			return _BorrowingRecord.Save();
		}

		private void damagedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_Damaged((int)dgvBorrowingRecords.CurrentRow.Cells[0].Value))
			{
				MessageBox.Show("The book was returned damaged.", "Damaged Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				_RefreshBorroingRecordsList();
			}
			else
			{
				MessageBox.Show("The information was not saved. An error has occurred.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void lostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_Lost((int)dgvBorrowingRecords.CurrentRow.Cells[0].Value))
			{
				MessageBox.Show("The book was lost.", "Lost Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_RefreshBorroingRecordsList();
			}
			else
			{
				MessageBox.Show("The information was not saved. An error has occurred.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}
	}
}
