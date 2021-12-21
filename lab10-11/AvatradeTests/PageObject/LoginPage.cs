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

        private static readonly string HOMEPAGE_URL = "https://cabinet.ifxglobe.com/client/ru/login";
        
        private readonly By txtLogin = By.XPath("//input[@ng-model='login']");
        private readonly By txtPassword = By.XPath("//input[@ng-model='pass']");
        private readonly By btnLogin = By.XPath("//button[@class='btn btn-main btn-form']");
        
        public LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(HOMEPAGE_URL);
            Log.Info("Open home Page");
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
