using Automation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public class CockTailDB
    {
        public static HomePage HomePage;
        public static AboutPage AboutPage;
        public const string Url = "https://www.thecocktaildb.com/";
        public static void Init(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            HomePage = new HomePage(driver);
            AboutPage  = new AboutPage(driver);
        }
    }
}
