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
			

		}
		public static Page getMainPage(){
			//SQLiteConnection _connection = DependencyService.Get<ISQLite>().GetConnection();
			//_connection.CreateTable<TTable>();

			NavigationPage MP = new NavigationPage(new MainPage ());

			return MP;
		}


	}
}

