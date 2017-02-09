using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Citiprototype_v2
{
    public partial class TableExampleClass : UITableViewCell
    {
        #region Computed Properties
		public UIImage Image
		{
			get { return UserImage.Image; }
			set { UserImage.Image = value; }
		}

		public string Title
		{
			get { return UserTitle.Text; }
			set { UserTitle.Text = value; }
		}

		public string Text
		{
			get { return UserText.Text; }
			set { UserText.Text = value; }
		}
		#endregion

		#region Constructors
		public TableExampleClass(IntPtr handle) : base (handle)
		{
		}
		#endregion
	}
}