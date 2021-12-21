using AvatradeTests.Utils;
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
            Log.Info("Open Panel Change Password");
            return this;
        }

        public PersonalInformation InputSimilarMyPassword(string pass)
        {
            WaitForVisibilityOfElemen(driver, txtOldPassword).SendKeys(pass);
            WaitForVisibilityOfElemen(driver, txtNewPassword).SendKeys(pass);
            WaitForVisibilityOfElemen(driver, txtRePassword).SendKeys(pass);
            Log.Info("Input Similar My Password");
            return this;
        }

        public PersonalInformation ClickChangePassword()
        {
            WaitForVisibilityOfElemen(driver, btnGetNewPass).Click();
            Log.Info("Click button Change Password");
            return this;
        }        
        
        public PersonalInformation OpenChangeTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, divChangeTypeAccount).Click();
            Log.Info("Click Open Change Type Account");
            return this;
        }
        
        public PersonalInformation ClickNewTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, btnNewTypeAccount).Click();
            Log.Info("Click new Type Account");
            return this;
        }
        public PersonalInformation ClickStandartTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, btnStandartTypeAccount).Click();
            Log.Info("Click Standart Type Account");
            return this;
        }
        
        public PersonalInformation SaveStandartTypeAccount()
        {
            WaitForVisibilityOfElemen(driver, btnSaveTypeAccount).Click();
            Log.Info("Click Save Standart Type Account");
            return this;
        }

        public bool IsChangeCurrentType()
        {
            Log.Info("Check Is True Change Current Type");
            return WaitForVisibilityOfElemen(driver, divMessage).Text.Trim().Equals("×\r\nВы выбрали текущий тип счета.");
        }

        public bool IsTrueChangePassword()
        {
            Log.Info("Check Is True Change Password");
            return WaitForVisibilityOfElemen(driver, divChangePass).Text.Trim().Equals("×\r\nУспешно. Пароль изменен.");
        }

        public bool IsTrueChangePasswordInvestor()
        {
            Log.Info("Check Is True Change Password Investor");
            return WaitForVisibilityOfElemen(driver, divChangePassInvestor).Text.Trim().Equals("×\r\nУспешно. Пароль изменен.");
        }

        public PersonalInformation OpenChangeShoulder()
        {
            WaitForVisibilityOfElemen(driver, btnChangeShoulder).Click();
            Log.Info("Click Open Change Shoulder");
            return this;
        }

        public PersonalInformation ClickNewShoulder()
        {
            WaitForVisibilityOfElemen(driver, btnSelectShoulder).Click();
            Log.Info("Click New select Shoulder");
            return this;
        }
        public PersonalInformation SelectShoulder()
        {
            WaitForVisibilityOfElemen(driver, btnSelect200Shoulder).Click();
            Log.Info("Click Select Shoulder");
            return this;
        }

        public PersonalInformation SaveSelectShoulder()
        {
            WaitForVisibilityOfElemen(driver, saveChangeShoulder).Click();
            Log.Info("Click button Save Select Shoulder");
            return this;
        }

        public bool IsChangeSelectShoulder()
        {
            Log.Info("Check Is Change Select Shoulder");
            return WaitForVisibilityOfElemen(driver, messageChangeShoulder).Text.Trim().Equals("×\r\nВыбранное плечо уже установлено. Если вы хотите изменить это плечо, то выберите другое значение.");
        }

        public PersonalInformation OpenPanelChangePasswordInvestor()
        {
            WaitForVisibilityOfElemen(driver, aChangePasswordInvestor).Click();
            Log.Info("Click Open Panel Change Password Investor");
            return this;
        }

        public PersonalInformation InputSimilarMyPasswordInvestor(string passTrader, string newPassInvestor)
        {
            WaitForVisibilityOfElemen(driver, txtOldPasswordTrader).SendKeys(passTrader);
            WaitForVisibilityOfElemen(driver, txtNewPasswordInvestor).SendKeys(newPassInvestor);
            WaitForVisibilityOfElemen(driver, txtRePasswordInvestor).SendKeys(newPassInvestor);
            Log.Info("Input Similar My Password Investor");
            return this;
        }

        public PersonalInformation ClickChangePasswordInvestor()
        {
            WaitForVisibilityOfElemen(driver, btnGetNewPassInvestor).Click();
            return this;
        }
    }
}
