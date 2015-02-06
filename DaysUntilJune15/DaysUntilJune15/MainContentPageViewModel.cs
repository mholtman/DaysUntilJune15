using System;
using System.ComponentModel;
using System.Reactive.Linq;

namespace DaysUntilJune15
{
	public class MainContentPageViewModel : INotifyPropertyChanged
	{
		private string _countdown;
		public string CountDown
		{
			get { return _countdown; }
			set { _countdown = value; OnPropertyChanged("CountDown"); }
		}


		public MainContentPageViewModel()
		{
			var timer = Observable.Interval(TimeSpan.FromSeconds(1));
			timer.Subscribe(tick =>
			{
				var timeSpan = (new DateTime(2015, 06, 15) - DateTime.Now);
				CountDown = string.Format("{0} days, {1} hours, {2} minutes, {3} seconds", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
			});

		}



		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged == null)
				return;

			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}