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
	[Register ("WelcomePage")]
	partial class WelcomePage
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton GetStarted { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView LogoDisplay { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView Welcome { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView WelcomeDescription { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (GetStarted != null) {
				GetStarted.Dispose ();
				GetStarted = null;
			}
			if (LogoDisplay != null) {
				LogoDisplay.Dispose ();
				LogoDisplay = null;
			}
			if (Welcome != null) {
				Welcome.Dispose ();
				Welcome = null;
			}
			if (WelcomeDescription != null) {
				WelcomeDescription.Dispose ();
				WelcomeDescription = null;
			}
		}
	}
}
