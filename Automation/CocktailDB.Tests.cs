using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
   [TestFixture]
    public class CocktailDB
    {
        private IWebDriver driver;
        private WebDriverWait Wait;
        private const string Url = "https://www.thecocktaildb.com/";

        private IWebElement searchBox => driver.FindElement(By.CssSelector(".form-control"));
        private IWebElement cocktail => driver.FindElement(By.CssSelector(".row:nth-child(2) > .col-sm-3:nth-child(1) img"));
        private IWebElement searchButton => driver.FindElement(By.CssSelector(".btn"));
        private IWebElement cocktailName => driver.FindElement(By.CssSelector("#feature > div > div > table > tbody > tr:nth-child(1) > td:nth-child(1) > h2"));
        private IWebElement ingredientLabel => driver.FindElement(By.CssSelector("#feature > div > div > table > tbody > tr:nth-child(1) > td:nth-child(2) > h2"));
        private IWebElement letter => driver.FindElement(By.LinkText("G"));
        private IWebElement NoDrinksLabel => driver.FindElement(By.CssSelector("#feature > div > div > div.row"));


[SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

        }

        [Test]
        public void GivenExistingIngredientName_WhenSeaching_ThenReturnsIngredient()
        {
            searchBox.Click();
            searchBox.SendKeys("Vodka");
            searchButton.Click();
            Assert.IsTrue(cocktail.Displayed);

            cocktail.Click();
            Assert.IsTrue(cocktailName.Text.Equals("Vodka"));
            Assert.IsTrue(ingredientLabel.Text.Equals("Drinks"));
        }

        [Test]
        public void GivenExistingCocktailName_WhenSeaching_ThenReturnsCocktail()
        {
            searchBox.Click();
            searchBox.SendKeys("Old Fashioned");
            searchButton.Click();
            Assert.IsTrue(cocktail.Displayed);

            cocktail.Click();
            Assert.IsTrue(cocktailName.Text.Equals("Old Fashioned"));
            Assert.IsTrue(ingredientLabel.Text.Equals("Ingredients"));
        }

        [Test]
        public void GivenALetter_WhenBrowsing_ThenReturnsCocktail()
        {
            searchBox.Click();
            letter.Click();
            Assert.IsTrue(cocktail.Displayed);
        }

        [Test]
        public void GivenIvalidName_WhenSeaching_ThenReturnsIngredientNodrinks()
        {
            searchBox.Click();
            searchBox.SendKeys("test");
            searchButton.Click();
            Assert.IsTrue(NoDrinksLabel.Text.Equals("No drinks found"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }

    }
}
