using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PamplinApp.iOS
{
	partial class WelcomePage : UIViewController
	{

		UIViewController LoginPage;

		public WelcomePage (IntPtr handle) : base (handle)
		{
		}

		public override void AwakeFromNib ()
		{
			// Called when loaded from xib or storyboard.

			this.Initialize ();
		}

		public void Initialize(){

			//Instatiating View Controller with Storyboard ID 'LoginPage'
			LoginPage = Storyboard.InstantiateViewController ("LoginPage") as LoginPage;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//When we push the button, we will push the pinkViewController onto our current Navigation Stack
			PinkButton.TouchUpInside += (o, e) => {
				this.NavigationController.PushViewController (LoginPage, true);
			};
		}

	}
}
