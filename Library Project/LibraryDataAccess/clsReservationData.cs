using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsReservationData
	{
		public static DataTable GetAllReservations()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllReservations", connection))
					{
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
		/// Retrieves a specific record from the <c>Reservations</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindReservation(int ReservationID, ref int ReaderID, ref int BookID, ref DateTime ReservationDate, ref int CreatedByUserID, ref bool IsActive)
		{
			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindReservation", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@ReservationID", ReservationID);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;
								ReaderID = (int)reader["ReaderID"];
								BookID = (int)reader["BookID"];
								ReservationDate = (DateTime)reader["ReservationDate"];
								CreatedByUserID = (int)reader["CreatedByUserID"];
								IsActive = (bool)reader["IsActive"];

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

		public static DataTable GetFirstActiveReservation(int BookID)
		{
			DataTable dt = new DataTable();

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetFirstActiveReservation", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BookID", BookID);

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
			catch (Exception ex)
			{

			}

			return dt;
		}

		public static bool UpdateReservationStatus(int ReservationID, bool IsActive)
		{
			int rowsAffected = 0;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_UpdateReservationStatus", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@ReservationID", ReservationID);
						command.Parameters.AddWithValue("@IsActive", IsActive);

						connection.Open();
						rowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{

			}

			return (rowsAffected > 0);
		}




		/// <summary>
		/// Inserts a new record into the <c>Reservations</c> table.
		/// </summary>
		/// <returns>The ID of the inserted record, or -1 if the insert failed.</returns>

		public static int AddNewReservation(int ReaderID, int BookID,int CreatedByUserID)
		{
			int ReservationID = -1;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_AddReservation", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						connection.Open();
						command.Parameters.AddWithValue("@ReaderID", ReaderID);
						command.Parameters.AddWithValue("@BookID", BookID);
						command.Parameters.AddWithValue("@UserID", CreatedByUserID);

						SqlParameter outputparam = new SqlParameter("@ReservationID", SqlDbType.Int)
						{
							Direction = ParameterDirection.Output
						};
						command.Parameters.Add(outputparam);
						command.ExecuteNonQuery();
						ReservationID = Convert.ToInt32(outputparam.Value);
					}
				}
			}
			catch (Exception ex) { }
			return ReservationID;
		}


		

		public static bool DeleteReservation(int ReservationID)
		{
			int RowAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_DeleteReservation", connection))
					{
						command.CommandType= CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@ReservationID", ReservationID);
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
