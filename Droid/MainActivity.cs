using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Bemyguide.Droid
{
	[Activity (Label = "Bemyguide.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}

        [assembly: Dependency(typeof(SQLite_Android))]
        // ...
        public class SQLite_Android : ISQLite
        {
            public SQLite_Android() { }
            public SQLite.SQLiteConnection GetConnection()
            {
                var sqliteFilename = "TodoSQLite.db3";
                string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
                var path = Path.Combine(documentsPath, sqliteFilename);
                // Create the connection
                var conn = new SQLite.SQLiteConnection(path);
                // Return the database connection
                return conn;
            }
        }
    }
}

