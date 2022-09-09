using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Pages
{
    public class AboutPage:BasePage
    {
        public AboutPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement aboutLabel => driver.FindElement(By.CssSelector("#feature > div > b:nth-child(1)"));
    }
}
