using System;
using Xamarin.Forms;
namespace Bemyguide
{
	public class MainPage: ContentPage
	{
		public MainPage ()
		{
			this.BackgroundColor = Color.Black;

			Entry userName = new Entry { Placeholder = "Username", HeightRequest = 70 };
			Entry password = new Entry {
				Placeholder = "Password",
				HeightRequest = 70,
				IsPassword = true
			};
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
							userName,
							password,
							new Button () {
								Text = "Register",
								TextColor = Color.White,
								FontSize = 22,
								Command = new Command (() => this.Navigation.PushAsync(new SettingsView()))

							},
							new Button () {
								Text = "Login",
								TextColor = Color.White,
								FontSize = 22,
								//Command = new Command (() => this.Navigation.PushAsync(new MainListViews())) 
							}
						}
					}

				}
			};

			Content = sl;
		}

	}
}
