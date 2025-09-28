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
	public partial class frmListReaders : Form
	{
		private DataTable _dtReaders;
		
		public frmListReaders()
		{
			InitializeComponent();
		}

		private void _AdjustDgvSize()
		{
			int mergin = 50;
			dgvReaders.Left = mergin;
			dgvReaders.Width = this.ClientSize.Width - (mergin * 2);

		}
		private void _RefreshReadersList()
		{
			_dtReaders = clsReader.GetAllReaders();
			dgvReaders.DataSource = _dtReaders;
			lblRecords.Text=dgvReaders.Rows.Count.ToString();
		}
		private void frmListReaders_Load(object sender, EventArgs e)
		{
			_AdjustDgvSize();
			_RefreshReadersList();

			dgvReaders.Columns[0].HeaderText = "Reader ID";
			dgvReaders.Columns[0].Width = 60;

			dgvReaders.Columns[1].HeaderText = "Full Name";
			dgvReaders.Columns[1].Width = 150;

			dgvReaders.Columns[2].HeaderText = "Address";
			dgvReaders.Columns[2].Width = 100;

			dgvReaders.Columns[3].HeaderText = "Library Card";
			dgvReaders.Columns[3].Width = 100;

			dgvReaders.Columns[4].HeaderText = "Subscription Status";
			dgvReaders.Columns[4].Width = 100;

			dgvReaders.Columns[5].HeaderText = "Join Date";
			dgvReaders.Columns[5].Width = 80;

			dgvReaders.Columns[6].HeaderText = "Expiration Date";
			dgvReaders.Columns[6].Width = 80;

			dgvReaders.Columns[7].HeaderText = "Is Active";
			dgvReaders.Columns[7].Width = 40;
			dgvReaders.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


			dgvReaders.Columns[8].HeaderText = "Notes";
			dgvReaders.Columns[8].Width = 170;

		

		}

		private void btnAddReader_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateReader();
			frm.ShowDialog();
			_RefreshReadersList();

		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateReader((int)dgvReaders.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshReadersList();

		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmShowReaderDetails((int)dgvReaders.CurrentRow.Cells[0].Value);
			frm.ShowDialog();

		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete Reader [" + dgvReaders.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (clsReader.DeleteReader((int)dgvReaders.CurrentRow.Cells[0].Value))
				{
					MessageBox.Show("Reader Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_RefreshReadersList();
				}
				else
				{
					MessageBox.Show("Book was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string FilterColumn = "";

			switch (cbFilter.Text)
			{
				case "Reader ID":
					FilterColumn = "ReaderID";
					break;


				case "Library Card":
					FilterColumn = "LibraryCardNumber";
					break;

				case "Full Name":
					FilterColumn = "FullName";
					break;

				
			}

			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtReaders.DefaultView.RowFilter = "";
				lblRecords.Text = _dtReaders.Rows.Count.ToString();
				return;
			}

			if (FilterColumn == "ReaderID")
			{
				_dtReaders.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
			}

			else
			{
				_dtReaders.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
			}
			lblRecords.Text = dgvReaders.Rows.Count.ToString();


		}

		private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtFilter.Visible = (cbFilter.Text != "None");
			if (txtFilter.Visible)
			{
				txtFilter.Text = "";
				txtFilter.Focus();
			}
			else
			{
				txtFilter.Text = "";
			}
		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilter.Text == "Reader ID"||cbFilter.Text=="Library Card")
			{
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}

			}
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateReader();
			frm.ShowDialog();
			_RefreshReadersList();
		}

		

		private void extendSubscriptionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmExtendSubscription((int)dgvReaders.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshReadersList();
		}
	}
}
