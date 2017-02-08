using System;
using UIKit;
namespace Citiprototype_v2
{
	public class AppController
	{
		public static AppController instance;

		public static AppController Instance
		{
			get {
				if (instance == null)
				{
					instance = new AppController();
				}
				return instance; 
			}
		}

		public bool checkLogin(string email, string password) {
			if (email == "test") {
				return true;
			}
			return false;
		}

	}
}
