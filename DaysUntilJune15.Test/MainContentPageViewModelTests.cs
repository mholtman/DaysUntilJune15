using NUnit.Framework;
using System;
using DaysUntilJune15;

namespace DaysUntilJune15.Test
{
	[TestFixture ()]
	public class MainContentPageViewModelTests
	{
		[Test ()]
		public void WhenModelCreatedThenDefaultTextIsPresent ()
		{
			var model = new MainContentPageViewModel ();
			Assert.AreEqual ("How long until the mobile app building contest ends?", model.MainText);
		}

		[Test ()]
		public void WhenCurrentDateMatchesEndDateThenContestOverTextIsComposed ()
		{
			var model = new MainContentPageViewModel ();
			Assert.AreEqual ("Contest is over! Blast off!", model.ComposeCountdownString (new DateTime (2015, 6, 15), new DateTime (2015, 6, 15)));
		}

		[Test ()]
		public void WhenCurrentDateLessThanEndDateThenCoutdownStringIsComposed ()
		{
			var model = new MainContentPageViewModel ();
			Assert.AreEqual ("1 days, 0 hours, 0 minutes, 0 seconds", model.ComposeCountdownString (new DateTime (2015, 6, 15), new DateTime (2015, 6, 14)));
		}

		[Test ()]
		public void GivenCurrentDateWithVariableMonthDayHourMinuteWhenCurrentDateLessThanEndDateThenCountdownStringIsCorrect ()
		{
			var model = new MainContentPageViewModel ();
			Assert.AreEqual ("2 days, 3 hours, 4 minutes, 5 seconds", model.ComposeCountdownString (new DateTime (2015, 6, 15), new DateTime (2015, 6, 12, 20, 55, 55)));
		}

		[Test ()]
		public void WhenCurrentDateGreaterThanEndDateThenContestOverTextIsDisplayed()
		{
			var model = new MainContentPageViewModel ();
			Assert.AreEqual ("Contest is over! Blast off!", model.ComposeCountdownString (new DateTime (2015, 6, 15), new DateTime (2015, 6, 16)));
		}


	}
}

