using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Automation
{
    public class BasePage
    {
        public IWebDriver driver;
        protected IWebElement PageRoot => driver.FindElement(By.Id("#feature"));
        public WebDriverWait Wait;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
    
}
