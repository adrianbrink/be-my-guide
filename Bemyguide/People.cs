using System;
using System.Collections.Generic;
using SQLite.Net;
using Xamarin.Forms;
using System.Linq;

namespace Bemyguide
{
	public class People
	{
		private SQLiteConnection _connection = DependencyService.Get<ISQLite>().GetConnection();
		private static SQLiteConnection con = DependencyService.Get<ISQLite>().GetConnection();

		public int userID{get;set;}
		public string userName{get;set;}
		public string password{get;set;}
		public string Name{get;set;}
		public string LastName{get;set;}
		public string Address{get;set;}
		public int zipCode{get;set;}
		public int age{get;set;}
		public int height{get;set;}
		public string Pace{get;set;}
		//0-3;3-5;5-7;7-10;10+;
		public int Distance{get;set;}
		public bool blind{get;set;}

		public People()
		{

		}
		public People(Users usr)
		{
			this.userID = usr.userID;
			this.userName = usr.userName;
			this.password = usr.password;
			this.Name = usr.Name;
			this.LastName = usr.LastName;
			this.Address = usr.Address;
			this.zipCode = usr.zipCode;
			this.age = usr.age;
			this.height = usr.height;
			this.Pace = usr.Pace;
			this.Distance = usr.Distance;
			this.blind = usr.blind;
		}
		public People (string userName, string Password)
		{			
			var users = from s in _connection.Table<Users>()
					where s.userName==userName
				select s;
			if (users.Count () != 0) {
				
			} else {
				this.userName =	userName;
				this.password = Password;
				this.blind = true;

				_connection.Insert (new Users (this));
				var query = _connection.Table<Users> ().Where(c=>c.userName == userName).FirstOrDefault();
				this.userID = query.userID;
			}
		}

		public void Update ()
		{
			var query = _connection.Table<Users> ().Where(c=>c.userName == this.userName).FirstOrDefault();
			if(query !=null)
			{
			query.update (this);
			_connection.Update (query);
		}
		}
		public List<People> Matches()
		{
			List<People> listOfGreatPeople = new List<People> ();
			var allUsers = (from s in _connection.Table<Users>()
					where s.blind!=this.blind && s.zipCode == this.zipCode
				select s).Take(10);
			foreach (var OkPerson in allUsers) {
				listOfGreatPeople.Add (new People (OkPerson));
			}
			return	listOfGreatPeople.OrderBy (x => Math.Abs (x.height - this.height)).ToList();

		}
		public static People GetByUserName (string userName)
		{
			var query = con.Table<Users> ().Where(c=>c.userName == userName).FirstOrDefault();
			return new People (query);
		}
		public static People Login(string userName, string Pswrd)
		{

			var query = con.Table<Users> ().Where(c=>c.userName == userName && c.password == Pswrd).FirstOrDefault();
			if (query != null)
				return new People (query);
			else
				return null; //throw exception
		}
	}
}

