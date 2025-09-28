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

namespace Library.Books
{
	public partial class ctrlFindBook : UserControl
	{
		public event Action<int> OnBookSelected;
		public int BookID;
		public ctrlFindBook()
		{
			InitializeComponent();
		}

		private void txtBookId_Validating(object sender, CancelEventArgs e)
		{
			if(string.IsNullOrEmpty(txtBookId.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(txtBookId, "This Field Is Required");
			}
			else
			{
				errorProvider1.SetError(txtBookId, null);
			}
		}

		private void txtBookId_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		public void RefreshData()
		{
			BookID = Convert.ToInt32(txtBookId.Text);
			ctrlBookDetails1.LoadInfo(Convert.ToInt32(txtBookId.Text));
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			BookID = Convert.ToInt32(txtBookId.Text);
			ctrlBookDetails1.LoadInfo(Convert.ToInt32(txtBookId.Text));
			OnBookSelected?.Invoke(BookID);
		}
	}
}
