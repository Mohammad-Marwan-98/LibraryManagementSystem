using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsSettingsData
	{
		public static void GetSettings(
	ref byte DefaultBorrowDays,
	ref byte DefaultFinePerDay,
	ref decimal OneMonthSubscriptionFee,
	ref decimal ThreeMonthSubscriptionFee,
	ref decimal YearlySubscriptionFee,
	ref decimal DamagedFine,
	ref decimal LostFine,
	ref byte ExtendBorrowDays,
	ref byte ExtendTimesPerBorrow)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetSettings", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						connection.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read()) 
							{
								DefaultBorrowDays = Convert.ToByte(reader["DefaultBorrowDays"]);
								DefaultFinePerDay = Convert.ToByte(reader["DefaultFinePerDay"]);
								OneMonthSubscriptionFee = Convert.ToDecimal(reader["OneMonthSubscriptionFee"]);
								ThreeMonthSubscriptionFee = Convert.ToDecimal(reader["ThreeMonthSubscriptionFee"]);
								YearlySubscriptionFee = Convert.ToDecimal(reader["YearlySubscriptionFee"]);
								DamagedFine= Convert.ToDecimal(reader["DamagedBookFineAmount"]);
								LostFine= Convert.ToDecimal(reader["LostBookFineAmount"]);
								ExtendBorrowDays = Convert.ToByte(reader["ExtendBorrowDays"]);
								ExtendTimesPerBorrow = Convert.ToByte(reader["ExtendTimesPerBorrow"]);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				
			}
		}


		public static bool UpdateSettings(byte DefaultBorrowDays, byte DefaultFinePerDay, decimal OneMonthSubscriptionFee, decimal ThreeMonthSubscriptionFee, decimal YearlySubscriptionFee,decimal DamagedFine,decimal LostFine, byte ExtendBorrowDays, byte ExtendTimesPerBorrow)
		{
			int RowsAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
				
					using (SqlCommand command = new SqlCommand("SP_UpdateSettings" , connection))
					{
						command.CommandType=CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@DefaultBorrowDays", DefaultBorrowDays);
						command.Parameters.AddWithValue("@DefaultFinePerDay", DefaultFinePerDay);
						command.Parameters.AddWithValue("@OneMonthSubscriptionFee", OneMonthSubscriptionFee);
						command.Parameters.AddWithValue("@ThreeMonthSubscriptionFee", ThreeMonthSubscriptionFee);
						command.Parameters.AddWithValue("@YearlySubscriptionFee", YearlySubscriptionFee);
						command.Parameters.AddWithValue("@DamagedFine", DamagedFine);
						command.Parameters.AddWithValue("@LostFine", LostFine);
						command.Parameters.AddWithValue("@ExtendBorrowDays", ExtendBorrowDays);
						command.Parameters.AddWithValue("@ExtendTimesPerBorrow", ExtendTimesPerBorrow);

						connection.Open();
						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex) { return false; }
			return RowsAffected > 0;
		}
	}
}
