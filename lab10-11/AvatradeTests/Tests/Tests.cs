using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using AvatradeTests.Driver;
using AvatradeTests.Model;
using AvatradeTests.PageObject;
using AvatradeTests.Service;
using AvatradeTests.Utils;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests.Tests
{
    class Tests : CommonConditions
    {
        [Test]
        public void AddFundsToYourAccountTest()
        {
            replenishmentDemoAccountPage = selectAccountPage.OpenReplenishmentDemoAccountPage();
            string price = "1111";
            replenishmentDemoAccountPage.EnterAddSumPrice(price).ClickBtnEnroll();
            Assert.IsTrue(replenishmentDemoAccountPage.IsVisibilitySuccessAddMoney());
        }

        [Test]
        public void NotAddInvoiceTest()
        {
            accountManagementPage = selectAccountPage.ClickSettingInvoice().OpenAccountManagementPage();
            accountManagementPage.EnterInvoiceAndPassword(CreatorUser.JoiningNewAccountFromProperty());
            accountManagementPage.AddNewInvoice();
            Assert.IsTrue(accountManagementPage.IsVisibilityNotAddInvoice());
        }

        [Test]
        public void AddMyInvoiceTest()
        {
            accountManagementPage = selectAccountPage.ClickSettingInvoice().OpenAccountManagementPage();
            accountManagementPage.EnterInvoiceAndPassword(CreatorUser.JoiningMyAccountFromProperty());
            accountManagementPage.AddNewInvoice();
            Assert.IsTrue(accountManagementPage.IsVisibilityAddMyInvoice());
        }


        [Test]
        public void СalculateDepositTest()
        {
            traderCalculatorPage = selectAccountPage.OpenTraderCalculatorPage();
            traderCalculatorPage.ClickCurrencyPair()
                .SelectEURUSD()
                .ClickLeverage()
                .SelectLeverage1_1()
                .EnterVolumeLots("0.2")
                .ClickAccountCurrency()
                .Calculate();
            Assert.IsTrue(traderCalculatorPage.IsValidValues());
        }

        [Test]
        public void BuyTest()
        {
            tradingPage = selectAccountPage.OpenTradingPage();
            tradingPage.ClickMinusStopLoss().ClickMinusStopLoss().ClickMinusStopLoss().ClickMinusStopLoss()
                .ClickPlusTakeProfit().ClickPlusTakeProfit().ClickPlusTakeProfit().ClickPlusTakeProfit()
                .ClickBuy();
            Assert.IsTrue(tradingPage.IsValidBuy());
        }

        [Test]
        public void SellTest()
        {
            tradingPage = selectAccountPage.OpenTradingPage();
            tradingPage.ClickPlusStopLoss().ClickPlusStopLoss().ClickPlusStopLoss().ClickPlusStopLoss()
                .ClickMinusTakeProfit().ClickMinusTakeProfit().ClickMinusTakeProfit().ClickMinusTakeProfit()
                .ClickSell();
            Assert.IsTrue(tradingPage.IsNotValidSell());
        }

        [Test]
        public void ChangePasswordTest()
        {
            personalInformation = selectAccountPage.OpenPersonalInformationPage();
            personalInformation.OpenPanelChangePassword()
                .InputSimilarMyPassword(CreatorUser.WithCredentialsFromProperty().Password)
                .ClickChangePassword();
            Assert.IsTrue(personalInformation.IsTrueChangePassword());
        }
    }
}