using AvatradeTests.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.PageObject
{
    class CurrentTransactionsPage : BasePage
    {
        public CurrentTransactionsPage(IWebDriver webDriver) : base(webDriver) { }

        private readonly By tdSL = By.XPath("//table[@class='table table_main']/tbody/tr[last()-2]/td[6]");
        private readonly By tdTP = By.XPath("//table[@class='table table_main']/tbody/tr[last()-2]/td[7]");

        public string GetLastDealToString()
        {
            double stopLoss = double.Parse(WaitForVisibilityOfElemen(driver, tdSL).Text.Replace(".", ","));
            double takeProfit = double.Parse(WaitForVisibilityOfElemen(driver, tdTP).Text.Replace(".", ","));
            return new Deal(stopLoss, takeProfit).ToString();
        }
    }
}
