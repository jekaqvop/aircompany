using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver) { }

        private static readonly string HOMEPAGE_URL = "https://www.ifxglobe.com/ru/";
        private readonly By btnInLoginCabinet = By.XPath("//*[@id='ntoolbar']/div[7]/button");
        private readonly By txtLogin = By.XPath("//*[@id='login']");
        private readonly By txtPassword = By.XPath("//*[@id='pass']");
        private readonly By btnLogin = By.XPath("//*[@id='client_form_auth']/div/div[1]/div[3]/button[2]");
        
        public LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(HOMEPAGE_URL);
            return this;
        }

        public LoginPage ClickInLoginCabinet()
        {
            WaitForVisibilityOfElemen(driver, btnInLoginCabinet).Click();
            return this;
        }

        public LoginPage EnterLogin(string login)
        {
            WaitForVisibilityOfElemen(driver, txtLogin).SendKeys(login);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            WaitForVisibilityOfElemen(driver, txtPassword).SendKeys(password);
            return this;
        }

        public SelectAccountPage SignIn()
        {
            WaitForVisibilityOfElemen(driver, btnLogin).Click();
            return new SelectAccountPage(driver);
        }
    }
}
