using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsBookData
	{
		/// <summary>
		/// Retrieves all rows from the <c>Books</c> table.
		/// </summary>
		/// <returns>A <see cref="DataTable"/> containing all records from the table.</returns>

		public static DataTable GetAllBooks()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllBooks", connection))
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

		public static DataTable GetBooksWithZeroCopies()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetBooksWithZeroCopies", connection))
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


		public static int GetNumberOfAvailableCopies(int BookID)
		{
			int count = 0;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetNumberOfAvailableCopies", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BookID", BookID);

						connection.Open();
						object result = command.ExecuteScalar();

						if (result != null)
							count = Convert.ToInt32(result);
					}
				}
			}
			catch (Exception ex)
			{

			}

			return count;
		}


		/// <summary>
		/// Retrieves a specific record from the <c>Books</c> table by BookID.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindBookByID(int BookID, ref string Title, ref string ISBN,
								ref DateTime PublicationDate, ref string Genre,
								ref string AdditionalDetails, ref string Author,
								ref string Description, ref bool IsAvailable,
								ref string Language, ref short NumberOfCopies)
		{
			bool IsFound = false;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindBookByID", connection))
					{
						command.Parameters.AddWithValue("@BookID", BookID);
						command.CommandType = CommandType.StoredProcedure;

						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;

								Title = reader["Title"]?.ToString();
								ISBN = reader["ISBN"]?.ToString();
								PublicationDate = reader["PublicationDate"] != DBNull.Value
									? (DateTime)reader["PublicationDate"]
									: DateTime.MinValue;
								Genre = reader["Genre"]?.ToString();
								AdditionalDetails = reader["AdditionalDetails"]?.ToString() ?? string.Empty;
								Author = reader["Author"]?.ToString() ?? string.Empty;
								Description = reader["Description"]?.ToString() ?? string.Empty;
								IsAvailable = reader["IsAvailable"] != DBNull.Value
									? (bool)reader["IsAvailable"]
									: false;
								Language = reader["Language"]?.ToString() ?? "Unknown";

								NumberOfCopies = reader["NumberOfCopies"] != DBNull.Value
									? Convert.ToInt16(reader["NumberOfCopies"])
									: (short)0;
							}
						}
					}
				}
			}
			catch (Exception ex) { }

			return IsFound;
		}



		/// <summary>
		/// Retrieves a specific record from the <c>Books</c> table by Title.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindBookByTitle(ref int BookID, string Title, ref string ISBN,
								   ref DateTime PublicationDate, ref string Genre,
								   ref string AdditionalDetails, ref string Author,
								   ref string Description, ref bool IsAvailable,
								   ref string Language, ref short NumberOfCopies)
		{

			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindBookByTitle", connection))
					{
						command.Parameters.AddWithValue("@Title", Title);
						command.CommandType = CommandType.StoredProcedure;

						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;

								BookID = (int)reader["BookID"];
								ISBN = (string)reader["ISBN"];
								PublicationDate = reader["PublicationDate"] != DBNull.Value
									? (DateTime)reader["PublicationDate"]
									: DateTime.MinValue;

								Genre = (string)reader["Genre"];
								AdditionalDetails = reader["AdditionalDetails"] != DBNull.Value
									? (string)reader["AdditionalDetails"]
									: string.Empty;

								Author = reader["Author"] != DBNull.Value
									? (string)reader["Author"]
									: string.Empty;

								Description = reader["Description"] != DBNull.Value
									? (string)reader["Description"]
									: string.Empty;

								IsAvailable = reader["IsAvailable"] != DBNull.Value
									? (bool)reader["IsAvailable"]
									: false;

								Language = reader["Language"] != DBNull.Value
									? (string)reader["Language"]
									: "Unknown";

								NumberOfCopies = reader["NumberOfCopies"] != DBNull.Value
									? Convert.ToInt16(reader["NumberOfCopies"])
									: (short)0;
							}
						}
					}
				}
			}
			catch(Exception ex) { }
			return IsFound;
		}


		/// <summary>
		/// Retrieves a specific record from the <c>Books</c> table by ISBN.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindBookByISBN(ref int BookID, ref string Title, string ISBN,
								  ref DateTime PublicationDate, ref string Genre,
								  ref string AdditionalDetails, ref string Author,
								  ref string Description, ref bool IsAvailable,
								  ref string Language, ref short NumberOfCopies)
		{

			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindBookByISBN", connection))
					{
						command.Parameters.AddWithValue("@ISBN", ISBN);
						command.CommandType = CommandType.StoredProcedure;

						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;

								BookID = (int)reader["BookID"];
								Title = (string)reader["Title"];
								PublicationDate = reader["PublicationDate"] != DBNull.Value
									? (DateTime)reader["PublicationDate"]
									: DateTime.MinValue;

								Genre = (string)reader["Genre"];

								AdditionalDetails = reader["AdditionalDetails"] != DBNull.Value
									? (string)reader["AdditionalDetails"]
									: string.Empty;

								Author = reader["Author"] != DBNull.Value
									? (string)reader["Author"]
									: string.Empty;

								Description = reader["Description"] != DBNull.Value
									? (string)reader["Description"]
									: string.Empty;

								IsAvailable = reader["IsAvailable"] != DBNull.Value
									? (bool)reader["IsAvailable"]
									: false;

								Language = reader["Language"] != DBNull.Value
									? (string)reader["Language"]
									: "Unknown";

								NumberOfCopies = reader["NumberOfCopies"] != DBNull.Value
									? Convert.ToInt16(reader["NumberOfCopies"])
									: (short)0;
							}
						}
					}
				}
			}
			catch(Exception) { }

			return IsFound;
		}



		/// <summary>
		/// Inserts a new record into the <c>Books</c> table.
		/// </summary>
		/// <returns>The ID of the inserted record, or -1 if the insert failed.</returns>

		public static int AddNewBook(string Title, string Author, string ISBN, DateTime? PublicationDate,
							 string Genre, string Description, string AdditionalDetails,
							 string Language, short NumberOfCopies)
		{
			int NewBookID = -1;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_AddNewBook", connection))
					{
						connection.Open();
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("@Title", Title);
						command.Parameters.AddWithValue("@Author", Author);
						command.Parameters.AddWithValue("@ISBN", ISBN);
						command.Parameters.AddWithValue("@Genre", Genre);
						command.Parameters.AddWithValue("@Language", Language);
						command.Parameters.AddWithValue("@NumberOfCopies", NumberOfCopies);

						command.Parameters.AddWithValue("@PublicationDate",
							PublicationDate.HasValue ? (object)PublicationDate.Value : DBNull.Value);

						command.Parameters.AddWithValue("@Description",
							!string.IsNullOrEmpty(Description) ? (object)Description : DBNull.Value);

						command.Parameters.AddWithValue("@AdditionalDetails",
							!string.IsNullOrEmpty(AdditionalDetails) ? (object)AdditionalDetails : DBNull.Value);

						SqlParameter outputParam = new SqlParameter("@NewBookID", SqlDbType.Int)
						{
							Direction = ParameterDirection.Output
						};
						command.Parameters.Add(outputParam);

						command.ExecuteNonQuery();
						NewBookID = Convert.ToInt32(outputParam.Value);
					}
				}
			}
			catch (Exception ex) { }

			return NewBookID;
		}

		

		/// <summary>
		/// Updates a record in the <c>Books</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was updated; otherwise, <c>false</c>.</returns>

		public static bool UpdateBook(int BookID, string Title, string Author, string ISBN, DateTime? PublicationDate,
							  string Genre, string Description, string AdditionalDetails,
							  string Language)
		{
			int RowsAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_UpdateBook", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("@BookID", BookID);
						command.Parameters.AddWithValue("@Title", Title);
						command.Parameters.AddWithValue("@Author", Author);
						command.Parameters.AddWithValue("@ISBN", ISBN);
						command.Parameters.AddWithValue("@Genre", Genre);
						command.Parameters.AddWithValue("@Language", Language);

						command.Parameters.AddWithValue("@PublicationDate",
							PublicationDate.HasValue ? (object)PublicationDate.Value : DBNull.Value);

						command.Parameters.AddWithValue("@Description",
							!string.IsNullOrEmpty(Description) ? (object)Description : DBNull.Value);

						command.Parameters.AddWithValue("@AdditionalDetails",
							!string.IsNullOrEmpty(AdditionalDetails) ? (object)AdditionalDetails : DBNull.Value);

						connection.Open();
						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{ 
			
			}

			return RowsAffected > 0;
		}


		/// <summary>
		/// Checks if a specific record exists in the <c>Books</c> table based on the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record exists; otherwise, <c>false</c>.</returns>

		public static bool IsBookExistByID(int BookID)
		{
			bool isExist = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_IsBookExist", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BookID", BookID);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							isExist = reader.HasRows;
						}
					}
				}
			}
			catch (Exception ex) { return false; }
			return isExist;
		}


		/// <summary>
		/// Deletes a record from the <c>Books</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was deleted; otherwise, <c>false</c>.</returns>

		public static bool DeleteBook(int BookID)
		{
			int RowAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_DeleteBook", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@BookID", BookID);
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
