using System;
using Xamarin.Forms;
using SQLite.Net;
using SQLite.Net.Attributes;
using System.Collections.Generic;

namespace Bemyguide
{
	public class App : Application
	{
		public static int ScreenWidth;
		public static int ScreenHeight;
		public static string userName = "";
		public  App ()

		{
			

		}
		public static Page getMainPage(){
			SQLiteConnection _connection = DependencyService.Get<ISQLite>().GetConnection();
			if (!TableExists("Users",_connection))
				_connection.CreateTable<Users> ();

			People guy = new People ("John", "John");
			People gal = new People ("Jill", "Jill");
			People thirdGuy = new People ("Peter", "Peter");
			guy = People.GetByUserName ("John");
			gal =  People.GetByUserName ("Jill");
			thirdGuy =  People.GetByUserName ("Peter");
			People fourth = new People ("Dean", "Dean");
			guy.Name = "Paul";
			guy.zipCode = 2100;
			guy.height = 175;
			guy.blind = true;
			guy.Update ();

			gal.Name = "Laura";
			gal.zipCode = 2100;
			gal.blind = false;
			gal.height = 162;
			gal.Update ();

			thirdGuy.Name = "Paul";
			thirdGuy.zipCode = 2200;
			thirdGuy.blind = false;
			thirdGuy.height = 175;
			thirdGuy.Update ();

			fourth.Name = "Dean";
			fourth.zipCode = 2100;
			fourth.blind = false;
			fourth.height = 175;
			fourth.Update ();

			List<People> allPeople = guy.Matches ();

			NavigationPage MP = new NavigationPage(new MainPage ());

			return MP;

		}
		public static bool TableExists (String tableName, SQLiteConnection connection)
		{
			SQLite.Net.SQLiteCommand cmd = connection.CreateCommand("SELECT * FROM sqlite_master WHERE type = 'table' AND name = '"+tableName+"'");
			//cmd.CommandText = ;
			if(cmd.ExecuteScalar<int>()== 0)
			{return false;}
				else
			{return true;}			
		}

	}
	[Table("Users")]
	public class Users {
		[PrimaryKey, AutoIncrement, Column("_id")]
		public int userID { get; set; }
		[Unique, Column("userName")]
		public string userName { get; set; }
		[Column("password")]
		public string password { get; set; }
		[Column("Name")]
		public string Name { get; set; }
		[Column("LastName")]
		public string LastName { get; set; }
		[Column("Address")]
		public string Address { get; set; }
		[Column("zipCode")]
		public int zipCode { get; set; }
		[Column("age")]
		public int age { get; set; }
		[Column("height")]
		public int height { get; set; }
		[Column("Pace")]
		public string Pace { get; set; }
		//0-3;3-5;5-7;7-10;10+;
		[Column("Distance")]
		public int Distance { get; set; }
		[Column("blind")]
		public bool blind { get; set; }
		[Column("City")]
		public string city{ get; set; }

		public Users(){
		}
		public Users(People person)
		{
			this.userName = person.userName;
			this.password = person.password;
			this.Name = person.Name;
			this.LastName = person.LastName;
			this.Address = person.Address;
			this.zipCode = person.zipCode;
			this.age = person.age;
			this.height = person.height;
			this.Pace = person.Pace;
			this.Distance = person.Distance;
			this.blind = person.blind;
			this.city = person.city;
		}
		public void update(People person)
		{
			if (person.userID != 0)
				this.userID = person.userID;
			this.userName = person.userName;
			this.password = person.password;
			this.Name = person.Name;
			this.LastName = person.LastName;
			this.Address = person.Address;
			this.zipCode = person.zipCode;
			this.age = person.age;
			this.height = person.height;
			this.Pace = person.Pace;
			this.Distance = person.Distance;
			this.blind = person.blind;
			this.city = person.city;
		}
	}
}

