using System;
using System.Collections.Generic;

namespace Bemyguide
{
	public class People
	{
		public int userID;
		public string userName;
		public string password;
		public string Name;
		public string LastName;
		public string Address;
		public int zipCode;
		public int age;
		public int height;
		public string Pace;
		//0-3;3-5;5-7;7-10;10+;
		public int Distance;
		public bool blind;

		public People()
		{

		}
		public People (string userName, string Password)
		{
			//Create to DB Users;
		}
		public void SaveToDB ()
		{
			//Query to DB UserData;
		}
		public void GetByUserName (string userName)
		{
			//SQL Select by UserID join with UserData
			this.Name = "";
		}
		public List<People> Matches()
		{
			List<People> listOfGreatPeople = new List<People> ();

			return listOfGreatPeople;
		}
	}
}

