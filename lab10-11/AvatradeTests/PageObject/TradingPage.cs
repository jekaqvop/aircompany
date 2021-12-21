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
    class TradingPage : BasePage
    {
        public TradingPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By btnMinusStopLoss = By.XPath("//*[@id='content']/div[6]/div[1]/div/div[2]/div[2]/div[1]/div/div/span[1]");
        private readonly By btnPlusStopLoss = By.XPath("//*[@id='content']/div[6]/div[1]/div/div[2]/div[2]/div[1]/div/div/span[2]");
        private readonly By btnMinusTakeProfit = By.XPath("//*[@id='content']/div[6]/div[1]/div/div[2]/div[2]/div[2]/div/div/span[1]");
        private readonly By btnPlusTakeProfit = By.XPath("//*[@id='content']/div[6]/div[1]/div/div[2]/div[2]/div[2]/div/div/span[2]");
        private readonly By btnBuy = By.XPath("//input[@value='BUY']");
        private readonly By btnSell = By.XPath("//input[@value='SELL']");
        private readonly By spnTitleby = By.XPath("//*[@id='currentSettings']/div[3]/div/input[2]");
        private readonly By inputValueStopLos = By.XPath("//div[@ng-model='vm.dataForm.sl']/input");
        private readonly By inputValueTakeProfit = By.XPath("//div[@ng-model='vm.dataForm.tp']/input");
        private readonly By btnActiveTransactions = By.XPath("//a[@href='https://cabinet.ifxglobe.com/demo/client/ru/current_trades']");
        private readonly By btnTradingAccount = By.XPath("//a[@href='#collapse_menu_section_7']");

        public TradingPage ClickMinusStopLoss()
        {
            WaitForVisibilityOfElemen(driver, btnMinusStopLoss).Click();
            Log.Info("Click Minus Stop Loss");
            return this;
        }

        public TradingPage ClickPlusStopLoss()
        {
            WaitForVisibilityOfElemen(driver, btnPlusStopLoss).Click();
            Log.Info("Click Plus Stop Loss");
            return this;
        }

        public TradingPage ClickMinusTakeProfit()
        {
            WaitForVisibilityOfElemen(driver, btnMinusTakeProfit).Click();
            Log.Info("Click Minus Take Profit");
            return this;
        }

        public TradingPage ClickPlusTakeProfit()
        {
            WaitForVisibilityOfElemen(driver, btnPlusTakeProfit).Click();
            Log.Info("Click Plus Take Profit");
            return this;
        }

        public TradingPage ClickBuy()
        {
            WaitForVisibilityOfElemen(driver, btnBuy).Click();
            Log.Info("Click Buy");
            return this;
        }

        public TradingPage ClickSell()
        {
            WaitForVisibilityOfElemen(driver, btnSell).Click();
            Log.Info("Click Sell");
            return this;
        }

        public bool IsValidBuy()
        {            
            return WaitForVisibilityOfElemen(driver, spnTitleby).Text.Equals("");             
        }

        public CurrentTransactionsPage OpenCurrentTransactionsPage()
        {
            Thread.Sleep(5000);
            WaitForVisibilityOfElemen(driver, btnTradingAccount).Click();
            WaitForVisibilityOfElemen(driver, btnActiveTransactions).Click();
            Log.Info("Open Current Transactions Page");
            return new CurrentTransactionsPage(driver);
        }

        public string GetCreatedDealToString()
        {
            double stopLoss = double.Parse(WaitForVisibilityOfElemen(driver, inputValueStopLos).GetAttribute("value").Replace(".", ","));
            double takeProfit = double.Parse(WaitForVisibilityOfElemen(driver, inputValueTakeProfit).GetAttribute("value").Replace(".", ","));
            return new Deal(stopLoss, takeProfit).ToString();
        }
        /*public bool IsValidSell()
        {
            Console.WriteLine("hi");
            Console.WriteLine(WaitForVisibilityOfElemen(driver, iframeTitlesellErr));
            //.SwitchTo().Frame(WaitForVisibilityOfElemen(driver, iframeTitlesellErr))
            return true;//WaitForVisibilityOfElemen(driver.SwitchTo().Frame(WaitForVisibilityOfElemen(driver, iframeTitlesellErr)), spnTitlesellErr).Text.Trim().Equals("Ордер успешно установлен");
        }*/
    }
}
//table[@class='table table_main']/tbody/tr/td[6]
