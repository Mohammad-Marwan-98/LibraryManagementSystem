using LibraryBusiness;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library
{
	public class clsGlobal
	{

		public static string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\Library";
		public static string valuenameuser = "username";
		public static string valuenamepassword = "password";

		public static clsUser CurrentUser;
		public static clsSettings Settings;


		public static bool RememberUserNameAndPasswordWR(string username, string password)
		{

			try
			{
				Registry.SetValue(KeyPath, valuenameuser, username, RegistryValueKind.String);
				Registry.SetValue(KeyPath, valuenamepassword, password, RegistryValueKind.String);

				return true;

			}

			catch (Exception ex) { return false; }

		}

		public static bool GetStoredCredentialWR(ref string UserName, ref string Password)
		{

			try
			{

				UserName = Registry.GetValue(KeyPath, "username", null) as string;
				Password = Registry.GetValue(KeyPath, "password", null) as string;

				if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
					return false;

				return true;
			}
			catch (Exception ex) { return false; }
		}
	}
}
