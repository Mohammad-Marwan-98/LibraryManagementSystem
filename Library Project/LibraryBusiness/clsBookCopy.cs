using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
	public class clsBookCopy
	{
		public static bool AddCopies(int BookID,int NumberOfCopies)
		{
			return clsBookCopyData.AddBookCopies(BookID,NumberOfCopies);
		}
		public static bool DeleteCopy(int CopyID,int BookID)
		{
			return clsBookCopyData.DeleteCopy(CopyID,BookID);
		}
		public static bool UpdateCopy(int CopyID,bool IsAvailable)
		{
			return clsBookCopyData.UpdateCopy(CopyID,IsAvailable);
		}
		public static DataTable GetAllCopies(int BookID)
		{
			return clsBookCopyData.GetAllCopies(BookID);
		}
	}
}
