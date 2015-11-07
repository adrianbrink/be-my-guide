using System;
using Xamarin.Forms;

namespace Bemyguide
{
	public class SettingsView : ContentPage
	{
		public SettingsView ()
		{
			this.BackgroundColor = Color.Black;
			var layout = new StackLayout{ Padding = new Thickness (5, 10) };
			this.Title = "Settings";
		

			layout.Children.Add (new Entry {
				Placeholder = "First Name",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});
			layout.Children.Add (new Entry {
				Placeholder = "Last Name",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});



			layout.Children.Add (new Entry {
				Placeholder = "Height",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});
			layout.Children.Add (new Entry {
				Placeholder = "Age",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});
			layout.Children.Add (new Entry {
				Placeholder = "Address Line 1",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});
			layout.Children.Add (new Entry {
				Placeholder = "Address Line 2",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});
			layout.Children.Add (new Entry {
				Placeholder = "Postal Code",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});
			layout.Children.Add (new Entry {
				Placeholder = "City",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});



			layout.Children.Add (new Button (){ Text = "Register", Command = new Command(() => this.Navigation.PushAsync(new GuidePageView())) });
			this.Content = layout;
		}
	}
}

