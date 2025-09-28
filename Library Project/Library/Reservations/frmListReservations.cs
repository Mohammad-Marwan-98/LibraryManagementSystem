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
	public partial class frmListReservations : Form
	{
		private DataTable _dtReservations;
		private clsReservation _Reservation = new clsReservation();
		public frmListReservations()
		{
			InitializeComponent();
		}

		private void _AdjustDgvSize()
		{
			int mergin = 50;
			dgvReservations.Left = mergin;
			dgvReservations.Width = this.ClientSize.Width - (mergin * 2);

		}

		private void _RefreshReservationsList()
		{
			_dtReservations = clsReservation.GetAllReservations();
			dgvReservations.DataSource = _dtReservations;
			lblRecords.Text = dgvReservations.Rows.Count.ToString();
		}

		private void frmListReservations_Load(object sender, EventArgs e)
		{
			_RefreshReservationsList();
			_AdjustDgvSize();
			dgvReservations.DataSource = _dtReservations;

			if (dgvReservations.Rows.Count > 0)
			{
				dgvReservations.Columns[0].HeaderText = "Reservation ID";
				dgvReservations.Columns[0].Width = 100;

				dgvReservations.Columns[1].HeaderText = "Full Name";
				dgvReservations.Columns[1].Width = 130;

				dgvReservations.Columns[2].HeaderText = "Book Title";
				dgvReservations.Columns[2].Width = 100;

				dgvReservations.Columns[3].HeaderText = "Reader ID";
				dgvReservations.Columns[3].Width = 100;

				dgvReservations.Columns[4].HeaderText = "ReservationDate";
				dgvReservations.Columns[4].Width = 100;

				dgvReservations.Columns[5].HeaderText = "Created By";
				dgvReservations.Columns[5].Width = 100;

				dgvReservations.Columns[6].HeaderText = "Is Active";
				dgvReservations.Columns[6].Width = 100;

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

				case "Full Name":
					FilterColumn = "FullName";
					break;

				case "Username":
					FilterColumn = "CreatedBy";
					break;

				case "Book Title":
					FilterColumn = "Title";
					break;

			}

			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtReservations.DefaultView.RowFilter = "";
				lblRecords.Text = _dtReservations.Rows.Count.ToString();
				return;
			}
			if (cbFilter.Text.Trim() == "Username" || cbFilter.Text.Trim() == "Full Name" || cbFilter.Text.Trim()=="Book Title")
				_dtReservations.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
			lblRecords.Text = dgvReservations.Rows.Count.ToString();

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
			if (cbFilter.Text == "Status")
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

		private void btnAddReservation_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddReservation();
			frm.ShowDialog();
			_RefreshReservationsList();
		}

		private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddReservation();
			frm.ShowDialog();
			_RefreshReservationsList();
		}

		private void notifyReaderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_Reservation = clsReservation.Find( Convert.ToInt32(dgvReservations.CurrentRow.Cells[0].Value));
			int BookID = _Reservation.BookID;
			if (clsReservation.NotifyFirstReservation(BookID))
			{
				MessageBox.Show("Notification sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Notification could not be sent. There might be no available copies at the moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			_RefreshReservationsList();
		}

		private void cmsReservations_Opening(object sender, CancelEventArgs e)
		{
			notifyReaderToolStripMenuItem.Enabled = true;
			notifyReaderToolStripMenuItem.Enabled = Convert.ToBoolean(dgvReservations.CurrentRow.Cells[6].Value);
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			int ReservationID = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationID"].Value);

			DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				if (clsReservation.DeleteReservation(ReservationID))
				{
					MessageBox.Show("Reservation deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_RefreshReservationsList();
				}
				else
				{
					MessageBox.Show("Failed to delete reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			string FilterColumn = "IsActive";
			string filterValue = "";

			if (cbStatus.Text == "Active")
				filterValue = "True";
			else if (cbStatus.Text == "InActive")
				filterValue = "False";
			else
				filterValue = "";

			if (filterValue == "")
				_dtReservations.DefaultView.RowFilter = "";
			else
				_dtReservations.DefaultView.RowFilter =
					string.Format("[{0}] = {1}", FilterColumn, filterValue);

		}

	}
}
