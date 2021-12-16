using AvatradeTests.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class TraderCalculatorPage : BasePage
    {
        public TraderCalculatorPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By btnCurrencyPair = By.XPath("//button[@title='EUR/USD']");
        private readonly By btnLeverage = By.XPath("//button[@title='1 : 200']");
        private readonly By btnAccountCurrency = By.XPath("//button[@title='USD']");
        private readonly By txtVolumeLots = By.XPath("//input[@id='fc_lots']");
        private readonly By btnEURUSD = By.XPath("//*[@id='content']/table[1]/tbody/tr/td[1]/div/div/ul/li[1]");
        private readonly By btnLeverage1_1 = By.XPath("//*[@id='content']/table[1]/tbody/tr/td[2]/div/div/ul/li[1]");
        private readonly By btnCurrencyUSD = By.XPath("//*[@id='content']/table[1]/tbody/tr/td[4]/div/div/ul/li[1]");
        private readonly By btnGetPunctPrice = By.XPath("//input[@id='getPunctPrice']");
        private readonly By txtCurrentCourse = By.XPath("//input[@id='fc_kurs']");
        private readonly By txtPriceItem = By.XPath("//*[@id='fc_punct']");
        private readonly By txtDeposit = By.XPath("//input[@id='fc_zalog']");

        public TraderCalculatorPage ClickCurrencyPair()
        {
            WaitForVisibilityOfElemen(driver, btnCurrencyPair).Click();
            Log.Info("Click Currency Pair");
            return this;
        }

        public TraderCalculatorPage SelectEURUSD()
        {
            WaitForVisibilityOfElemen(driver, btnEURUSD).Click();
            Log.Info("Select EURUSD");
            return this;
        }

        public TraderCalculatorPage ClickLeverage()
        {
            WaitForVisibilityOfElemen(driver, btnLeverage).Click();
            Log.Info("Click Leverage");
            return this;
        }

        public TraderCalculatorPage SelectLeverage1_1()
        {
            WaitForVisibilityOfElemen(driver, btnLeverage1_1).Click();
            Log.Info("Select Leverage 1:1");
            return this;
        }

        public TraderCalculatorPage EnterVolumeLots(string volumeLots)
        {
            WaitForVisibilityOfElemen(driver, txtVolumeLots).Clear();        
            WaitForVisibilityOfElemen(driver, txtVolumeLots).SendKeys(volumeLots);
            Log.Info("Enter Volume Lots");
            return this;
        }

        public TraderCalculatorPage ClickAccountCurrency()
        {
            WaitForVisibilityOfElemen(driver, btnAccountCurrency).Click();
            Log.Info("Click Account Currency");
            return this;
        }

        public TraderCalculatorPage SelectAccountCurrencyUSD()
        {
            WaitForVisibilityOfElemen(driver, btnCurrencyUSD).Click();
            Log.Info("Click Select Account Currency USD");
            return this;
        }

        public TraderCalculatorPage Calculate()
        {
            WaitForVisibilityOfElemen(driver, btnGetPunctPrice).Click();
            Log.Info("Click Calculate");
            return this;
        }

        public bool IsValidValues()
        {
            bool isValidValues = false;
            isValidValues = WaitForVisibilityOfElemen(driver, txtPriceItem).Text.Equals("");           
            Log.Info("Chekc IsValidValues");
            return isValidValues;
        }
    }
}
