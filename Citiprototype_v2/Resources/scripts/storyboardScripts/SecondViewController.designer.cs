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
    [Register ("SecondViewController")]
    partial class SecondViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginCompleteBackButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView LoginCompleteTextTest { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Citiprototype_v2.UITableProto TableProto { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LoginCompleteBackButton != null) {
                LoginCompleteBackButton.Dispose ();
                LoginCompleteBackButton = null;
            }

            if (LoginCompleteTextTest != null) {
                LoginCompleteTextTest.Dispose ();
                LoginCompleteTextTest = null;
            }

            if (TableProto != null) {
                TableProto.Dispose ();
                TableProto = null;
            }
        }
    }
}