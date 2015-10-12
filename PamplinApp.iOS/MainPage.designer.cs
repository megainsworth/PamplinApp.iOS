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
	[Register ("MainPage")]
	partial class MainPage
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel AlertsLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView AlertsListBox { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIScrollView AlertsScrollView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel MainPageLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView MainPageLogo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel SuggestionsLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AlertsLabel != null) {
				AlertsLabel.Dispose ();
				AlertsLabel = null;
			}
			if (AlertsListBox != null) {
				AlertsListBox.Dispose ();
				AlertsListBox = null;
			}
			if (AlertsScrollView != null) {
				AlertsScrollView.Dispose ();
				AlertsScrollView = null;
			}
			if (MainPageLabel != null) {
				MainPageLabel.Dispose ();
				MainPageLabel = null;
			}
			if (MainPageLogo != null) {
				MainPageLogo.Dispose ();
				MainPageLogo = null;
			}
			if (SuggestionsLabel != null) {
				SuggestionsLabel.Dispose ();
				SuggestionsLabel = null;
			}
		}
	}
}
