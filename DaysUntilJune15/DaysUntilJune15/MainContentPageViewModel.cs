using System;
using System.Reactive.Linq;
using System.Windows.Input;
using PropertyChanged;
using Xamarin.Forms;

namespace DaysUntilJune15
{
	//MVVM Design Pattern
	[ImplementPropertyChanged] //CodeWeaving/AOP
	public class MainContentPageViewModel
	{
		public string CountDown { get; set; }

		public string MainText { get; set; }

		public string ButtonText { get; set; }

		public ICommand RandomGifCommand { get; set; }

		public MainContentPageViewModel()
		{
			MainText = "How long until the mobile app building contest ends?";

			ButtonText = "Show me a random gif?";

			

		//Reactive Programming
		var timer = Observable.Interval(TimeSpan.FromSeconds(1));
			timer.Subscribe(tick =>
			{
				var timeSpan = (new DateTime(2015, 06, 15) - DateTime.Now);
				CountDown = string.Format("{0} days, {1} hours, {2} minutes, {3} seconds", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
			});

			RandomGifCommand = new Command(() =>
			{
				Application.Current.MainPage.Navigation.PushModalAsync(new RandomGifPage());
			});
		}
	}
}