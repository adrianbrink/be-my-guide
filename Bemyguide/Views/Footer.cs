using System;
using Xamarin.Forms;

namespace Bemyguide
{
	public class Footer : StackLayout
	{
		public Footer ()
		{
			
		
			this.Orientation = StackOrientation.Horizontal;
			this.BackgroundColor = Color.Black;
			this.VerticalOptions = LayoutOptions.End;
		
			var button = new Image {Source = "matches_icon2", WidthRequest = App.ScreenWidth / 4 ,HorizontalOptions = LayoutOptions.CenterAndExpand}; // make your image your button should be
			button.GestureRecognizers.Add (new TapGestureRecognizer (sender => {
				// Do whatever you want to do when its tapped
				button.Opacity = 0.6;
				button.FadeTo (1);
			}));

			this.Children.Add (button);

			var button2 = new Image {Source = "runner_icon2" , WidthRequest = App.ScreenWidth / 4 ,HorizontalOptions = LayoutOptions.CenterAndExpand}; // make your image your button should be
			button2.GestureRecognizers.Add (new TapGestureRecognizer (sender => {
				// Do whatever you want to do when its tapped
				button2.Opacity = 0.6;
				button2.FadeTo (1);
			}));
			this.Children.Add (button2);

			var button3 = new Image {Source = "settings_icon2" , WidthRequest = App.ScreenWidth / 4 ,HorizontalOptions = LayoutOptions.CenterAndExpand}; // make your image your button should be
			button3.GestureRecognizers.Add (new TapGestureRecognizer (sender => {
				// Do whatever you want to do when its tapped
				button3.Opacity = 0.6;
				button3.FadeTo (1);
			}));
			this.Children.Add (button3);

			var button4 = new Image {Source = "guide_icon2", WidthRequest = App.ScreenWidth / 4 ,HorizontalOptions = LayoutOptions.CenterAndExpand}; // make your image your button should be
			button4.GestureRecognizers.Add (new TapGestureRecognizer (sender => {
				// Do whatever you want to do when its tapped
				button4.Opacity = 0.6;
				button4.FadeTo (1);
			}));
			this.Children.Add (button4);

		}
	}
}

