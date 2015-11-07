using System;
using Xamarin.Forms;
namespace Bemyguide
{
	public class MainPage: ContentPage
	{
		public MainPage ()
		{
			this.BackgroundColor = Color.Black;


			StackLayout sl = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						TextColor = Color.White,
						FontSize = 40,
						Text = "BE MY GUIDE"
					},
					new StackLayout () {
						VerticalOptions = LayoutOptions.Center,
						Padding = 50,
						Spacing = 10,
						Children = {
							new Entry { Placeholder = "Username", HeightRequest = 70 },
							new Entry {
								Placeholder = "Password",
								HeightRequest = 70,
								IsPassword = true
							},
							new Button () {
								Text = "Register",
								TextColor = Color.White,
								FontSize = 22,
								Command = new Command (() => this.Navigation.PushAsync(new GuidePagView()))

							},
							new Button () {
								Text = "Login",
								TextColor = Color.White,
								FontSize = 22,
								Command = new Command (() => this.Navigation.PushAsync(new MainListViews())) 

							}


						}
					}

				}
			};

			Content = sl;
		}

	}
}
