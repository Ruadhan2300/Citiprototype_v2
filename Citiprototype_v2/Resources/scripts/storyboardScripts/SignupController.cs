using Foundation;
using System;
using UIKit;

namespace Citiprototype_v2
{
    public partial class SignupController : UIViewController
    {
        public SignupController (IntPtr handle) : base (handle)
        {

        }

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
			Button_Login.TouchUpInside += (object sender, EventArgs e) =>
			{
				ViewController nextPage = this.Storyboard.InstantiateViewController("LoginScreen") as ViewController;

				this.NavigationController.PushViewController(nextPage, false);

			};
			Button_Signup.TouchUpInside += (object sender, EventArgs e) =>
			{
				NewAccountControllerA nextPage = this.Storyboard.InstantiateViewController("NewAccountName") as NewAccountControllerA;

				this.NavigationController.PushViewController(nextPage, false);

			};

		}

		/// <summary>
		/// initialise the UI elements
		/// </summary>
		public void initUI()
		{
		}
    }
}