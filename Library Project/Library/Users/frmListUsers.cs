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
	public partial class frmListUsers : Form
	{
		private DataTable _dtUsers;
		public frmListUsers()
		{
			InitializeComponent();
		}

		private void _AdjustDgvSize()
		{
			int mergin = 50;
			dgvUsers.Left = mergin;
			dgvUsers.Width = this.ClientSize.Width - (mergin * 2);

		}
		private void _RefreshUsersList()
		{
			_dtUsers = clsUser.GetAllUsers();
			dgvUsers.DataSource = _dtUsers;
			lblRecords.Text = dgvUsers.Rows.Count.ToString();
		}

		private void frmListUsers_Load(object sender, EventArgs e)
		{
			_AdjustDgvSize();
			_RefreshUsersList();
			if (_dtUsers.Rows.Count>0)
			{
				dgvUsers.Columns[0].HeaderText = "User ID";
				dgvUsers.Columns[0].Width = 60;

				dgvUsers.Columns[1].HeaderText = "Username";
				dgvUsers.Columns[1].Width = 60;

				dgvUsers.Columns[2].HeaderText = "Full Name";
				dgvUsers.Columns[2].Width = 150;

				dgvUsers.Columns[3].HeaderText = "Age";
				dgvUsers.Columns[3].Width = 100;

				dgvUsers.Columns[4].HeaderText = "Address";
				dgvUsers.Columns[4].Width = 100;

				dgvUsers.Columns[5].HeaderText = "Gender";
				dgvUsers.Columns[5].Width = 90;

				dgvUsers.Columns[6].HeaderText = "Email";
				dgvUsers.Columns[6].Width = 100;

				dgvUsers.Columns[7].HeaderText = "Mobile Number";
				dgvUsers.Columns[7].Width = 90;

				dgvUsers.Columns[8].HeaderText = "Is Active";
				dgvUsers.Columns[8].Width = 60;
				dgvUsers.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}

			

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

		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string FilterColumn = "";

			switch (cbFilter.Text)
			{
				case "User ID":
					FilterColumn = "UseID";
					break;

				case "Full Name":
					FilterColumn = "FullName";
					break;

				case "Username":
					FilterColumn = "Username";
					break;

			}

			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtUsers.DefaultView.RowFilter = "";
				lblRecords.Text = _dtUsers.Rows.Count.ToString();
				return;
			}

			if (FilterColumn == "UserID")
			{
				_dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
			}

			else
			{
				_dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
			}
			lblRecords.Text = dgvUsers.Rows.Count.ToString();


		}
		

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilter.Text == "UserID")
			{
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}

			}
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateUser();
			frm.ShowDialog();
			_RefreshUsersList();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateUser();
			frm.ShowDialog();
			_RefreshUsersList();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshUsersList();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete User [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
				{
					MessageBox.Show("Reader Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_RefreshUsersList();
				}
				else
				{
					MessageBox.Show("Book was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmShowUserDetails((int)dgvUsers.CurrentRow.Cells[0].Value);
			frm.ShowDialog(this);
		}
	}
}
