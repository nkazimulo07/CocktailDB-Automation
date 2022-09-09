using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

		public IWebElement searchBox => driver.FindElement(By.CssSelector(".form-control"));
		public IWebElement cocktail => driver.FindElement(By.CssSelector(".row:nth-child(2) > .col-sm-3:nth-child(1) img"));
		public IWebElement searchButton => driver.FindElement(By.CssSelector(".btn"));
		public IWebElement cocktailName => driver.FindElement(By.CssSelector("#feature > div > div > table > tbody > tr:nth-child(1) > td:nth-child(1) > h2"));
		public IWebElement ingredientLabel => driver.FindElement(By.CssSelector("#feature > div > div > table > tbody > tr:nth-child(1) > td:nth-child(2) > h2"));
		public IWebElement letter => driver.FindElement(By.LinkText("G"));
		public IWebElement NoDrinksLabel => driver.FindElement(By.CssSelector("#feature > div > div > div.row"));
		public IWebElement aboutLink => driver.FindElement(By.CssSelector("#footer > div > div > div:nth-child(3) > ul > li:nth-child(2) > a"));
		
		public IWebElement browseCocktailsLabel => driver.FindElement(By.CssSelector("#feature > div > div > h1"));
	}
}
