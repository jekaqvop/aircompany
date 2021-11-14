using System;
using System.Collections.Generic;
using System.Threading;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AvatradeTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private const string Loign = "64948636";
        private const string TestPassword = "a1Ktzi3R";

        private const string ExpectedDeal = "×\r\nЗачисление прошло успешно.";

        [SetUp]
        public void StartPageSetup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.ifxglobe.com/ru/");
            _driver.Manage().Window.Maximize();


            _driver.FindElement(By.XPath("//*[@id='ntoolbar']/div[7]/button")).Click();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login']"))).SendKeys(Loign);
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='pass']"))).SendKeys(TestPassword);

            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client_form_auth']/div/div[1]/div[3]/button[2]"))).Click();

            _driver.FindElement(By.XPath("//*[@id='client_form_auth']/div/div[1]/div[3]/button[2]")).Click();
        }

        [Test]
        public void AddingFundsToYourAccountTest()
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='accordion']/div[6]/div[1]/a"))).Click();
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='collapse_menu_section_11']/div/ul/li/a"))).Click();

            _driver.FindElement(By.XPath("//*[@id='funds']")).Clear();
            _driver.FindElement(By.XPath("//*[@id='funds']")).SendKeys("1111");
           
            _driver.FindElement(By.XPath("//*[@id='depfun']")).Click();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            var actualDeal = _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='errorLog']/div"))).Text;

            Assert.AreEqual(ExpectedDeal, actualDeal);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}