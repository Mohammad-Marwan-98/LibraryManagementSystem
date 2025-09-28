using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsReaderData
	{
		/// <summary>
		/// Retrieves all rows from the <c>Readers</c> table.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all records from the table.</returns>

		public static DataTable GetAllReaders()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllReaders", connection))
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
		/// Retrieves a specific record from the <c>Readers</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindReader(int ReaderID, ref int PersonID, ref string LibraryCardNumber, ref byte SubscriptionStatus, ref DateTime JoinDate, ref DateTime SubscriptionExpiryDate, ref bool IsActive, ref string Notes)
		{
			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindReader", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@ReaderID", ReaderID);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;
								PersonID = (int)reader["PersonID"];
								LibraryCardNumber = (string)reader["LibraryCardNumber"];
								SubscriptionStatus = (byte)reader["SubscriptionStatus"];
								JoinDate = (DateTime)reader["JoinDate"];
								SubscriptionExpiryDate = (DateTime)reader["SubscriptionExpiryDate"];
								IsActive = (bool)reader["IsActive"];
								if (reader["Notes"] != DBNull.Value)
								{
									Notes = (string)reader["Notes"];
								}
								else
								{
									Notes = default;
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
		/// Retrieves a specific record from the <c>Readers</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindReaderByLibraryCard(ref int ReaderID, ref int PersonID,  string LibraryCardNumber, ref byte SubscriptionStatus, ref DateTime JoinDate, ref DateTime SubscriptionExpiryDate, ref bool IsActive, ref string Notes)
		{
			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindReaderByLibraryCardNumber", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{

								IsFound = true;
								ReaderID = (int)reader["ReaderID"];
								PersonID = (int)reader["PersonID"];
								SubscriptionStatus = (byte)reader["SubscriptionStatus"];
								JoinDate = (DateTime)reader["JoinDate"];
								SubscriptionExpiryDate = (DateTime)reader["SubscriptionExpiryDate"];
								IsActive = (bool)reader["IsActive"];
								if (reader["Notes"] != DBNull.Value)
								{
									Notes = (string)reader["Notes"];
								}
								else
								{
									Notes = default;
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
		/// Inserts a new record into the <c>Readers</c> table.
		/// </summary>
		/// <returns>The ID of the inserted record, or -1 if the insert failed.</returns>

		public static int AddNewReader(int PersonID, string LibraryCardNumber, byte SubscriptionStatus, int SubscriptionPeriod, bool IsActive, string Notes)
		{
			int ReaderID = -1;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
			using (SqlCommand command = new SqlCommand("SP_AddNewReader", connection))
			{
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.AddWithValue("@PersonID", PersonID);
				command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
				command.Parameters.AddWithValue("@SubscriptionStatus", SubscriptionStatus);
				command.Parameters.AddWithValue("@SubscriptionPeriod", SubscriptionPeriod);
				command.Parameters.AddWithValue("@IsActive", IsActive);

				if (!string.IsNullOrEmpty(Notes))
					command.Parameters.AddWithValue("@Notes", Notes);
				else
					command.Parameters.AddWithValue("@Notes", DBNull.Value);

				SqlParameter outputParam = new SqlParameter("@ReaderID", SqlDbType.Int)
				{
					Direction = ParameterDirection.Output
				};
				command.Parameters.Add(outputParam);

				connection.Open();
				command.ExecuteNonQuery();
				ReaderID = Convert.ToInt32(outputParam.Value);
			}

			return ReaderID;
		}



		/// <summary>
		/// Updates a record in the <c>Readers</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was updated; otherwise, <c>false</c>.</returns>


		public static string GenerateLibraryCardNumber()
		{
			string LibraryCardNumber = "";

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
			{
				using (SqlCommand command = new SqlCommand("SP_GenerateLibraryCardNumber", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					connection.Open();

					var result = command.ExecuteScalar();
					if (result != null)
						LibraryCardNumber = result.ToString();
				}
			}

			return LibraryCardNumber;
		}




		public static bool UpdateReader(int ReaderID, byte SubscriptionStatus, bool IsActive, string Notes)
		{
			int RowsAffected = 0;

			using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
			using (SqlCommand command = new SqlCommand("SP_UpdateReader", connection))
			{
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.AddWithValue("@ReaderID", ReaderID);
				command.Parameters.AddWithValue("@SubscriptionStatus", SubscriptionStatus);
				command.Parameters.AddWithValue("@IsActive", IsActive);

				command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? DBNull.Value : (object)Notes);

				connection.Open();
				RowsAffected = command.ExecuteNonQuery();
			}

			return RowsAffected > 0;
		}


		public static bool ExtendSubscription(int ReaderID, byte SubscriptionPeriod)
		{
			int RowsAffected = 0;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				using (SqlCommand command = new SqlCommand("SP_ExtendSubscription", connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					command.Parameters.AddWithValue("@ReaderID", ReaderID);
					command.Parameters.AddWithValue("@SubscriptionPeriod", SubscriptionPeriod);

					connection.Open();
					RowsAffected = command.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				return false;
			}

			return RowsAffected > 0;
		}



		/// <summary>
		/// Checks if a specific record exists in the <c>Readers</c> table based on the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record exists; otherwise, <c>false</c>.</returns>

		public static bool IsReaderExist(int ReaderID)
		{
			bool isExist = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_IsReaderExist", connection))
					{
						command.CommandType= CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@ReaderID", ReaderID);
						connection.Open();
						var result = command.ExecuteScalar();
						isExist = (result != null);
					}
				}
			}
			catch (Exception ex) { return false; }
			return isExist;
		}


		/// <summary>
		/// Deletes a record from the <c>Readers</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was deleted; otherwise, <c>false</c>.</returns>

		public static bool DeleteReader(int ReaderID)
		{
			int RowAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_DeleteReader", connection))
					{
						command.CommandType= CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@ReaderID", ReaderID);
						connection.Open();
						RowAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex) { }
			return (RowAffected > 0);
		}

	}
}
