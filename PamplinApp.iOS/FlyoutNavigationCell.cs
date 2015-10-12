
using System;

using Foundation;
using UIKit;

namespace PamplinApp.iOS
{
	public class FlyoutNavigationCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("FlyoutNavigationCell");

		public FlyoutNavigationCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "TextLabel";
		}
	}
}

