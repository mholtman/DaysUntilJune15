using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace DaysUntilJune15
{
	public class RandomGifPage : ContentPage
	{
		readonly Image image;

		public RandomGifPage()
		{
			
			image = new Image()
			{
				Aspect = Aspect.Fill,
				HeightRequest = 300,
				WidthRequest = 300
			};

			var button = new Button()
			{
				Text = "Ok, that's funny....back to work",
				Command = new Command(() =>
				{
					Application.Current.MainPage.Navigation.PopModalAsync();
				})
			};


			Content = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children =
				{
					image,
					button
				}
			};
		}

		//async programming
		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var httpClient = new HttpClient();
			//This API seems to return the same image for a given time.
			var response = await httpClient.GetAsync("http://api.giphy.com/v1/gifs/random?rating=pg&api_key=dc6zaTOxFJmzC"); 
			var apiResponse = await response.Content.ReadAsStringAsync();
			var apiObject = JsonConvert.DeserializeAnonymousType(apiResponse, new { data = new { image_url = "" }});
			var imageUrl = apiObject.data.image_url;
			image.Source = imageUrl;
		}
	}
}