using OpenQA.Selenium;
using selenium_csharp.factory;
using selenium_csharp.utils;

namespace selenium_csharp.pages;

public class CreateAccountPage : DriverFactory
    {
        private IWebDriver driver;
        private ElementUtil eleUtil;

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            eleUtil = new ElementUtil(driver);
        }

        // Page Objects
        private By userNameField = By.XPath("//input[@name='usernameRegisterPage']");
        private By emailField = By.XPath("//input[@name='emailRegisterPage']");
        private By passwordField = By.XPath("//input[@name='passwordRegisterPage']");
        private By confirmPasswordField = By.XPath("//input[@name='confirm_passwordRegisterPage']");
        private By firstNameField = By.XPath("//input[@name='first_nameRegisterPage']");
        private By userNameErrorTxt = By.XPath("//input[@name='usernameRegisterPage']//..//label[@class='invalid']");
        private By emailErrorTxt = By.XPath("//input[@name='emailRegisterPage']//..//label[@class='invalid']");
        private By passwordErrorTxt = By.XPath("//input[@name='passwordRegisterPage']//..//label[@class='invalid']");
        private By confirmPasswordErrorTxt = By.XPath("//input[@name='confirm_passwordRegisterPage']//..//label[@class='invalid']");

        public void ClickIntoOutOfAccountDetailsFields()
        {
            eleUtil.DoClick(userNameField);
            eleUtil.DoClick(emailField);
            eleUtil.DoClick(passwordField);
            eleUtil.DoClick(confirmPasswordField);
            eleUtil.DoClick(firstNameField);
        }

        // Page Actions
        public string GetUsernameFieldErrorText()
        {
            // eleUtil.WaitForElementVisible(userNameErrorTxt, 3);
            return eleUtil.DoGetText(userNameErrorTxt);
        }

        public string GetEmailFieldErrorText()
        {
            // eleUtil.WaitForElementVisible(emailErrorTxt, 3);
            return eleUtil.DoGetText(emailErrorTxt);
        }

        public string GetPasswordFieldErrorText()
        {
            // eleUtil.WaitForElementVisible(passwordErrorTxt, 3);
            return eleUtil.DoGetText(passwordErrorTxt);
        }

        public string GetConfirmPasswordFieldErrorText()
        {
            // eleUtil.WaitForElementVisible(confirmPasswordErrorTxt, 3);
            return eleUtil.DoGetText(confirmPasswordErrorTxt);
        }

        public void EnterAccountDetails()
        {
            eleUtil.DoSendKeys(userNameField, ConfigReader.GetSetting("Username"));
            eleUtil.DoSendKeys(emailField, ConfigReader.GetSetting("Email"));
            eleUtil.DoSendKeys(passwordField, ConfigReader.GetSetting("Password"));
            eleUtil.DoSendKeys(confirmPasswordField, ConfigReader.GetSetting("ConfirmPassword"));
        }

        public bool VerifyUsernameErrorIsCleared()
        {
            return eleUtil.DoIsDisplayed(userNameErrorTxt);
        }

        public bool VerifyEmailErrorIsCleared()
        {
            return eleUtil.DoIsDisplayed(emailErrorTxt);
        }

        public bool VerifyPasswordErrorIsCleared()
        {
            return eleUtil.DoIsDisplayed(passwordErrorTxt);
        }

        public bool VerifyConfirmPasswordErrorIsCleared()
        {
            return eleUtil.DoIsDisplayed(confirmPasswordErrorTxt);
        }
    }