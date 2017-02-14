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
				//Submit login
				loginButton();
			};

			LoginHelpButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				//Open help window
				AppController.Instance.SendServerRequest(null);
			};

			LoginBackButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				//Back button
				backButton();
			};
		}


			/// <summary>
			/// initialise the UI elements
			/// </summary>
		public void initUI()
		{
			//LoginBackButton.Enabled = false;
			//LoginBackButton.Alpha = 0f;
			EmailBar.Highlighted = false;
			PasswordBar.Highlighted = false;
		}

		/// <summary>
		/// Login to app
		/// </summary>
		/// <param name="instance">Instance.</param>
		public void loginButton()
		{
			string emailInput = LoginEmail.Text;
			string passwordInput = LoginPassword.Text;


			EmailBar.Highlighted = false;
			PasswordBar.Highlighted = false;

			AppController.DATAINPUT_RESULT loginResult = AppController.Instance.checkLogin(emailInput, passwordInput);
			if (loginResult == AppController.DATAINPUT_RESULT.VALID)
			{
				SecondViewController nextPage = this.Storyboard.InstantiateViewController("LoginComplete") as SecondViewController;

				PersistentDataCache.Instance.LoggedIn = true;
				this.NavigationController.PushViewController(nextPage, false);
			}
			else {
				if (loginResult == AppController.DATAINPUT_RESULT.EMAIL_TOO_SHORT)
				{

					LoginEmail.Text = "";
					LoginEmail.Placeholder = "Invalid Email!";
					EmailBar.Highlighted = true;
				}
				if (loginResult == AppController.DATAINPUT_RESULT.PASSWORD_INVALID)
				{
					LoginPassword.Text = "";
					LoginPassword.Placeholder = "Invalid Password!";
					PasswordBar.Highlighted = true;
				}
			}

		}

		/// <summary>
		/// Back to the main startup hub
		/// </summary>
		public void backButton()
		{

			LoginBackButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				SignupController nextPage = this.Storyboard.InstantiateViewController("LoginHub") as SignupController;

				this.NavigationController.PushViewController(nextPage, false);

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
