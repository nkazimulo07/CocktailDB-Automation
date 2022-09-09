using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace Automation.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;
        public WebDriverWait Wait;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            CockTailDB.Init(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
