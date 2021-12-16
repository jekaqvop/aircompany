using AvatradeTests.Model;
using AvatradeTests.Utils;
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
            Log.Info("Open home Page");
            return this;
        }

        public LoginPage ClickInLoginCabinet()
        {
            WaitForVisibilityOfElemen(driver, btnInLoginCabinet).Click();
            Log.Info("Click In Login Cabinet");
            return this;
        }

        public LoginPage EnterLoginAndPassword(User user)
        {
            WaitForVisibilityOfElemen(driver, txtLogin).SendKeys(user.TradingAccount);            
            WaitForVisibilityOfElemen(driver, txtPassword).SendKeys(user.Password);
            Log.Info("Enter Password and login");
            return this;
        }      

        public SelectAccountPage SignIn()
        {
            WaitForVisibilityOfElemen(driver, btnLogin).Click();
            Log.Info("Click button SingIn");
            return new SelectAccountPage(driver);
        }
    }
}
