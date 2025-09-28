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
	public partial class frmShowBookDetails : Form
	{
		public frmShowBookDetails(int bookID)
		{
			InitializeComponent();
			ctrlBookDetails1.LoadInfo(bookID);
		}


		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmShowBookDetails_Load(object sender, EventArgs e)
		{
			this.ActiveControl = btnClose;
		}
	}
}
