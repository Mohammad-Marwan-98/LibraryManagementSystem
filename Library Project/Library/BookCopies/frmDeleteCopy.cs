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
	public partial class frmDeleteCopy : Form
	{
		private int _BookID;
		private DataTable _dtCopies;
		public frmDeleteCopy()
		{
			InitializeComponent();
		}

		private void frmDeleteCopy_Load(object sender, EventArgs e)
		{
			ctrlFindBook1.OnBookSelected += OnBookSelected;
		}

		private void _RefreshcbCopies()
		{
			cbCopies.Items.Clear();
			_dtCopies = clsBookCopy.GetAllCopies(_BookID);
			foreach (DataRow row in _dtCopies.Rows)
			{
				cbCopies.Items.Add(row["CopyID"].ToString());
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(clsBookCopy.DeleteCopy(Convert.ToInt32(cbCopies.Text), ctrlFindBook1.BookID))
			{
				MessageBox.Show("Copy " + cbCopies.Text+ " deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ctrlFindBook1.RefreshData();
				_RefreshcbCopies();

			}
		}

		

		private void txtCopyID_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void OnBookSelected(int bookID)
		{
			_BookID=bookID;
			
			_RefreshcbCopies();

		}

		private void ctrlFindBook1_Load(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
