using Foundation;
using System;
using UIKit;
using System.Threading.Tasks;

namespace Citiprototype_v2
{
	public partial class IntroControllerB : UIViewController
	{
		public IntroControllerB(IntPtr handle) : base(handle)
		{
		}

		private static IntroControllerB me;
		public override void ViewDidLoad()
		{
			me = this;
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			initButtons();
			startTimer();

		}
		/// <summary>
		/// initialise the button events
		/// </summary>
		public void initButtons()
		{
			Button_Skip.TouchUpInside += (object sender, EventArgs e) =>
			{
				SignupController nextPage = me.Storyboard.InstantiateViewController("LoginHub") as SignupController;
				isDone = true;
				me.NavigationController.PushViewController(nextPage, false);
			};

		}
		private bool isDone = false;
		public async void startTimer()
		{
			await PutTaskDelay();
			if (!isDone)
			{
				IntroControllerC nextPage = me.Storyboard.InstantiateViewController("IntroC") as IntroControllerC;
				me.NavigationController.PushViewController(nextPage, false);
			}
		}
		async Task PutTaskDelay()
		{
			await Task.Delay(3000);
		}
	}
}