using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class AccountManagementPage : BasePage
    {
        public AccountManagementPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By txtInvoice = By.XPath("//*[@id='la_login']");
        private readonly By txtPassword = By.XPath("//*[@id='la_password']");
        private readonly By btnAddInvoice = By.XPath("//input[@value='Добавить счет']");
        private readonly By divNotAddInvoice = By.XPath("//*[@id='mini_auth_form']/div/div[3]/div");

        public AccountManagementPage EnterInvoice(string login)
        {
            WaitForVisibilityOfElemen(driver, txtInvoice).SendKeys(login);
            return this;
        }

        public AccountManagementPage EnterPassword(string password)
        {
            WaitForVisibilityOfElemen(driver, txtPassword).SendKeys(password);
            return this;
        }

        public AccountManagementPage AddNewInvoice()
        {
            WaitForVisibilityOfElemen(driver, btnAddInvoice).Click();
            return this;
        }

        public bool IsVisibilityNotAddInvoice()
        {     
            return WaitForVisibilityOfElemen(driver, divNotAddInvoice).Text.Trim().Equals("Вы не можете прикрепить реальный счет");           
        }
    }
}
