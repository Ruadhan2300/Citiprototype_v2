using System;
using Citiprototype_v2; 
namespace Citiprototype_v2
{
	public class PersistentDataCache
	{
		private static PersistentDataCache instance;
		public UserData user = new UserData();

		public bool LoggedIn = false;


		public static PersistentDataCache Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new PersistentDataCache();
				}
				return instance;
			}

		}


	}

	public class UserData
	{
		private string username = "";
		private string password = "";
		private string email = "";

		public bool login(string email, string password)
		{

			return true;
		}

		private string getUsername()
		{
			return username;
		}

		private string getPassword()
		{
			return password;
		}

		private string getEmail()
		{
			return email;
		}
	}
}
