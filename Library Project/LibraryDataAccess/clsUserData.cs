using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	public class clsUserData
	{




		public static DataTable GetAllUsers()
		{
			DataTable dt = new DataTable();

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
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
			catch (Exception ex)
			{

			}

			return dt;
		}



		/// <summary>
		/// Retrieves a specific record from the <c>Users</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record was found; otherwise, <c>false</c>.</returns>

		public static bool FindUser(int UserID, ref int PersonID, ref string Username, ref string Password, ref short Permissions, ref bool IsActive)
		{
			bool IsFound = false;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@UserID", UserID);

						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsFound = true;
								PersonID = (int)reader["PersonID"];
								Username = (string)reader["Username"];
								Password = (string)reader["Password"];
								Permissions = Convert.ToInt16(reader["Permissions"]);
								IsActive = Convert.ToBoolean(reader["IsActive"]);
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
		/// Inserts a new record into the <c>Users</c> table.
		/// </summary>
		/// <returns>The ID of the inserted record, or -1 if the insert failed.</returns>

		public static int AddNewUser(int PersonID, string Username, string Password, short Permissions, bool IsActive)
		{
			int UserID = -1;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("@PersonID", PersonID);
						command.Parameters.AddWithValue("@Username", Username);
						command.Parameters.AddWithValue("@Password", Password);
						command.Parameters.AddWithValue("@Permissions", Permissions);
						command.Parameters.AddWithValue("@IsActive", IsActive); 

						SqlParameter OutPutParam = new SqlParameter("@UserID", SqlDbType.Int)
						{
							Direction = ParameterDirection.Output
						};
						command.Parameters.Add(OutPutParam);

						connection.Open();
						command.ExecuteNonQuery();

						UserID = (int)OutPutParam.Value;
					}
				}
			}
			catch (Exception ex)
			{

			}

			return UserID;
		}




		/// <summary>
		/// Updates a record in the <c>Users</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was updated; otherwise, <c>false</c>.</returns>

		public static bool UpdateUser(int UserID, int PersonID, string Username, string Password, short Permissions, bool IsActive)
		{
			int RowsAffected = 0;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("@UserID", UserID);
						command.Parameters.AddWithValue("@PersonID", PersonID);
						command.Parameters.AddWithValue("@Username", Username);
						command.Parameters.AddWithValue("@Password", Password);
						command.Parameters.AddWithValue("@Permissions", Permissions);
						command.Parameters.AddWithValue("@IsActive", IsActive); // ✅ تمت الإضافة هنا

						connection.Open();
						RowsAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
				return false;
			}

			return RowsAffected > 0;
		}



		/// <summary>
		/// Checks if a specific record exists in the <c>Users</c> table based on the primary key.
		/// </summary>
		/// <returns><c>true</c> if the record exists; otherwise, <c>false</c>.</returns>

		public static bool IsUserExist(int UserID)
		{
			bool isExist = false;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_IsUserExist", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@UserID", UserID);

						connection.Open();
						var result = command.ExecuteScalar();
						isExist = (result != null);
					}
				}
			}
			catch (Exception ex)
			{
				return false;
			}

			return isExist;
		}


		/// <summary>
		/// Deletes a record from the <c>Users</c> table using the primary key.
		/// </summary>
		/// <returns><c>true</c> if a record was deleted; otherwise, <c>false</c>.</returns>

		public static bool DeleteUser(int UserID)
		{
			int RowAffected = 0;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
					{
						command.CommandType = CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@UserID", UserID);

						connection.Open();
						RowAffected = command.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
			}

			return (RowAffected > 0);
		}

		/// <summary>
		/// Attempts to log in a user by matching the username and password.
		/// </summary>
		/// <returns><c>true</c> if login is successful; otherwise, <c>false</c>.</returns>
		public static bool Login(string Username, string Password, ref int UserID, ref int PersonID, ref short Permissions)
		{
			bool IsAuthenticated = false;

			try
			{
				using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring))
				{
					using (SqlCommand command = new SqlCommand("SP_Login", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						command.Parameters.AddWithValue("@Username", Username);
						command.Parameters.AddWithValue("@Password", Password);

						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
								IsAuthenticated = true;

								UserID = (int)reader["UserID"];
								PersonID = (int)reader["PersonID"];
								Permissions = Convert.ToInt16(reader["Permissions"]);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				IsAuthenticated = false;
			}

			return IsAuthenticated;
		}


	}


}
