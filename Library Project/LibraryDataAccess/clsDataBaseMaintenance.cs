using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
	
		public class clsDatabaseMaintenance
		{
			public static bool BackupDatabase(string backupPath)
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.connectionstring))
					{
						using (SqlCommand cmd = new SqlCommand("SP_BackupDatabase", conn))
						{
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.AddWithValue("@BackupPath", backupPath);

							conn.Open();
							cmd.ExecuteNonQuery();
						}
					}

					return true;
				}
				catch (Exception ex)
				{
					return false;
				}
			}

		public static bool RestoreDatabase(string backupPath, out string errorMessage)
		{
			errorMessage = "";

			try
			{
				using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.masterconnectionstring))
				{
					using (SqlCommand cmd = new SqlCommand("SP_RestoreLibraryDatabase", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@BackupPath", backupPath);

						conn.Open();
						cmd.ExecuteNonQuery();
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				errorMessage = ex.Message;
				return false;
			}
		}

	}

}

