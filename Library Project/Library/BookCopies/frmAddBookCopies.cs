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
	public partial class frmAddBookCopies : Form
	{
		public frmAddBookCopies()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			
			if(clsBookCopy.AddCopies(ctrlFindBook1.BookID, Convert.ToInt32(nudCopies.Value)))
			{
				MessageBox.Show("Copies added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ctrlFindBook1.RefreshData();
			}
			else
			{
				MessageBox.Show("Failed to add copies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmAddBookCopies_Load(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
