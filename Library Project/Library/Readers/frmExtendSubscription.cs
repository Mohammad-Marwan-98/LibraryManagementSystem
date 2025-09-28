using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class frmExtendSubscription : Form
	{
		private int _ReaderID;
		private byte _Period;
		private clsReader _Reader=new clsReader();
		public frmExtendSubscription(int ReaderID)
		{
			InitializeComponent();
			_ReaderID = ReaderID;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			switch (cbSubscriptionPeriod.Text)
			{
				case "1-Month Subscription":
					_Period = 1;
					break;
				case "3-Month Subscription":
					_Period = 3;
					break;
				case "1-Year Subscription":
					_Period = 12;
					break;
			}
			DialogResult result = MessageBox.Show($"Are you sure you want to extend the subscription for the reader with ID = {_ReaderID} and Library Card Number = {_Reader.LibraryCardNumber}?",
												 "Confirm Subscription Extension",
												 MessageBoxButtons.YesNo,
												 MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				if (clsReader.ExtendSubscription(_ReaderID, _Period))
					MessageBox.Show("Subscription extended successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show("Failed to extend the subscription.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void frmExtendSubscription_Load(object sender, EventArgs e)
		{
			_Reader = clsReader.Find(_ReaderID);
		}
	}
}
