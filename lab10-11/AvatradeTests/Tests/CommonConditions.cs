using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using AvatradeTests.Driver;
using AvatradeTests.Model;
using AvatradeTests.PageObject;
using AvatradeTests.Service;
using AvatradeTests.Utils;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests.Tests
{
    class CommonConditions
    {
        protected IWebDriver driver;
        protected SelectAccountPage selectAccountPage;
        protected ReplenishmentDemoAccountPage replenishmentDemoAccountPage;
        protected AccountManagementPage accountManagementPage;
        protected TraderCalculatorPage traderCalculatorPage;
        protected TradingPage tradingPage;
        protected PersonalInformation personalInformation;

        [SetUp]
        public void StartPageSetup()
        {
            User testUser = CreatorUser.WithCredentialsFromProperty();
            driver = DriverManager.GetWebDriver();
            selectAccountPage = new LoginPage(driver).OpenPage().EnterLoginAndPassword(testUser).SignIn();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Log.Info($"Close test: {TestContext.CurrentContext.Test.MethodName}");
            DriverManager.CloseWebDriver();
        }
    }
}
