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

namespace PamplinApp.iOS
{
	[Register ("LoginPage")]
	partial class LoginPage
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField AccessCodeInput { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel AccessCodeLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Continue { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView LogoDisplay2 { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AccessCodeInput != null) {
				AccessCodeInput.Dispose ();
				AccessCodeInput = null;
			}
			if (AccessCodeLabel != null) {
				AccessCodeLabel.Dispose ();
				AccessCodeLabel = null;
			}
			if (Continue != null) {
				Continue.Dispose ();
				Continue = null;
			}
			if (LogoDisplay2 != null) {
				LogoDisplay2.Dispose ();
				LogoDisplay2 = null;
			}
		}
	}
}
