using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsPersonData
	{

		public static DataTable GetAllPeople()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
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
		/// Retrieves a specific record from the <c>People</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindPerson(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref byte Age, ref string Address, ref string Gender, ref string Email, ref string MobileNumber)
		{
			bool IsFound = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_FindPerson", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@PersonID", PersonID);
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;
								FirstName = (string)reader["FirstName"];
								SecondName = (string)reader["SecondName"];
								if (reader["ThirdName"] != DBNull.Value)
								{
									ThirdName = (string)reader["ThirdName"];
								}
								else
								{
									ThirdName = default;
								}
								LastName = (string)reader["LastName"];
								Age = (byte)reader["Age"];
								Address = (string)reader["Address"];
								Gender = (string)reader["Gender"];
								Email = (string)reader["Email"];
								MobileNumber = (string)reader["MobileNumber"];
								
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
		/// Inserts a new record into the <c>People</c> table.
		/// </summary>
		/// <returns>The ID of the inserted record, or -1 if the insert failed.</returns>

		public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, byte Age, string Address, string Gender, string Email, string MobileNumber)
		{
			int PersonID = -1;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					
					using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
					{
						connection.Open();
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@FirstName", FirstName);
						command.Parameters.AddWithValue("@SecondName", SecondName);
						if (!string.IsNullOrEmpty(ThirdName))
						{
							command.Parameters.AddWithValue("@ThirdName", ThirdName);
						}
						else
						{
							command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
						}
						command.Parameters.AddWithValue("@LastName", LastName);
						command.Parameters.AddWithValue("@Age", Age);
						command.Parameters.AddWithValue("@Address", Address);
						command.Parameters.AddWithValue("@Gender", Gender);
						command.Parameters.AddWithValue("@Email", Email);
						command.Parameters.AddWithValue("@MobileNumber", MobileNumber);

						SqlParameter outputparam = new SqlParameter("@PersonID", SqlDbType.Int)
						{
							Direction = ParameterDirection.Output
						};

						command.Parameters.Add(outputparam);

						command.ExecuteNonQuery();
						PersonID = Convert.ToInt32(outputparam.Value);
						
					}
				}
			}
			catch (Exception ex) { }
			return PersonID;
		}


		/// <summary>
		/// Updates a record in the <c>People</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was updated; otherwise, <c>false</c>.</returns>

		public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, byte Age, string Address, string Gender, string Email, string MobileNumber)
		{
			int RowsAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					
					using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@PersonID", PersonID);
						command.Parameters.AddWithValue("@FirstName", FirstName);
						command.Parameters.AddWithValue("@SecondName", SecondName);
						if (!string.IsNullOrEmpty(ThirdName))
						{
							command.Parameters.AddWithValue("@ThirdName", ThirdName);
						}
						else
						{
							command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
						}
						command.Parameters.AddWithValue("@LastName", LastName);
						command.Parameters.AddWithValue("@Age", Age);
						command.Parameters.AddWithValue("@Address", Address);
						command.Parameters.AddWithValue("@Gender", Gender);
						command.Parameters.AddWithValue("@Email", Email);
						command.Parameters.AddWithValue("@MobileNumber", MobileNumber);
					

						connection.Open();
						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex) { return false; }
			return RowsAffected > 0;
		}


		/// <summary>
		/// Checks if a specific record exists in the <c>People</c> table based on the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record exists; otherwise, <c>false</c>.</returns>

		public static bool IsPersonExist(int PersonID)
		{
			bool isExist = false;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_IsPersonExist", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@PersonID", PersonID);
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
		/// Deletes a record from the <c>People</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was deleted; otherwise, <c>false</c>.</returns>

		public static bool DeletePerson(int PersonID)
		{
			int RowAffected = 0;
			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
					{
						command.CommandType= CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@PersonID", PersonID);
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
