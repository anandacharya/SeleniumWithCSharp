using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;

namespace selenium_csharp.utils;

    public class ElementUtil
    {
        private IWebDriver driver;

        public ElementUtil(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetElement(By locator)
        {
            WaitForElementPresence(locator, 10);
            IWebElement element = driver.FindElement(locator);
            return element;
        }

        public void DoClick(By locator)
        {
            GetElement(locator).Click();
        }

        public void DoSendKeys(By locator, string value)
        {
            GetElement(locator).SendKeys(value);
        }

        public string DoGetText(By locator)
        {
            string text = GetElement(locator).Text;
            return text;
        }

        public bool DoIsDisplayed(By locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            try
            {
                return driver.FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string DoGetTitle()
        {
            return driver.Title;
        }

        //wait for element to be visible on a new page
        public void WaitForElementPresence(By locator, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementExists(locator));
        }
    }