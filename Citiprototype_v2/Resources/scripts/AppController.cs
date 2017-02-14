using System;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using UIKit;
using System.Linq;
using Newtonsoft.Json;

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

		private string userName;
		private string userEmail;
		private string userPassword;

		public enum DATAINPUT_RESULT
		{
			VALID,
			EMPTY,
			EMAIL_IN_USE,
			EMAIL_TOO_SHORT,
			PASSWORD_INVALID
		}


		public DATAINPUT_RESULT setUserName(string name)
		{
			if (name.Trim().Length == 0)
			{
				return DATAINPUT_RESULT.EMPTY;
			}
			userName = name;
			return DATAINPUT_RESULT.VALID;
		}

		public DATAINPUT_RESULT setEmail(string email)
		{
			if (email.Trim().Length == 0)
			{
				return DATAINPUT_RESULT.EMPTY;
			}
			//Query database for accounts using this email address. users are only allowed one per email!

			userEmail = email;
			return DATAINPUT_RESULT.VALID;
		}
		public DATAINPUT_RESULT setPassword(string password)
		{
			if (password.Trim().Length == 0)
			{
				return DATAINPUT_RESULT.EMPTY;
			}
			//If we have any requirements, check them here (eg: Capitalisation, numbers, special characters)

			userPassword = password;
			return DATAINPUT_RESULT.VALID;
		}

		public DATAINPUT_RESULT createAccount(string name, string email, string password)
		{
			//Query database for accounts with this email and password.
			//If there is none, create a new account and sign into it.
			//Otherwise we want to either log into the existing account or step back and alert the user.

			return DATAINPUT_RESULT.VALID;
		}

		public DATAINPUT_RESULT checkLogin(string email, string password) {

			//Query database for accounts with this email and password.
			if (email != "Test") {
				return DATAINPUT_RESULT.EMAIL_TOO_SHORT;
			}
			if (password != "Password")
			{
				return DATAINPUT_RESULT.PASSWORD_INVALID;
			}
			return DATAINPUT_RESULT.VALID;
		}



		public void SendServerRequest(object requestData)
		{
			Dictionary<string,object> newRequest = new Dictionary<string, object>();
			newRequest["data1"] = "test";
			newRequest["data2"] = "testing";
			newRequest["data3"] = "tested";


			string data = JsonConvert.SerializeObject(newRequest);
			data = RequestDataManipulator.encodeData(data);
			FakeApplicationServer.Instance.serverReceiver(data);
		}

		/// <summary>
		/// Recieves JSon format data from application server
		/// </summary>
		/// <param name="data">Data.</param>
		public void GetServerData(string data)
		{

		}
	}
}
