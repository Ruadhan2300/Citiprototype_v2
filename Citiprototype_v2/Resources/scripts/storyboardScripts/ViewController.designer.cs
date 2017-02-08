// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Citiprototype_v2
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button_next { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginBackButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LoginEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginHelpButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LoginPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextInputTest { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (button_next != null) {
                button_next.Dispose ();
                button_next = null;
            }

            if (LoginBackButton != null) {
                LoginBackButton.Dispose ();
                LoginBackButton = null;
            }

            if (LoginButton != null) {
                LoginButton.Dispose ();
                LoginButton = null;
            }

            if (LoginEmail != null) {
                LoginEmail.Dispose ();
                LoginEmail = null;
            }

            if (LoginHelpButton != null) {
                LoginHelpButton.Dispose ();
                LoginHelpButton = null;
            }

            if (LoginPassword != null) {
                LoginPassword.Dispose ();
                LoginPassword = null;
            }

            if (TextInputTest != null) {
                TextInputTest.Dispose ();
                TextInputTest = null;
            }
        }
    }
}