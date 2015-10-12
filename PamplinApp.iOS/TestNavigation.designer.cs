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
	[Register ("TestNavigation")]
	partial class TestNavigation
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView TableView1 { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TableView1 != null) {
				TableView1.Dispose ();
				TableView1 = null;
			}
		}
	}
}
