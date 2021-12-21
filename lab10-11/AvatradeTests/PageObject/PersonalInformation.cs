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
        private readonly By divChangeTypeAccount = By.XPath("//a[@data-target='.ChangeEurica']");
        private readonly By btnNewTypeAccount = By.XPath("//button[@data-id='newType']");
        private readonly By btnStandartTypeAccount = By.XPath("//a[@data-normalized-text='<span class=\"text\">Standart</span>']");
        private readonly By btnSaveTypeAccount = By.XPath("//input[@id='getNewType']");
        private readonly By divMessage = By.XPath("//*[@id='ChangeEurica']/div[2]/div/div[2]/div[3]/div/div/div");
        private readonly By btnChangeShoulder = By.XPath("//a[@data-target='.ChangeLeverage']");
        private readonly By btnSelectShoulder = By.XPath("//button[@data-id='newLvg']");
        private readonly By btnSelect200Shoulder = By.XPath("//a[@data-normalized-text='<span class=\"text\">200</span>']");
        private readonly By saveChangeShoulder = By.XPath("//input[@id='getNewLvg']");
        private readonly By messageChangeShoulder = By.XPath("//*[@id='ChangeLeverage']/div[2]/div/div[2]/div[2]/div/div/div");

        private readonly By aChangePasswordInvestor = By.XPath("//a[@data-target='.ChangePasswordInvestor']");
        private readonly By txtOldPasswordTrader = By.XPath("//input[@id='traderPass']");
        private readonly By txtNewPasswordInvestor = By.XPath("//input[@id='newPassInvestor']");
        private readonly By txtRePasswordInvestor = By.XPath("//input[@id='rePassInvestor']");
        private readonly By btnGetNewPassInvestor = By.XPath("//input[@id='getNewPassInvestor']");
        private readonly By divChangePassInvestor = By.XPath("//*[@id='ChangePasswordInvestor']/div[2]/div/div[2]/div[6]/div/div/div");

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
        
        public PersonalInformation OpenChangeTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, divChangeTypeAccount).Click();
            return this;
        }
        
        public PersonalInformation ClickNewTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, btnNewTypeAccount).Click();
            return this;
        }
        public PersonalInformation ClickStandartTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, btnStandartTypeAccount).Click();
            return this;
        }
        
        public PersonalInformation SaveStandartTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, btnSaveTypeAccount).Click();
            return this;
        }

        public bool IsChangeCurrentType()
        {
            return WaitForVisibilityOfElemen(driver, divMessage).Text.Trim().Equals("×\r\nВы выбрали текущий тип счета.");
        }

        public bool IsTrueChangePassword()
        {
            return WaitForVisibilityOfElemen(driver, divChangePass).Text.Trim().Equals("×\r\nУспешно. Пароль изменен.");
        }

        public bool IsTrueChangePasswordInvestor()
        {
            return WaitForVisibilityOfElemen(driver, divChangePassInvestor).Text.Trim().Equals("×\r\nУспешно. Пароль изменен.");
        }

        public PersonalInformation OpenChangeShoulder()
        {
            WaitForVisibilityOfElemen(driver, btnChangeShoulder).Click();
            return this;
        }

        public PersonalInformation ClickNewShoulder()
        {
            WaitForVisibilityOfElemen(driver, btnSelectShoulder).Click();
            return this;
        }
        public PersonalInformation SelectShoulder()
        {
            WaitForVisibilityOfElemen(driver, btnSelect200Shoulder).Click();
            return this;
        }

        public PersonalInformation SaveSelectShoulder()
        {
            WaitForVisibilityOfElemen(driver, saveChangeShoulder).Click();
            return this;
        }

        public bool IsChangeSelectShoulder()
        {
            return WaitForVisibilityOfElemen(driver, messageChangeShoulder).Text.Trim().Equals("×\r\nВыбранное плечо уже установлено. Если вы хотите изменить это плечо, то выберите другое значение.");
        }

        public PersonalInformation OpenPanelChangePasswordInvestor()
        {
            WaitForVisibilityOfElemen(driver, aChangePasswordInvestor).Click();
            return this;
        }

        public PersonalInformation InputSimilarMyPasswordInvestor(string passTrader, string newPassInvestor)
        {
            WaitForVisibilityOfElemen(driver, txtOldPasswordTrader).SendKeys(passTrader);
            WaitForVisibilityOfElemen(driver, txtNewPasswordInvestor).SendKeys(newPassInvestor);
            WaitForVisibilityOfElemen(driver, txtRePasswordInvestor).SendKeys(newPassInvestor);
            return this;
        }

        public PersonalInformation ClickChangePasswordInvestor()
        {
            WaitForVisibilityOfElemen(driver, btnGetNewPassInvestor).Click();
            return this;
        }
    }
}
