using System;
using Xamarin.Forms;

namespace Bemyguide
{
	public class RunnerProfile:ContentPage
	{
		public RunnerProfile ()
		{

			StackLayout lowerPart = new StackLayout () {
				BackgroundColor = Color.Black,
				WidthRequest = App.ScreenWidth,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					new Label{Text = "Do you want to run with Mette?", TextColor = Color.White, HorizontalOptions = LayoutOptions.CenterAndExpand},
					new StackLayout{
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
						Padding = new Thickness(23,23),
						Children = {new Button{Text = "No", BackgroundColor = Color.White,WidthRequest = App.ScreenWidth /3, TextColor = Color.Black}, new Button{Text = "Yes", BackgroundColor = Color.White, WidthRequest = App.ScreenWidth / 3, TextColor = Color.Black}}
					}
				}

			};

			Image test = new Image{Source = "screen_icon", HeightRequest = App.ScreenHeight * 0.55};

			StackLayout sl = new StackLayout () {
				Orientation = StackOrientation.Vertical,
				Children = {
					test,
					lowerPart,
					new Footer (){VerticalOptions = LayoutOptions.End}
				}
			};

				this.Content = sl;

		}
	}
}

