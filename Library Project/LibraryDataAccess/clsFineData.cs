using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsFineData
	{
		public static DataTable GetAllFines()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllFines", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
							{
								dt.Load(reader);
							}
						}
					}
				}
			}
			catch (Exception ex) { }
			return dt;
		}


		/// <summary>
		/// Retrieves a specific record from the <c>Fines</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindFine(int FineID, ref int ReaderID, ref int BorrowingRecordID, ref byte FineReason, ref byte NumberOfLateDays, ref decimal FineAmount, ref bool PaymentStatus, ref DateTime CreatedDate, ref int CreatedByUserID)
		{
			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindFine", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@FineID", FineID);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;
								ReaderID = (int)reader["ReaderID"];
								BorrowingRecordID = (int)reader["BorrowingRecordID"];
								FineReason = (byte)reader["FineReason"];
								if (reader["NumberOfLateDays"] != DBNull.Value)
								{
									NumberOfLateDays = (byte)reader["NumberOfLateDays"];
								}
								else
								{
									NumberOfLateDays = default;
								}
								FineAmount = (decimal)reader["FineAmount"];
								PaymentStatus = (bool)reader["PaymentStatus"];
								CreatedDate = (DateTime)reader["CreatedDate"];
								CreatedByUserID = (int)reader["CreatedByUserID"];

							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				IsFound = false;
			}
			return IsFound;
		}



		/// <summary>
		/// Inserts a new record into the <c>Fines</c> table.
		/// </summary>
		/// <returns>The ID of the inserted record, or -1 if the insert failed.</returns>

		public static int AddNewFine(int ReaderID, int BorrowingRecordID, byte FineReason, byte NumberOfLateDays, decimal FineAmount, int CreatedByUserID)
		{
			int FineID = -1;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{

					using (SqlCommand command = new SqlCommand("SP_AddFine", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						connection.Open();
						command.Parameters.AddWithValue("@ReaderID", ReaderID);
						command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
						command.Parameters.AddWithValue("@FineReason", FineReason);
						if (NumberOfLateDays != -1)
						{
							command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
						}
						else
						{
							command.Parameters.AddWithValue("@NumberOfLateDays", System.DBNull.Value);
						}
						command.Parameters.AddWithValue("@FineAmount", FineAmount);
						command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

						SqlParameter outputparam = new SqlParameter("FineID", SqlDbType.Int)
						{
							Direction = ParameterDirection.Output
						};
						command.Parameters.Add(outputparam);
						command.ExecuteNonQuery();
						FineID = Convert.ToInt32(outputparam.Value);


					}
				}
			}
			catch (Exception ex) { }
			return FineID;
		}


		/// <summary>
		/// Updates a record in the <c>Fines</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was updated; otherwise, <c>false</c>.</returns>

		public static bool UpdateFine(int FineID, bool PaymentStatus)
		{
			int RowsAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_UpdateFine", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@FineID", FineID);
						command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);

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
