﻿using System;
using UIKit;


namespace Citiprototype_v2
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		/// <summary>
		/// initialisation
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.


			initButtons();

			initUI();

		}

		/// <summary>
		/// initialise the button events
		/// </summary>
		public void initButtons()
		{
			LoginButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				//Submit login
				loginButton(this);
			};

			LoginHelpButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				//Open help window
			};

			LoginBackButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				//Back button
			};
		}


			/// <summary>
			/// initialise the UI elements
			/// </summary>
		public void initUI()
		{
			LoginBackButton.Enabled = false;
			LoginBackButton.Alpha = 0f;
		}

		/// <summary>
		/// Login to app
		/// </summary>
		/// <param name="instance">Instance.</param>
		public void loginButton(ViewController instance)
		{
			string emailInput = TextInputTest.Text;

			SecondViewController nextPage = instance.Storyboard.InstantiateViewController("LoginComplete") as SecondViewController;

				PersistentDataCache.Instance.LoggedIn = true;
			if (AppController.Instance.checkLogin(emailInput, ""))
			{
				instance.NavigationController.PushViewController(nextPage, false);
			}
			else {
				TextInputTest.Text = "";
				TextInputTest.Placeholder = "Invalid Code!";
			}

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
