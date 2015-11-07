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
			layout.Children.Add (new Label {
				Text = "Upload Foto",
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.White,

			});
			layout.Children.Add (new Entry {
				Placeholder = "Record Message",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black
			});
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

			var gender = new StackLayout{ Orientation = StackOrientation.Horizontal, Padding = new Thickness (5, 5) };
			gender.Children.Add (new Entry {
				Placeholder = "Male",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black,
				WidthRequest = App.ScreenWidth / 2
			});
			gender.Children.Add (new Entry {
				Placeholder = "Female",
				// Placeholder = Color.Black,
				HorizontalOptions = LayoutOptions.Center,
				//FontSize = 30,
				TextColor = Color.Black,
				WidthRequest = App.ScreenWidth / 2
			});

			layout.Children.Add (gender);

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

			this.Content = layout;
		}
	}
}

