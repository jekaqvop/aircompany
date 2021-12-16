using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class BasePage
    {
        protected static IWebDriver driver;

        protected BasePage(IWebDriver WebDriver)
        {
            driver = WebDriver;
        }

        protected static IWebElement WaitForVisibilityOfElemen(IWebDriver driver, By webElement)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(webElement));
        }

        protected static IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }
        
    }
}
