using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace Bemyguide
{
	public class MainListViews : ContentPage
	{
		public MainListViews ()
		{
			People mainGuy = People.GetByUserName (App.userName);
			// Define some data.
			List<People> people = mainGuy.Matches();


			ListView listView = new ListView
			{

				// Source of data items.
				ItemsSource = people,
				BackgroundColor = Color.Black,
				// Define template for displaying each item.
				// (Argument of DataTemplate constructor is called for 
				//      each item; it must return a Cell derivative.)
				ItemTemplate = new DataTemplate(() =>
					{

						BackgroundColor = Color.Black;
						// Create views with bindings for displaying each property.
						Label nameLabel = new Label(){TextColor = Color.White,FontSize = 20, HorizontalOptions = LayoutOptions.CenterAndExpand};
						nameLabel.SetBinding(Label.TextProperty, "Name");

						Label ageLabel = new Label(){HorizontalOptions = LayoutOptions.End, TextColor = Color.White,FontSize = 20, FontAttributes = FontAttributes.Bold};
						ageLabel.SetBinding(Label.TextProperty, "Age");

						BoxView boxView = new BoxView();
						boxView.SetBinding(BoxView.ColorProperty, "FavoriteColor");

						// Return an assembled ViewCell.

						return new ViewCell
						{
							View = new StackLayout
							{
								Padding = new Thickness(0, 5),
								Orientation = StackOrientation.Horizontal,
								Children = 
								{
									boxView,
									nameLabel,
									ageLabel
								}
								}
						};
					})
			};

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = new StackLayout
			{
				Children = 
				{
					listView
				}
				};
		}
	}
}
