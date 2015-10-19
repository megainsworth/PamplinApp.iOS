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
	[Register ("EventsListPage")]
	partial class EventsListPage
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel EventListLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView EventsDetailBG { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel EventsListHeader { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel EventsTitle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView EventTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (EventListLabel != null) {
				EventListLabel.Dispose ();
				EventListLabel = null;
			}
			if (EventsDetailBG != null) {
				EventsDetailBG.Dispose ();
				EventsDetailBG = null;
			}
			if (EventsListHeader != null) {
				EventsListHeader.Dispose ();
				EventsListHeader = null;
			}
			if (EventsTitle != null) {
				EventsTitle.Dispose ();
				EventsTitle = null;
			}
			if (EventTable != null) {
				EventTable.Dispose ();
				EventTable = null;
			}
		}
	}
}
