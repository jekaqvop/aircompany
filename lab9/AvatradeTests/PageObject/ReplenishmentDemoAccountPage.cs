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
            return this;
        }

        public ReplenishmentDemoAccountPage ClickBtnEnroll()
        {
            WaitForVisibilityOfElemen(driver, btnEnroll).Click();            
            return this;
        }

        public bool IsVisibilitySuccessAddMoney()
        {
            return WaitForVisibilityOfElemen(driver, divSuccessAddMoney).Text.Equals("×\r\nЗачисление прошло успешно.");
        }

        
    }
}
