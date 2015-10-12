using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Collections.Generic;

using FlyoutNavigation;

#if __UNIFIED__
using UIKit;
using Foundation;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif
using MonoTouch.Dialog;

namespace PamplinApp.iOS
{
	partial class MainPage : UIViewController
	{
		FlyoutNavigationController navigation;
		        
		        // Data we'll use to create our flyout menu and views:
		        string[] Tasks = {
			            "Get Xamarin",
			            "Learn C#",
			            "Write Killer App",
			            "Add Platforms",
			            "Profit",
			            "Meet Obama",
			        };
		public MainPage (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{

			base.ViewDidLoad ();

			            // Create the flyout view controller, make it large,
			            // and add it as a subview:
			            navigation = new FlyoutNavigationController ();
			            navigation.Position = FlyOutNavigationPosition.Left;
			            navigation.View.Frame = UIScreen.MainScreen.Bounds;
			            View.AddSubview (navigation.View);
			            this.AddChildViewController (navigation);
			            
			            // Create the menu:
			            navigation.NavigationRoot = new RootElement ("Task List") {
				                new Section ("Task List") {
					                    from page in Tasks
					                        select new StringElement (page) as Element
					                }
				            };
			            
			            // Create an array of UINavigationControllers that correspond to your
			            // menu items:
			            navigation.ViewControllers = Array.ConvertAll (Tasks, title =>
				                   new UINavigationController (new TaskPageController (navigation, title))
				            );
			        }
		        
		        class TaskPageController : DialogViewController
		        {
			            public TaskPageController (FlyoutNavigationController navigation, string title) : base (null)
			            {
				                Root = new RootElement (title) {
					                    new Section {
						                        new CheckboxElement (title)
						                    }
					                };
				                NavigationItem.LeftBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Action, delegate {
					                    navigation.ToggleMenu ();
					                });
				            }
			        }
		    }
}

			//Original Flyout Navigation Tutorial
//		base.ViewDidLoad ();
//		var navigation = new FlyoutNavigationController {	

				// Create the navigation menu


//			NavigationRoot = new RootElement ("Navigation") {
//				new Section ("Pages") {
//						new StringElement ("Animals"),
//					new StringElement ("Vegetables"),
//					new StringElement ("Minerals"),
//				}
//				},
				// Supply view controllers corresponding to menu items:
//			ViewControllers = new [] {
//				new UIViewController { View = new UILabel { Text = "Animals (drag right)" } },
//				new UIViewController { View = new UILabel { Text = "Vegetables (drag right)" } },
//					new UIViewController { View = new UILabel { Text = "Minerals (drag right)" } },
//			},
//			};
		// Show the navigation view
//			navigation.ToggleMenu ();
//			View.AddSubview (navigation.View);

//			Add menu indicator icon
//			UIBarButtonItem menuIndicator = new UIBarButtonItem (UIImage.FromBundle   ("images/slideout.png"), UIBarButtonItemStyle.Plain, (sender, e) => {
//				navigation.ToggleMenu ();
//			});
//			NavigationItem.SetLeftBarButtonItem (menuIndicator, false);


		
	

