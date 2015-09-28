using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PamplinApp.iOS
{


	public partial class MainViewController : UIViewController
	{
		//UIViewController loginPage;


		public MainViewController (IntPtr handle) : base (handle)
		{
		}

		/* public override void AwakeFromNib ()
		{
			// Called when loaded from xib or storyboard.

			this.Initialize ();
		}
		*/

		/*public void Initialize(){

			//Instatiating View Controller with Storyboard ID 'LoginPage'
			loginPage = Storyboard.InstantiateViewController ("LoginPage") as LoginPage;
		}
		*/
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

		}
		
//	public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
//		{
//			base.PrepareForSegue (segue, sender);
//
//			// set the View Controller that’s powering the screen we’re
//			// transitioning to
//
//			var loginPage = segue.DestinationViewController as LoginPage;
//			
//		}

		

	}
}
