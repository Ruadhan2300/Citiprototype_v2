using System;
using Foundation;
using UIKit;

namespace Citiprototype_v2
{

	public class RootTableSource : UITableViewSource
	{

		// there is NO database or storage of Tasks in this example, just an in-memory List<>
		Message[] tableItems;
		string cellIdentifier = "CellProto"; // set in the Storyboard

		public RootTableSource(Message[] items)
		{
			tableItems = items;
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}
		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(cellIdentifier, indexPath) as TableExampleClass;
			var item = tableItems[indexPath.Row];

			// Setup
			//cell.Image = UIImage.FromFile(item.ImageName);
			cell.Title = item.SenderName;
			cell.Text = item.Content;

			return cell;
		}
		public Message GetItem(int id)
		{
			return tableItems[id];
		}
	}

}
