using System;
using Xamarin.Forms;

namespace MedMobile
{
	class WelcomePage : ContentPage
	{
		public WelcomePage()
		{
			Image image = new Image
			{
				// Some differences with loading images in initial release.
				Source =
					Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
						ImageSource.FromFile("header_image.png"),
						ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png"))),

				VerticalOptions = LayoutOptions.Start
			};

			Label label1 = new Label
			{
				Text = "This app keeps a secure local copy of all the info you use to order prescriptions.",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				VerticalOptions = LayoutOptions.Start
			};

			Label label2 = new Label
			{
				Text = "When you receive a prescription, simply take a picture of it using your phone’s camera and hit the submit button to send all the info to your pharmacy",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				VerticalOptions = LayoutOptions.Start
			};
			//
			Button button = new Button
			{
				Text = "Get Started Now",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += async (sender, args) =>
				await Navigation.PushModalAsync(new MainPage());

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = new StackLayout
			{
				Children = 
				{
					image,
					label1,
					label2,
					button
				}
			};
		}
	}

	public class App
	{
		public static Page GetMainPage ()
		{	
			ContentPage tmpContentPage = new WelcomePage ();
			return tmpContentPage;

			return new ContentPage { 
				Content = new Label {
					Text = "Hello, Forms!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}

