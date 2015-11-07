using System;
using Xamarin.Forms;

namespace Bemyguide
{
	public class SettingsView : ContentPage
	{
		private Entry userName  { get;set;}
		private Entry password { get;set;}
		private Entry name { get;set;} 
		private Entry lastName { get;set;}
		private Entry Height { get;set;}
		private Entry Age { get;set;}
		private Entry Address1 { get;set;}
		private Entry Address2 { get;set;}
		private Entry Zip { get;set;}
		private Entry City { get;set;}
		public SettingsView ()
		{
			this.BackgroundColor = Color.Black;
			var layout = new StackLayout{ Padding = new Thickness (5, 10) };
			this.Title = "Settings";
			Entry userName = createNewEntry ("UserName");
			Entry password=  createNewEntry("Password");
			password.IsPassword= true;
			Entry name = createNewEntry ("First Name"); 
			Entry lastName = createNewEntry ("Last Name");
			Entry Height = createNewEntry ("Height");
			Entry Age = createNewEntry ("Age");
			Entry Address1 = createNewEntry ("Address Line 1");
			Entry Address2 = createNewEntry ("Address Line 2");
			Entry Zip  = createNewEntry ("Postal code");
			Entry City = createNewEntry ("City");
			layout.Children.Add (userName);
			layout.Children.Add (password);
			layout.Children.Add (name);
			layout.Children.Add (lastName);
			layout.Children.Add (Height);

			layout.Children.Add (Age);
			layout.Children.Add (Address1);
			layout.Children.Add (Address2);

			layout.Children.Add (Zip);
			layout.Children.Add (City);


			layout.Children.Add (new Button (){ Text = "Register", Command = new Command(() => buttonPress()) });
			this.Content = layout;
		}
		public Entry createNewEntry(string plcholderName)
		{
			Entry entr = new Entry (){
				Placeholder = plcholderName,
				HorizontalOptions = LayoutOptions.Center,
				TextColor =  Color.Black };
			return entr;
		}
		public void buttonPress()
		{
			People mainGuy = new People (userName.Text, password.Text);
			mainGuy.Name = name.Text;
			mainGuy.age = Convert.ToInt32(Age.Text);
			mainGuy.LastName = lastName.Text;
			mainGuy.height = Convert.ToInt32(Height.Text);
			mainGuy.Address = Address1.Text + " " + Address2.Text; 
			mainGuy.city = City.Text;
			App.userName = mainGuy.userName;
			this.Navigation.PushAsync (new GuidePageView ());
		}
	}
}

