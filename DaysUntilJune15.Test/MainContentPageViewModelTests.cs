using NUnit.Framework;
using System;
using DaysUntilJune15;

namespace DaysUntilJune15.Test
{
	[TestFixture ()]
	public class MainContentPageViewModelTests
	{
		[Test ()]
		public void ShouldHaveDefaultTextUponCreation ()
		{
			var model = new MainContentPageViewModel ();
			Assert.AreEqual ("How long until the mobile app building contest ends?", model.MainText);
		}
	}
}

