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
	
	public partial class frmShowReaderDetails : Form
	{

		private int _ReaderID;
		private clsReader _Reader= new clsReader();

		public frmShowReaderDetails(int ReaderID)
		{
			InitializeComponent();
			_ReaderID = ReaderID;
		}

		private void _ResetValues()
		{
			ctrlPersonDetails1.ResetValues();
			lblReaderID.Text = "??";
			lblLibraryCard.Text = "??";
			cbSubscriptionStatus.SelectedIndex = -1;
			txtNotes.Text = string.Empty;
			dtpExpirtyDate.Value= DateTime.Now;
			dtpJoinDate.Value= DateTime.Now;
			cbSubscriptionStatus.Enabled = false;
			dtpExpirtyDate.Enabled= false;
			dtpJoinDate.Enabled= false;
			chkIsActive.Enabled = false;
			txtNotes.Enabled = false;

		}

		private void _LoadData()
		{

			_Reader = clsReader.Find(_ReaderID);
			ctrlPersonDetails1.LoadData(_Reader.PersonID);
			lblReaderID.Text=_ReaderID.ToString();
			lblLibraryCard.Text=_Reader.LibraryCardNumber.ToString();
			dtpExpirtyDate.Value = _Reader.SubscriptionExpiryDate;
			dtpJoinDate.Value = _Reader.JoinDate;
			txtNotes.Text=_Reader.Notes;
			chkIsActive.Checked = _Reader.IsActive;
			switch (_Reader.SubscriptionStatus)
			{
				case 1:
					cbSubscriptionStatus.SelectedIndex=0; 
					break;
				case 2:
					cbSubscriptionStatus.SelectedIndex=1;
					break;
				case 3:
					cbSubscriptionStatus.SelectedIndex=2;
					break;
				case 4:
					cbSubscriptionStatus.SelectedIndex=3;
					break;


			}
			cbSubscriptionStatus.Enabled= false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmShowReaderDetails_Load(object sender, EventArgs e)
		{
			_ResetValues();
			_LoadData();
		}
	}
}
