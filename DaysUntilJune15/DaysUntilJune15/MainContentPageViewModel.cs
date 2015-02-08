using System;
using System.Reactive.Linq;
using PropertyChanged;

namespace DaysUntilJune15
{
	//MVVM Design Pattern
	[ImplementPropertyChanged] //CodeWeaving/AOP
	public class MainContentPageViewModel
	{
//		public string CountDown { get; set; }
//
		public string MainText { get; set; }
//
//	
		public MainContentPageViewModel()
		{
			MainText = "How long until the mobile app building contest ends?";
//			
//		//Reactive Programming
//		var timer = Observable.Interval(TimeSpan.FromSeconds(1));
//			timer.Subscribe(tick =>
//			{
//				var timeSpan = (new DateTime(2015, 06, 15) - DateTime.Now);
//				CountDown = string.Format("{0} days, {1} hours, {2} minutes, {3} seconds", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
//			});
		}
	}
}