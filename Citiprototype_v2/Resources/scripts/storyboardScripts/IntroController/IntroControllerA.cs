using Foundation;
using System;
using UIKit;
using System.Threading.Tasks;

namespace Citiprototype_v2
{
	public partial class IntroControllerA : UIViewController
	{
		public IntroControllerA(IntPtr handle) : base(handle)
		{
		}

		private static IntroControllerA me;
		public override void ViewDidLoad()
		{
			me = this;
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			initButtons();
			startTimer(me);

		}
		/// <summary>
		/// initialise the button events
		/// </summary>
		public void initButtons()
		{
			Button_Skip.TouchUpInside += (object sender, EventArgs e) =>
			{
				SignupController nextPage = this.Storyboard.InstantiateViewController("LoginHub") as SignupController;
				isDone = true;
				this.NavigationController.PushViewController(nextPage, false);
			};

		}
		private bool isDone = false;
		public async void startTimer(IntroControllerA me)
		{
			await PutTaskDelay();
			if (!isDone)
			{
				IntroControllerB nextPage = me.Storyboard.InstantiateViewController("IntroB") as IntroControllerB;
				me.NavigationController.PushViewController(nextPage, false);
			}
		}
		async Task PutTaskDelay()
		{
			await Task.Delay(3000);
		}
	}
}