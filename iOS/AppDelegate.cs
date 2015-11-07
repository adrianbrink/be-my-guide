using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Foundation;
using UIKit;
using Xamarin.Forms;



namespace Bemyguide.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;
			App.ScreenHeight = (int)UIScreen.MainScreen.Bounds.Height;
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			window = new UIWindow (UIScreen.MainScreen.Bounds);

			window.RootViewController = App.getMainPage ().CreateViewController();
			window.MakeKeyAndVisible ();

			return true;

		}
			
       
    }
}

