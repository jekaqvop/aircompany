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

        public ReplenishmentDemoAccountPage OpenReplenishmentDemoAccountPage()
        {
            WaitForVisibilityOfElemen(driver, btnFinancialTransactions).Click();
            WaitForVisibilityOfElemen(driver, btnReplenishmentDemoAccount).Click();
            return new ReplenishmentDemoAccountPage(driver);
        }

        public SelectAccountPage ClickSettingInvoice()
        {
            WaitForVisibilityOfElemen(driver, aSettingInvoice).Click();
            return this;
        }

        public AccountManagementPage OpenAccountManagementPage()
        {
            WaitForVisibilityOfElemen(driver, aAccountManagement).Click();
            return new AccountManagementPage(driver);
        }
    }
}
