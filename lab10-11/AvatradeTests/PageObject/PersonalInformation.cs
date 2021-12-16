using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class PersonalInformation : BasePage
    {
        public PersonalInformation(IWebDriver webDriver) : base(webDriver) { }
        private readonly By aChangePassword = By.XPath("//a[@data-target='.ChangePassword']");
        private readonly By txtOldPassword = By.XPath("//input[@id='oldPass']");
        private readonly By txtNewPassword = By.XPath("//input[@id='newPass']");
        private readonly By txtRePassword = By.XPath("//input[@id='rePass']");
        private readonly By btnGetNewPass = By.XPath("//input[@id='getNewPass']");
        private readonly By divChangePass = By.XPath("//*[@id='ChangePassword']/div[2]/div/div[2]/div[6]/div/div/div");

        public PersonalInformation OpenPanelChangePassword()
        {
            WaitForVisibilityOfElemen(driver, aChangePassword).Click();
            return this;
        }

        public PersonalInformation InputSimilarMyPassword(string pass)
        {
            WaitForVisibilityOfElemen(driver, txtOldPassword).SendKeys(pass);
            WaitForVisibilityOfElemen(driver, txtNewPassword).SendKeys(pass);
            WaitForVisibilityOfElemen(driver, txtRePassword).SendKeys(pass);
            return this;
        }

        public PersonalInformation ClickChangePassword()
        {
            WaitForVisibilityOfElemen(driver, btnGetNewPass).Click();
            return this;
        }

        public bool IsTrueChangePassword()
        {
            Console.WriteLine("hi");
            Console.WriteLine(WaitForVisibilityOfElemen(driver, divChangePass).Text);
            return WaitForVisibilityOfElemen(driver, divChangePass).Text.Trim().Equals("×\r\nУспешно. Пароль изменен.");
        }
    }
}
