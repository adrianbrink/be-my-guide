using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Bemyguide.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}

        [assembly: Dependency(typeof(SQLite_iOS))]
        // ...
        public class SQLite_iOS : ISQLite
        {
            public SQLite_iOS() { }
            public SQLite.SQLiteConnection GetConnection()
            {
                var sqliteFilename = "TodoSQLite.db3";
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
                string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
                var path = Path.Combine(libraryPath, sqliteFilename);
                // Create the connection
                var conn = new SQLite.SQLiteConnection(path);
                // Return the database connection
                return conn;
            }
        }
    }
}

