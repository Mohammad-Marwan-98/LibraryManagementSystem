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
	public partial class frmSettings : Form
	{

		clsSettings settings;

		public frmSettings()
		{
			InitializeComponent();
		}

		private void _LoadSettingInfo()
		{
			nudOneMonthSubscription.Value = settings.OneMonthSubscriptionFee;
			nudThreeMonthSubscription.Value = settings.ThreeMonthSubscriptionFee;
			nudOneYearSubscription.Value = settings.YearlySubscriptionFee;
			nudDefaultBorrowDays.Value = settings.DefaultBorrowDays;
			nudExtendBorrowDays.Value = settings.ExtendBorrowDays;
			nudExtendTimesPerBorrow.Value = settings.ExtendTimesPerBorrow;
			nudLateReturnFinesAmount.Value = settings.DefaultFinePerDay;
			nudDamagedFine.Value = settings.DamagedFine;
			nudLostFine.Value= settings.LostFine;
		}

		private void frmSettings_Load(object sender, EventArgs e)
		{
			settings = clsSettings.GetSettings();
			_LoadSettingInfo();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void _FillSettings()
		{
			settings.OneMonthSubscriptionFee = nudOneMonthSubscription.Value;
			settings.ThreeMonthSubscriptionFee = nudThreeMonthSubscription.Value;
			settings.YearlySubscriptionFee = nudOneYearSubscription.Value;
			settings.DefaultBorrowDays = Convert.ToByte(nudDefaultBorrowDays.Value);
			settings.DefaultFinePerDay = Convert.ToByte(nudLateReturnFinesAmount.Value);
			settings.ExtendBorrowDays = Convert.ToByte(nudExtendBorrowDays.Value);
			settings.ExtendTimesPerBorrow = Convert.ToByte(nudExtendTimesPerBorrow.Value);
			settings.DamagedFine = Convert.ToByte(nudDamagedFine.Value);
			settings.LostFine = Convert.ToByte(nudLostFine.Value);

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_FillSettings();
			if (settings.Save())
			{
				MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				clsGlobal.Settings=clsSettings.GetSettings();
			}
			else
			{
				MessageBox.Show("Failed to save settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
