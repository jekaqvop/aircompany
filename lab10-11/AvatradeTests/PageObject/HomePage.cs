using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver) { }

        private static readonly string HOMEPAGE_URL = "https://www.ifxglobe.com/ru/";
        private readonly By btnLastCircle = By.XPath("/html/body/div[9]/div[2]/div[2]/div/div[6]");
        private readonly By btnOpenLogin = By.XPath("/html/body/div[9]/div[2]/div[2]/div/div[6]");

        public HomePage OpenPage()
        {
            driver.Navigate().GoToUrl(HOMEPAGE_URL);
            Log.Info("Open home Page");
            return this;
        }

        public LoginPage OpenLoginPage()
        {
            WaitForVisibilityOfElemen(driver, btnLastCircle).Click();
            WaitForVisibilityOfElemen(driver, btnOpenLogin).Click();
            Log.Info("Open login Page");
            return new LoginPage(driver);
        }
    }
}
