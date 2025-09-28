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
	public partial class frmListFines : Form
	{
		private clsFine _Fine = new clsFine();
		private DataTable _dtFines;
		public frmListFines()
		{
			InitializeComponent();
		}

		private void _AdjustDgvSize()
		{
			int mergin = 50;
			dgvFines.Left = mergin;
			dgvFines.Width = this.ClientSize.Width - (mergin * 2);

		}
		private void _RefreshFinesList()
		{
			_dtFines = clsFine.GetAllFines();
			dgvFines.DataSource = _dtFines;
			lblRecords.Text = dgvFines.Rows.Count.ToString();
		}

		private void frmListFines_Load(object sender, EventArgs e)
		{
			_AdjustDgvSize();
			_RefreshFinesList();
			
			dgvFines.Columns[0].HeaderText = "Fine ID";
			dgvFines.Columns[0].Width = 60;

			dgvFines.Columns[1].HeaderText = "Full Name";
			dgvFines.Columns[1].Width = 150;

			dgvFines.Columns[2].HeaderText = "Borrowing Record ID";
			dgvFines.Columns[2].Width = 100;

			dgvFines.Columns[3].HeaderText = "Fine Reason";
			dgvFines.Columns[3].Width = 100;

			dgvFines.Columns[4].HeaderText = "Late Days";
			dgvFines.Columns[4].Width = 100;

			dgvFines.Columns[5].HeaderText = "Fine Amount";
			dgvFines.Columns[5].Width = 80;

			dgvFines.Columns[6].HeaderText = "Payment Status";
			dgvFines.Columns[6].Width = 60;

			dgvFines.Columns[7].HeaderText = "Created Date";
			dgvFines.Columns[7].Width = 60;
			dgvFines.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


			dgvFines.Columns[8].HeaderText = "Created By";
			dgvFines.Columns[8].Width = 170;
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string FilterColumn = "";

			switch (cbFilter.Text)
			{
				case "Full Name":
					FilterColumn = "FullName";
					break;


				case "Borrowing Record ID":
					FilterColumn = "BorrowingRecordID";
					break;
			}

			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtFines.DefaultView.RowFilter = "";
				lblRecords.Text = _dtFines.Rows.Count.ToString();
				return;
			}

			if (FilterColumn == "ReaderID")
			{
				_dtFines.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
			}
			else
			{
				_dtFines.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
			}
		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilter.Text == "Borrowing Record ID")
			{
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}

			}
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
			if (cbFilter.Text == "Payment Status")
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
			string FilterColumn = "PaymentStatus";
			string status = cbStatus.Text.Trim();

			if (!string.IsNullOrEmpty(status) && status != "None")
			{
				_dtFines.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, status);
			}
			else
			{

				_dtFines.DefaultView.RowFilter = "";
				lblRecords.Text = _dtFines.Rows.Count.ToString();
				return;

			}
			lblRecords.Text = dgvFines.Rows.Count.ToString();
		}

		private bool _PayFine(int FineID)
		{
			_Fine = clsFine.Find(FineID);
			_Fine.PaymentStatus = true;
			return _Fine.Save();
		}

		private void payFineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_PayFine((int)dgvFines.CurrentRow.Cells[0].Value))
			{
				MessageBox.Show("Payment processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_RefreshFinesList();
			}
			else
			{
				MessageBox.Show("Payment failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmsFines_Opening(object sender, CancelEventArgs e)
		{
			if (dgvFines.Rows.Count > 0 && dgvFines.CurrentRow != null)
			{
				string status = dgvFines.CurrentRow.Cells["PaymentStatus"].Value.ToString();
				payFineToolStripMenuItem.Enabled = (status != "Paid");
			}
			else
			{
				payFineToolStripMenuItem.Enabled = false;
			}
		}

	}
}
