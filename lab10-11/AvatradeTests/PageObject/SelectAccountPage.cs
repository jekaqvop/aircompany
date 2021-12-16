using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class SelectAccountPage : BasePage
    {
        public SelectAccountPage(IWebDriver webDriver) : base(webDriver) { }
        private readonly By btnFinancialTransactions = By.XPath("//*[@id='accordion']/div[6]/div[1]");
        private readonly By btnReplenishmentDemoAccount = By.XPath("//a[@href='https://cabinet.ifxglobe.com/demo/client/ru/deposit']");
        private readonly By aSettingInvoice = By.XPath("//a[@href='#collapse_menu_section_9']");
        private readonly By aAccountManagement = By.XPath("//li/a[@href='https://cabinet.ifxglobe.com/demo/client/ru/link_account']");
        private readonly By aTradingAccount = By.XPath("//a[@href='#collapse_menu_section_7']");
        private readonly By aTraderCalculator = By.XPath("//a[@href='https://cabinet.ifxglobe.com/demo/client/ru/forex_calculator']");       
        private readonly By aTrading = By.XPath("//a[@href='https://cabinet.ifxglobe.com/demo/client/ru/trading']");
        private readonly By aPersonalInformation = By.XPath("//a[@href='https://cabinet.ifxglobe.com/demo/client/ru/edit_profile']");

        public ReplenishmentDemoAccountPage OpenReplenishmentDemoAccountPage()
        {
            WaitForVisibilityOfElemen(driver, btnFinancialTransactions).Click();
            WaitForVisibilityOfElemen(driver, btnReplenishmentDemoAccount).Click();
            Log.Info("Open Replenishment Demo Account Page");
            return new ReplenishmentDemoAccountPage(driver);
        }

        public SelectAccountPage ClickSettingInvoice()
        {
            WaitForVisibilityOfElemen(driver, aSettingInvoice).Click();
            Log.Info("Click Setting Invoice");
            return this;
        }

        public AccountManagementPage OpenAccountManagementPage()
        {
            WaitForVisibilityOfElemen(driver, aAccountManagement).Click();
            Log.Info("Click button Account Management");
            return new AccountManagementPage(driver);
        }

        public TraderCalculatorPage OpenTraderCalculatorPage()
        {
            WaitForVisibilityOfElemen(driver, aTradingAccount).Click();
            WaitForVisibilityOfElemen(driver, aTraderCalculator).Click();
            Log.Info("Open Trader Calculator Page");
            return new TraderCalculatorPage(driver);
        }

        public TradingPage OpenTradingPage()
        {
            WaitForVisibilityOfElemen(driver, aTradingAccount).Click();
            WaitForVisibilityOfElemen(driver, aTrading).Click();
            Log.Info("Open Trading Page");
            return new TradingPage(driver);
        }

        public PersonalInformation OpenPersonalInformationPage()
        {
            WaitForVisibilityOfElemen(driver, aSettingInvoice).Click();
            WaitForVisibilityOfElemen(driver, aPersonalInformation).Click();
            Log.Info("Open Trading Page");
            return new PersonalInformation(driver);
        }
    }
}
