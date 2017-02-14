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
    [Register ("SignupController")]
    partial class SignupController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button_Login { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button_Signup { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Button_Login != null) {
                Button_Login.Dispose ();
                Button_Login = null;
            }

            if (Button_Signup != null) {
                Button_Signup.Dispose ();
                Button_Signup = null;
            }
        }
    }
}