using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class ReplenishmentDemoAccountPage : BasePage
    {
        public ReplenishmentDemoAccountPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By txtPrice = By.XPath("//*[@id='funds']");
        private readonly By btnEnroll = By.XPath("//*[@id='depfun']");
        private readonly By divSuccessAddMoney = By.XPath("//*[@id='errorLog']/div");      


        public ReplenishmentDemoAccountPage EnterAddSumPrice(string price)
        {
            WaitForVisibilityOfElemen(driver, txtPrice).Clear();            
            WaitForVisibilityOfElemen(driver, txtPrice).SendKeys(price);
            Log.Info("Enter Sum Price: " + price.ToString());
            return this;
        }

        public ReplenishmentDemoAccountPage ClickBtnEnroll()
        {
            WaitForVisibilityOfElemen(driver, btnEnroll).Click();
            Log.Info("Click button Enroll");
            return this;
        }

        public bool IsVisibilitySuccessAddMoney()
        {
            bool isVisibilitySuccessAddMoney = WaitForVisibilityOfElemen(driver, divSuccessAddMoney).Text.Equals("×\r\nЗачисление прошло успешно.");
            Log.Info("Check isVisibilitySuccessAddMoney: " + isVisibilitySuccessAddMoney.ToString());
            return isVisibilitySuccessAddMoney;
        }
    }
}
