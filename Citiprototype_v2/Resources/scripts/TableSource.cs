using System;
using System.Collections.Generic;
using Citiprototype_v2;
using UIKit;

namespace Citiprototype_v2
{
	public class TableSource : UITableViewDataSource
	{
		#region Private Variables
		private TableManager Controller;
		#endregion

		#region Computed Properties
		public List<Message> Items = new List<Message>();

		public string CellID
		{
			get { return "CellProto"; }
		}
		#endregion

		#region Constructors
		public TableSource()
		{
			// Initialize
			Initialize();
		}

		public TableSource(TableManager controller)
		{
			// Initialize
			this.Controller = controller;
			Initialize();
		}

		private void Initialize()
		{
			// Populate database
			Items = new List<Message>
			{
				new Message { senderName = "Alice", content = "Hello World" },
				new Message { senderName = "Bob", content = "Hi" },
				new Message { senderName = "Norman", content = "G'day" },
				new Message { senderName = "Matt", content = "Salutations" },
				new Message { senderName = "Steve", content = "Gut Tag" }
			};
		}
		#endregion

		#region Override Methods
		public override nint NumberOfSections(UITableView tableView)
		{
			// Hard coded 1 section
			return 1;
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return Items.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell(CellID, indexPath) as TableExampleClass;
			var item = Items[indexPath.Row];

			// Setup
			//cell.Image = UIImage.FromFile(item.ImageName);
				//cell.Title = item.SenderName;
				//cell.Text = item.Content;

			return cell;
		}
		#endregion
	}
}