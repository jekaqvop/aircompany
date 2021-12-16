using AvatradeTests.Service;
using AvatradeTests.Utils;
using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvatradeTests.Driver
{
    public static class DriverManager
    {
        private static IWebDriver _driver;
        
        public static IWebDriver GetWebDriver()
        {
            if (_driver == null)
            {
                switch (SetterBrowser.WithCredentialsFromProperty().BrowserName)
                {
                    case "firefox":                    
                        var firefoxOptions = new FirefoxOptions();
                        firefoxOptions.AddArguments(SetterBrowser.WithCredentialsFromProperty().StartParametrs);
                        _driver = new FirefoxDriver(Directory.GetCurrentDirectory(), firefoxOptions);
                        break;
                    
                    default:                    
                        var chromeOptions = new ChromeOptions();
                        chromeOptions.AddArguments(SetterBrowser.WithCredentialsFromProperty().StartParametrs);
                        _driver = new ChromeDriver(Directory.GetCurrentDirectory(), chromeOptions);
                        break;                    
                }
            }
            return _driver;
        }

        public static void CloseWebDriver()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
