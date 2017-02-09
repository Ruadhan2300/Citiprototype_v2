using Foundation;
using System;
using System.Collections.Generic;
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

			initButtons();

			initUI();

		}

		/// <summary>
		/// initialise the button events
		/// </summary>
		public void initButtons()
		{
			LoginCompleteBackButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				ViewController nextPage = this.Storyboard.InstantiateViewController("LoginScreen") as ViewController;

				this.NavigationController.PushViewController(nextPage, false);

			};


		}

		/// <summary>
		/// initialise the UI elements
		/// </summary>
		public void initUI()
		{
			setLoginCompleteText(PersistentDataCache.Instance.LoggedIn.ToString());
			List<Message> messages = new List<Message>
			{
				new Message {senderName = "Alice", content = "Hello World"},
				new Message {senderName = "Bob", content = "Hi"},
				new Message {senderName = "Norman", content = "G'day"},
				new Message {senderName = "Matt", content = "Salutations"},
				new Message {senderName = "Steve", content = "Gut Tag"}	
			};
			TableManager tManager = new TableManager(Handle);
			//TableProto.Source = ;//messages.ToArray());
			// Initialize table
			TableProto.DataSource = new TableSource(tManager);
			TableProto.Delegate = new GrowRowTableDelegate(tManager);
			TableProto.EstimatedRowHeight = 40f;
			TableProto.ReloadData();

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