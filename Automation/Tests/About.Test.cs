using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Tests
{
    public class About: BaseTest
    {
		[Test]
		public void GivenABoutLink_WhenBrowsing_ThenReturnABoutPage()
		{
			CockTailDB.HomePage.aboutLink.Click();
			Assert.IsTrue(CockTailDB.AboutPage.aboutLabel.Displayed);
		}
	}
}
