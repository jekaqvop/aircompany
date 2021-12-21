using AvatradeTests.Model;
using AvatradeTests.Utils;
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

        public AccountManagementPage EnterInvoiceAndPassword(User user)
        {
            WaitForVisibilityOfElemen(driver, txtInvoice).SendKeys(user.TradingAccount);
            Log.Info("Enter Invoice on txtInvoice");
            WaitForVisibilityOfElemen(driver, txtPassword).SendKeys(user.Password);
            Log.Info("Enter Password on txtPassword");
            return this;
        }      

        public AccountManagementPage AddNewInvoice()
        {
            WaitForVisibilityOfElemen(driver, btnAddInvoice).Click();
            Log.Info("Click button Add New Invoice");
            return this;
        }

        public bool IsVisibilityNotAddInvoice()
        {
            bool isVisibilityNotAddInvoice = WaitForVisibilityOfElemen(driver, divNotAddInvoice).Text.Trim().Equals("Вы не можете прикрепить реальный счет");
            Log.Info($"Check out text: {WaitForVisibilityOfElemen(driver, divNotAddInvoice).Text.Trim()}");
            return isVisibilityNotAddInvoice;           
        }

        public bool IsVisibilityAddMyInvoice()
        {
            Console.WriteLine(WaitForVisibilityOfElemen(driver, divNotAddInvoice).Text.Trim());
            bool isVisibilityNotAddInvoice = WaitForVisibilityOfElemen(driver, divNotAddInvoice).Text.Trim().Equals("Указаный номер счета уже прикреплен к другому счету");
            Log.Info($"Check out text: {WaitForVisibilityOfElemen(driver, divNotAddInvoice).Text.Trim()}");
            return isVisibilityNotAddInvoice;
        }
    }
}
