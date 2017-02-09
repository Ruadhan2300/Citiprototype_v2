using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Citiprototype_v2
{
	public partial class TableManager : UITableViewController
	{
		#region Computed Properties
		public TableSource DataSource
		{
			get { return TableView.DataSource as TableSource; }
		}

		public GrowRowTableDelegate TableDelegate
		{
			get { return TableView.Delegate as GrowRowTableDelegate; }
		}
		#endregion

		#region Constructors
		public TableManager(IntPtr handle) : base(handle)
		{
		}
		#endregion

		#region Override Methods
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			// Initialize table
			TableView.DataSource = new TableSource(this);
			TableView.Delegate = new GrowRowTableDelegate(this);
			TableView.EstimatedRowHeight = 40f;
			TableView.ReloadData();
		}


		#endregion
	}
}