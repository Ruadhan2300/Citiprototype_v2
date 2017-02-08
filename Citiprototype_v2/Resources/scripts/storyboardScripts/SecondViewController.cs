using Foundation;
using System;
using UIKit;

namespace Citiprototype_v2
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			LoginCompleteBackButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				ViewController nextPage = this.Storyboard.InstantiateViewController("LoginScreen") as ViewController;

				this.NavigationController.PushViewController(nextPage, false);

			};
			updateView();
		}

		public void updateView()
		{
			//PersistentDataCache dataCache = PersistentDataCache.Instance;
			setLoginCompleteText(PersistentDataCache.Instance.LoggedIn.ToString());
		}

		public void setLoginCompleteText(string text)
		{
			LoginCompleteTextTest.Text = text;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}