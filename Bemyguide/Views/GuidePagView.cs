using System;
using Xamarin.Forms;

namespace Bemyguide
{
	public class GuidePagView : ContentPage
	{
		public GuidePagView ()
		{
			this.BackgroundColor = Color.Black;

			var layout = new StackLayout{ Padding = new Thickness (5, 10) };
			this.Title = "Help Page";
			layout.Children.Add (new Label {
				Text = "This will contain some helpful information.",
				FontSize = 30,
				TextColor = Color.White
			});

			var browser = new WebView ();
			var htmlSource = new HtmlWebViewSource ();
			htmlSource.Html = @"<iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/Y7bxlR-MxxM"" frameborder=""0"" allowfullscreen></iframe>";
			browser.Source = htmlSource;
			browser.HeightRequest = 315.0;
			browser.WidthRequest = 560.0;

			layout.Children.Add (browser);

			this.Content = layout;
		}
	}
}

