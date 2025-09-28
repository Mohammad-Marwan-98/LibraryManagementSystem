using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsBorrowingRecordData
	{
		/// <summary>
		/// Retrieves all rows from the <c>BorrowingRecords</c> table.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all records from the table.</returns>

		public static DataTable GetAllBorrowingRecords()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllBorrowingRecords", connection))
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
		/// Retrieves a specific record from the <c>BorrowingRecords</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindBorrowingRecord(int BorrowingRecordID, ref int ReaderID, ref int CopyID,
			ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate,
			ref byte BorrowStatus, ref byte ExtensionCount, ref string Notes, ref int CreatedByUserID,
			ref int LastModifiedByUserID, ref DateTime LastModifiedDate)
		{
			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindBorrowingRecordByID", connection))
					{
						command.CommandType= CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;
								ReaderID = (int)reader["ReaderID"];
								CopyID = (int)reader["CopyID"];
								BorrowingDate = (DateTime)reader["BorrowingDate"];
								DueDate = (DateTime)reader["DueDate"];
								if (reader["ActualReturnDate"] != DBNull.Value)
								{
									ActualReturnDate = (DateTime)reader["ActualReturnDate"];
								}
								else
								{
									ActualReturnDate = default;
								}
								BorrowStatus = (byte)reader["BorrowStatus"];
								ExtensionCount = (byte)reader["ExtensionCount"];
								if (reader["Notes"] != DBNull.Value)
								{
									Notes = (string)reader["Notes"];
								}
								else
								{
									Notes = default;
								}
								CreatedByUserID = (int)reader["CreatedByUserID"];
								if (reader["LastModifiedByUserID"] != DBNull.Value)
								{
									LastModifiedByUserID = (int)reader["LastModifiedByUserID"];
								}
								else
								{
									LastModifiedByUserID = -1;
								}
								if (reader["LastModifiedDate"] != DBNull.Value)
								{
									LastModifiedDate = (DateTime)reader["LastModifiedDate"];
								}
								else
								{
									LastModifiedDate = default;
								}
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
		/// Inserts a new record into the <c>BorrowingRecords</c> table.
		/// </summary>
		/// <returns>The ID of the inserted record, or -1 if the insert failed.</returns>

		public static int AddNewBorrowingRecord(int ReaderID, int CopyID, DateTime BorrowingDate, DateTime DueDate,
			DateTime ActualReturnDate, byte BorrowStatus, string Notes,
			int CreatedByUserID)
		{
			int BorrowingRecordID = -1;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					
					using (SqlCommand command = new SqlCommand("SP_AddBorrowingRecord", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						connection.Open();
						command.Parameters.AddWithValue("@ReaderID", ReaderID);
						command.Parameters.AddWithValue("@CopyID", CopyID);
						command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
						command.Parameters.AddWithValue("@DueDate", DueDate);
						if (ActualReturnDate != DateTime.MinValue)
						{
							command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
						}
						else
						{
							command.Parameters.AddWithValue("@ActualReturnDate", System.DBNull.Value);
						}
						command.Parameters.AddWithValue("@BorrowStatus", BorrowStatus);
						if (!string.IsNullOrEmpty(Notes))
						{
							command.Parameters.AddWithValue("@Notes", Notes);
						}
						else
						{
							command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
						}
						command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

						SqlParameter outputparam = new SqlParameter("@BorrowingRecordID", SqlDbType.Int)
						{
							Direction = ParameterDirection.Output
						};
						command.Parameters.Add(outputparam);
						command.ExecuteNonQuery();
						BorrowingRecordID = Convert.ToInt32(outputparam.Value);
					}
				}
			}
			catch (Exception ex) { }
			return BorrowingRecordID;
		}


		/// <summary>
		/// Updates a record in the <c>BorrowingRecords</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was updated; otherwise, <c>false</c>.</returns>

		public static bool UpdateBorrowingRecord(int BorrowingRecordID, DateTime BorrowingDate, DateTime DueDate, DateTime ActualReturnDate, byte BorrowStatus, byte ExtensionCount, string Notes, int LastModifiedByUserID, DateTime LastModifiedDate)
		{
			int RowsAffected = 0;
			try
			{

				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					connection.Open();

					using (SqlCommand cmdSetUser = new SqlCommand("EXEC sp_set_session_context 'CurrentUserID', @UserID", connection))
					{
						cmdSetUser.Parameters.AddWithValue("@UserID", LastModifiedByUserID);
						cmdSetUser.ExecuteNonQuery();
					}


					using (SqlCommand command = new SqlCommand("SP_UpdateBorrowingRecord", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
						command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
						command.Parameters.AddWithValue("@DueDate", DueDate);
						if (ActualReturnDate != DateTime.MinValue)
						{
							command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
						}
						else
						{
							command.Parameters.AddWithValue("@ActualReturnDate", System.DBNull.Value);
						}
						command.Parameters.AddWithValue("@BorrowStatus", BorrowStatus);
						command.Parameters.AddWithValue("@ExtensionCount", ExtensionCount);
						if (!string.IsNullOrEmpty(Notes))
						{
							command.Parameters.AddWithValue("@Notes", Notes);
						}
						else
						{
							command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
						}
						if (LastModifiedByUserID != -1)
						{
							command.Parameters.AddWithValue("@LastModifiedByUserID", LastModifiedByUserID);
						}
						else
						{
							command.Parameters.AddWithValue("@LastModifiedByUserID", System.DBNull.Value);
						}
						if (LastModifiedDate != DateTime.MinValue)
						{
							command.Parameters.AddWithValue("@LastModifiedDate", LastModifiedDate);
						}
						else
						{
							command.Parameters.AddWithValue("@LastModifiedDate", System.DBNull.Value);
						}

						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex) { return false; }
			return RowsAffected > 0;
		}


		/// <summary>
		/// Checks if a specific record exists in the <c>BorrowingRecords</c> table based on the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record exists; otherwise, <c>false</c>.</returns>

		public static bool IsBorrowingRecordExist(int BorrowingRecordID)
		{
			bool isExist = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_IsBorrowingRecordExist", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
						connection.Open();
						var result = command.ExecuteScalar();
						isExist = (result != null);
					}
				}
			}
			catch (Exception ex) { return false; }
			return isExist;
		}

	}
}
