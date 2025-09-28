using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
    public class clsDataBaseMaintenance
    {
		public static bool BackupDatabase(string backupPath)
		{
			return LibraryDataAccess.clsDatabaseMaintenance.BackupDatabase(backupPath);
		}

		public static bool RestoreDatabase(string backupPath, out string errorMessage)
		{
			return LibraryDataAccess.clsDatabaseMaintenance.RestoreDatabase(backupPath, out errorMessage);
		}

	}
}
