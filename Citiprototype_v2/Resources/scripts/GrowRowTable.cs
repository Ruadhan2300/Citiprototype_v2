using System;
using UIKit;

namespace Citiprototype_v2
{
	public class GrowRowTableDelegate : UITableViewDelegate
	{
		#region Private Variables
		private TableManager Controller;
		#endregion

		#region Constructors
		public GrowRowTableDelegate()
		{
		}

		public GrowRowTableDelegate(TableManager controller)
		{
			// Initialize
			this.Controller = controller;
		}
		#endregion

		#region Override Methods
		public override nfloat EstimatedHeight(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 40f;
		}

		public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			// Output selected row
			Console.WriteLine("Row selected: {0}", indexPath.Row);
		}
		#endregion
	}
}
