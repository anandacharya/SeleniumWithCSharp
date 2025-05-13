using OpenQA.Selenium;
using selenium_csharp.utils;

namespace selenium_csharp.pages;

public class HomePage
    {
        private IWebDriver driver;
        private ElementUtil eleUtil;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            eleUtil = new ElementUtil(driver);
        }

        // Page Objects using ByLocators
        private By userIcon = By.Id("hrefUserIcon");

        // Page Actions
        public string ValidateTitle()
        {
            return driver.Title;
        }

        public SignInPage ClickUserIcon()
        {
            eleUtil.DoClick(userIcon);
            return new SignInPage(driver);
        }
    }