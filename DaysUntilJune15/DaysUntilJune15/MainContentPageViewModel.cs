using System;
using System.Reactive.Linq;
using PropertyChanged;

namespace DaysUntilJune15
{
	//MVVM Design Pattern
	[ImplementPropertyChanged] //CodeWeaving/AOP
	public class MainContentPageViewModel
	{
		public string CountDown { get; set; }
		public string MainText { get; set; }

		private DateTime CONTEST_END_DATE = new DateTime(2015, 06, 15);
	
		public MainContentPageViewModel()
		{
			MainText = "How long until the mobile app building contest ends?";

		//Reactive Programming
		var timer = Observable.Interval(TimeSpan.FromSeconds(1));
			timer.Subscribe(tick =>
			{
				CountDown = ComposeCountdownString(CONTEST_END_DATE, DateTime.Now);
			});
		}

		public string ComposeCountdownString(DateTime endOfContestDate, DateTime currentDate)
		{
			var timeSpan = (endOfContestDate - currentDate);

			if (timeSpan.Days <= 0 && timeSpan.Hours <= 0 && timeSpan.Minutes <= 0 && timeSpan.Seconds == 0) {
				return "Contest is over! Blast off!";
			}

			return string.Format("{0} days, {1} hours, {2} minutes, {3} seconds", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
		}
	}
}