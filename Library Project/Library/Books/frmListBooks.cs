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
	public partial class frmListBooks : Form
	{
		private DataTable _dtBooks;
		public frmListBooks()
		{
			InitializeComponent();
		}
		private void _AdjustDgvSize()
		{
			int mergin = 50;
			dgvBooks.Left = mergin;
			dgvBooks.Width = this.ClientSize.Width - (mergin * 2);

		}
		private void frmListBooks_Load(object sender, EventArgs e)
		{
			_RefreshBooksList();
			_AdjustDgvSize();
			dgvBooks.DataSource = _dtBooks;

			if (dgvBooks.Rows.Count > 0)
			{
				dgvBooks.Columns[0].HeaderText = "Book ID";
				dgvBooks.Columns[0].Width = 60;

				dgvBooks.Columns[1].Width = 100;
				dgvBooks.Columns[2].Width = 100;
				dgvBooks.Columns[3].Width = 100;

				dgvBooks.Columns[4].HeaderText = "Publication Date";
				dgvBooks.Columns[4].Width = 100;

				dgvBooks.Columns[5].Width = 100;
				dgvBooks.Columns[6].Width = 70;


				dgvBooks.Columns[7].Width = 200;

				dgvBooks.Columns[8].HeaderText = "Additional Details";
				dgvBooks.Columns[8].Width = 200;

				dgvBooks.Columns[9].HeaderText = "Number Of Copies";
				dgvBooks.Columns[9].Width = 85;
				dgvBooks.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


				dgvBooks.Columns[10].HeaderText = "Is Available";
				dgvBooks.Columns[10].Width = 70;




			}

		}

		private void _RefreshBooksList()
		{
			_dtBooks = clsBook.GetAllBooks();
			dgvBooks.DataSource = _dtBooks;
			lblRecords.Text = dgvBooks.Rows.Count.ToString();
		}


		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			string FilterColumn = "";

			switch (cbFilter.Text)
			{
				case "Book ID":
					FilterColumn = "BookID";
					break;

				case "Book Title":
					FilterColumn = "Title";
					break;

				case "ISBN":
					FilterColumn = "ISBN";
					break;

				case "Genre":
					FilterColumn = "Genre";
					break;

				case "Language":
					FilterColumn = "Language";
					break;

				case "Author":
					FilterColumn = "Author";
					break;
			}

			if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtBooks.DefaultView.RowFilter = "";
				lblRecords.Text = _dtBooks.Rows.Count.ToString();
				return;
			}

			if (FilterColumn == "BookID")
			{
				_dtBooks.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
			}

			else
			{
				_dtBooks.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
			}
			lblRecords.Text = dgvBooks.Rows.Count.ToString();


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

		private void btnAddBook_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateBook();
			frm.ShowDialog();
			_RefreshBooksList();
		}

		private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateBook();
			frm.ShowDialog();
			_RefreshBooksList();
		}

		private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form frm = new frmAddUpdateBook((int)dgvBooks.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
			_RefreshBooksList();

		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete Book [" + dgvBooks.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (clsBook.DeleteBook((int)dgvBooks.CurrentRow.Cells[0].Value))
				{
					MessageBox.Show("Book Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_RefreshBooksList();
				}
				else
				{
					MessageBox.Show("Book was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Form frm = new frmShowBookDetails((int)dgvBooks.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
		}

		private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilter.Text == "Book ID"||cbFilter.Text=="ISBN")
			{
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}

			}
		}
	}
}
