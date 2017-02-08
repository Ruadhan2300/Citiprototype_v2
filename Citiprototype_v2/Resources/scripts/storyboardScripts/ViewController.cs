using System;
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
				loginButton(this);
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
				TextInputTest.Text = "Invalid Code";
			}
			/*
			if (PersistentDataCache.Instance.user.login("", "")) // logged in succesfully
			{
				PersistentDataCache.Instance.LoggedIn = true;
				instance.NavigationController.PushViewController(nextPage, true);
			}*/
			//instance.NavigationController.PushViewController(nextPage, false);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
