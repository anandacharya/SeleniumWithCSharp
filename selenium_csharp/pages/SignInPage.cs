using OpenQA.Selenium;
using selenium_csharp.utils;

namespace selenium_csharp.pages;

public class SignInPage{

    private IWebDriver driver;
        private ElementUtil eleUtil;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            eleUtil = new ElementUtil(driver);
        }

        //Page Objects
    private By createAccountLink = By.XPath("//a[text()='CREATE NEW ACCOUNT']");

    //Page Actions
    public CreateAccountPage CreateNewAccount(){
        eleUtil.DoClick(createAccountLink);
        return new CreateAccountPage(driver);
    }
}