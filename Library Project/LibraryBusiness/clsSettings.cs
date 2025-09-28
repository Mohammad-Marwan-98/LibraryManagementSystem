using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsSettings
	{
		public byte DefaultBorrowDays { get; set; }
		public byte DefaultFinePerDay { get; set; }
		public decimal OneMonthSubscriptionFee { get; set; }
		public decimal ThreeMonthSubscriptionFee { get; set; }
		public decimal YearlySubscriptionFee { get; set; }
		public decimal DamagedFine { get; set; }
		public decimal LostFine { get; set; }
		public byte ExtendBorrowDays { get; set; }
		public byte ExtendTimesPerBorrow { get; set; }

		private clsSettings(byte defaultborrowdays, byte defaultfineperday, decimal onemonthsubscriptionfee, decimal threemonthsubscriptionfee, decimal yearlysubscriptionfee,decimal damagedfine,decimal lostfine, byte extendborrowdays, byte extendtimesperborrow)
		{
			this.DefaultBorrowDays = defaultborrowdays;
			this.DefaultFinePerDay = defaultfineperday;
			this.OneMonthSubscriptionFee = onemonthsubscriptionfee;
			this.ThreeMonthSubscriptionFee = threemonthsubscriptionfee;
			this.YearlySubscriptionFee = yearlysubscriptionfee;
			this.ExtendBorrowDays = extendborrowdays;
			this.ExtendTimesPerBorrow = extendtimesperborrow;
			this.DamagedFine = damagedfine;
			this.LostFine = lostfine;


		}

		public static clsSettings GetSettings()
		{
			
			byte defaultBorrowDays = 0;
			byte defaultFinePerDay = 0;
			decimal oneMonthSubscriptionFee = 0;
			decimal threeMonthSubscriptionFee = 0;
			decimal yearlySubscriptionFee = 0;
			decimal damagedfine = 0;
			decimal lostfine = 0;
			byte extendBorrowDays = 0;
			byte extendTimesPerBorrow = 0;

			clsSettingsData.GetSettings(
				ref defaultBorrowDays,
				ref defaultFinePerDay,
				ref oneMonthSubscriptionFee,
				ref threeMonthSubscriptionFee,
				ref yearlySubscriptionFee,
				ref damagedfine,
				ref lostfine,
				ref extendBorrowDays,
				ref extendTimesPerBorrow
			);

			return new clsSettings(defaultBorrowDays,defaultFinePerDay,oneMonthSubscriptionFee, threeMonthSubscriptionFee,
				yearlySubscriptionFee,damagedfine,lostfine, extendBorrowDays,extendTimesPerBorrow );
		}

		private bool _UpdateSettings()
		{
			return clsSettingsData.UpdateSettings(this.DefaultBorrowDays,this.DefaultFinePerDay,
				this.OneMonthSubscriptionFee, this.ThreeMonthSubscriptionFee,this.YearlySubscriptionFee,
				this.DamagedFine,this.LostFine,
				this.ExtendBorrowDays,this.ExtendTimesPerBorrow );
		}

		public bool Save()
		{
			return _UpdateSettings();
		}

	}
}
