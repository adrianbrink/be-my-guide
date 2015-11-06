using System;
using Xamarin.Forms;
using SQLite.Net;

namespace Bemyguide
{
	public class App : Application
	{
        private SQLiteConnection database;

        public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};
			AppDatabase ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public interface ISQLite
        {
            SQLiteConnection GetConnection();
        }

        public void AppDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            //database.CreateTable<users>();
        }
	}
}

