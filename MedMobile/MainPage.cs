using System;
using Xamarin.Forms;

namespace MedMobile
{
	class MainPage : ContentPage
	{
		public MainPage()
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
				Text = "Need assistance? \n Touch to connect to the pharmacy \n",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				VerticalOptions = LayoutOptions.Start
			};

			// Accomodate iPhone status bar.
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			// Build the page.
			this.Content = new StackLayout
			{
				Children = 
				{
					image,
					label1
				}
			};

		}
	}
}
