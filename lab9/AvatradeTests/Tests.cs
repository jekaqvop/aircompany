using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using AvatradeTests.PageObject;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver driver;
        private SelectAccountPage selectAccountPage;
        private ReplenishmentDemoAccountPage replenishmentDemoAccountPage;
        private AccountManagementPage accountManagementPage;

        private const string login = "64969389";
        private const string newLogin = "12345";
        private const string newTestPassword = "12345";      
        private const string testPassword = "ISJW54Is";      

        [SetUp]
        public void StartPageSetup()
        {
            var chromeOptions = new ChromeOptions();
            /*chromeOptions.AddArguments("--headless", "--disable-gpu", "--window-size=1920,1200",
                "--ignore-certificate-errors", "--disable-extensions", "--no-sandbox", "--disable-dev-shm-usage");*/
            driver = new ChromeDriver(Directory.GetCurrentDirectory(), chromeOptions);
            selectAccountPage = new LoginPage(driver).OpenPage().ClickInLoginCabinet().EnterLogin(login).EnterPassword(testPassword).SignIn();
        }

        [Test]
        public void AddFundsToYourAccountTest()
        {
            replenishmentDemoAccountPage = selectAccountPage.OpenReplenishmentDemoAccountPage();
            string price = "1111";           
            replenishmentDemoAccountPage.EnterAddSumPrice(price).ClickBtnEnroll();
            Assert.IsTrue(replenishmentDemoAccountPage.IsVisibilitySuccessAddMoney());
        }

        [Test]
        public void NotAddInvoiceTest()
        {
            accountManagementPage = selectAccountPage.ClickSettingInvoice().OpenAccountManagementPage();            
            accountManagementPage.EnterInvoice(newLogin);
            accountManagementPage.EnterPassword(newTestPassword);
            accountManagementPage.AddNewInvoice();
            Assert.IsTrue(accountManagementPage.IsVisibilityNotAddInvoice());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}