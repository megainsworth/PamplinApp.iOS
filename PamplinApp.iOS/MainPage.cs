using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

using FlyoutNavigation;
using MonoTouch.Dialog;

namespace PamplinApp.iOS
{
	partial class MainPage : UIViewController
	{
		public MainPage (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			//Original Flyout Navigation Tutorial
		base.ViewDidLoad ();
		var navigation = new FlyoutNavigationController {	

				// Create the navigation menu


			NavigationRoot = new RootElement ("Navigation") {
				new Section ("Pages") {
						new StringElement ("Animals"),
					new StringElement ("Vegetables"),
					new StringElement ("Minerals"),
				}
				},
				// Supply view controllers corresponding to menu items:
			ViewControllers = new [] {
				new UIViewController { View = new UILabel { Text = "Animals (drag right)" } },
				new UIViewController { View = new UILabel { Text = "Vegetables (drag right)" } },
					new UIViewController { View = new UILabel { Text = "Minerals (drag right)" } },
			},
			};
		// Show the navigation view
			navigation.ToggleMenu ();
			View.AddSubview (navigation.View);

//			Add menu indicator icon
//			UIBarButtonItem menuIndicator = new UIBarButtonItem (UIImage.FromBundle   ("images/slideout.png"), UIBarButtonItemStyle.Plain, (sender, e) => {
//				navigation.ToggleMenu ();
//			});
//			NavigationItem.SetLeftBarButtonItem (menuIndicator, false);


		}
	}
}
