using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace Bemyguide
{
	public class MainListViews : ContentPage
	{
		class Person
		{
			public Person(string name, DateTime birthday, Color favoriteColor, String age)
			{
				this.Name = name;
				this.Birthday = birthday;
				this.FavoriteColor = favoriteColor;
				this.Age = age;
			}

			public string Naame { private set; get; }
			public string Age { private set; get; }

			public DateTime Birthday { private set; get; }

			public Color FavoriteColor { private set; get; }
		};
		public MainListViews ()
		{
			// Define some data.
			List<Person> people = new List<Person>
			{
				new Person("Abigail", new DateTime(1975, 1, 15), Color.Aqua, "21"),
				new Person("Bob", new DateTime(1976, 2, 20), Color.Black, "23"),
				// ...etc.,...
				new Person("Yvonne", new DateTime(1987, 1, 10), Color.Purple, "80"),
				new Person("Zachary", new DateTime(1988, 2, 5), Color.Red, "34")
			};


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
