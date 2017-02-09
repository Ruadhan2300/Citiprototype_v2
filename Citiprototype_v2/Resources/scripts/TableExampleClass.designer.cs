// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Citiprototype_v2
{
    [Register ("TableExampleClass")]
    partial class TableExampleClass
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView UserImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UserText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UserTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (UserImage != null) {
                UserImage.Dispose ();
                UserImage = null;
            }

            if (UserText != null) {
                UserText.Dispose ();
                UserText = null;
            }

            if (UserTitle != null) {
                UserTitle.Dispose ();
                UserTitle = null;
            }
        }
    }
}