using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsBookCopyData
	{
		public static bool AddBookCopies(int BookID, int NumberOfCopies)
		{
			int RowsAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_AddCopies", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BookID", BookID);
						command.Parameters.AddWithValue("@NumberOfCopies", NumberOfCopies);
						connection.Open();
						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex) { }
			return RowsAffected > 0;
		}

		public static bool DeleteCopy(int CopyID, int BookID)
		{
			int RowsAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_DeleteCopy", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@CopyID", CopyID);
						command.Parameters.AddWithValue("@BookID", BookID);
						connection.Open();
						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex) { }
			return RowsAffected > 0;
		}

		public static DataTable GetAllCopies(int BookID)
		{
			DataTable Copies = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllCopies", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BookID", BookID);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if(reader.HasRows)
							{
								Copies.Load(reader);
							}
						}
					}
				}
			}
			catch (Exception ex) { }
			return Copies;
		}

		public static bool UpdateCopy(int CopyID,bool IsAvailable)
		{
			int RowsAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_UpdateCopy", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@CopyID", CopyID);
						command.Parameters.AddWithValue("@IsAvailable", IsAvailable);
						connection.Open();
						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex) { }
			return RowsAffected > 0;
		}


	}
}
