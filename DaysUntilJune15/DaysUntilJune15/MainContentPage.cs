using Xamarin.Forms;

namespace DaysUntilJune15
{
	class MainContentPage : ContentPage
	{
		public MainContentPage()
		{

			var timeLable = new Label();


			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					new Label
					{
						XAlign = TextAlignment.Center,
						Text = "How long until the contest ends?"
					},
					timeLable
				}
			};

		}

	}
}
