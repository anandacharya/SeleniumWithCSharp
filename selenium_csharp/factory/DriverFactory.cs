using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.IO;
using System.Threading;
using selenium_csharp.utils;

namespace selenium_csharp.factory;
    public class DriverFactory
    {
        

        public ThreadLocal<IWebDriver> tldriver = new ThreadLocal<IWebDriver>();

        public IWebDriver GetDriver()
        {
            return tldriver.Value;
        }

        public IWebDriver InitBrowser()
        {
            string browserName = ConfigReader.GetSetting("Browser");
            switch (browserName.ToLower())
            {
                case "chrome":
                    tldriver.Value = new ChromeDriver();
                    break;
                case "chromeheadless":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("headless");
                    tldriver.Value = new ChromeDriver(chromeOptions);
                    break;
                case "firefox":
                    tldriver.Value = new FirefoxDriver();
                    break;
                case "edge":
                    tldriver.Value = new EdgeDriver();
                    break;
                case "safari":
                    tldriver.Value = new SafariDriver();
                    break;
                default:
                    Console.WriteLine("please pass the right browser name...");
                    break;
            }

            GetDriver().Manage().Window.Maximize();
            GetDriver().Manage().Cookies.DeleteAllCookies();
            //timeouts
            GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TestUtil.PAGE_LOAD_TIMEOUT);
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TestUtil.IMPLICIT_WAIT);

//     driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
//     driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            GetDriver().Navigate().GoToUrl(ConfigReader.GetSetting("BaseUrl"));

            return GetDriver();
        }
    }

