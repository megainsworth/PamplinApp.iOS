
using System;
using System.Linq;
using System.Collections.Generic;

using MonoTouch.Dialog;

using Foundation;
using UIKit;

namespace PamplinApp.iOS
{
	public partial class FlyoutNavigation : DialogViewController
	{
		public FlyoutNavigation () : base (UITableViewStyle.Grouped, null)
		{
			Root = new RootElement ("FlyoutNavigation") {
				new Section ("First Section") {
					new StringElement ("Hello", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section") {
				},
			};
		}
	}
}
