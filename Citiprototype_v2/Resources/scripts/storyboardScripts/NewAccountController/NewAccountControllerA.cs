using Foundation;
using System;
using UIKit;

namespace Citiprototype_v2
{
    public partial class NewAccountControllerA : UIViewController
    {
        public NewAccountControllerA (IntPtr handle) : base (handle)
        {
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

			Button_Continue.TouchUpInside += (object sender, EventArgs e) =>
			{
				NewAccountControllerB nextPage = this.Storyboard.InstantiateViewController("NewAccountEmail") as NewAccountControllerB;

				this.NavigationController.PushViewController(nextPage, false); };

			Back.TouchUpInside += (object sender, EventArgs e) =>
			{
				SignupController lastPage = this.Storyboard.InstantiateViewController("LoginHub") as SignupController;

				this.NavigationController.PushViewController(lastPage, false);;
			};
		}


		/// <summary>
		/// initialise the UI elements
		/// </summary>
		public void initUI()
		{
			;
		}
    }
}