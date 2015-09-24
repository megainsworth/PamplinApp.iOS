using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PamplinApp.iOS
{
	public partial class WelcomePage : UIViewController
	{
		//UIViewController LoginPage;

		public WelcomePage (IntPtr handle) : base (handle)
		{

		}

		/*public override void AwakeFromNib ()
		{
			// Called when loaded from xib or storyboard.

			this.Initialize ();
		}
		*/

		/*public void Initialize(){

			//Instatiating View Controller with Storyboard ID 'loginPage'
			LoginPage = Storyboard.InstantiateViewController ("loginPage") as loginPage;
		}
		*/

		/*public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//When we push the button, we will push the LoginPage onto our current Navigation Stack

			GetStarted.TouchUpInside += (o, e) => {
				this.NavigationController.PushViewController (LoginPage, true);
			};
		}
		*/
	}
}
