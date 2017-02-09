using System;
using UIKit;
namespace Citiprototype_v2
{
	public class AppController
	{
		private static AppController instance;

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
			if (email == "") {
				return true;
			}
			return true;
		}

	}
}
