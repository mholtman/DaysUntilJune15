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
		public void WhenCurrentDateMatchesEndDateThenContestOverTextAppears ()
		{
			var model = new MainContentPageViewModel ();
			Assert.AreEqual ("Contest is over! Blast off!", model.ComposeCountdownString(new DateTime(2015,6,15), new DateTime(2015, 6,15)));
		}
	}
}

