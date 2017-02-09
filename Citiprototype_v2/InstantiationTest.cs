using System;

using UIKit;

namespace Citiprototype_v2
{
	public partial class InstantiationTest : UIViewController
	{
		public InstantiationTest() : base("InstantiationTest", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

