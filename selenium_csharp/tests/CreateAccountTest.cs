using NUnit.Framework;
using OpenQA.Selenium;
using selenium_csharp.factory;
using selenium_csharp.pages;

namespace selenium_csharp.tests;
public class CreateAccountTest : DriverFactory
    {
        private IWebDriver driver;
        private HomePage homePage;
        private SignInPage signInPage;
        private CreateAccountPage createAccountPage;

        public CreateAccountTest() : base() { }

        [SetUp]
        public void SetUp()
        {
            driver = InitBrowser();
            homePage = new HomePage(driver);
        }

        [Test]
        public void MandatoryErrorMessagesDisplayedAndCleared()
        {
            signInPage = homePage.ClickUserIcon();
            createAccountPage = signInPage.CreateNewAccount();
            createAccountPage.ClickIntoOutOfAccountDetailsFields();
            Assert.That(createAccountPage.GetUsernameFieldErrorText(),Is.EqualTo("Username field is required"));
            Assert.That(createAccountPage.GetEmailFieldErrorText(),Is.EqualTo("Email field is required"));
            Assert.That(createAccountPage.GetPasswordFieldErrorText(),Is.EqualTo("Password field is required"));
            Assert.That(createAccountPage.GetConfirmPasswordFieldErrorText(),Is.EqualTo("Confirm password field is required"));
            createAccountPage.EnterAccountDetails();
            Assert.That(createAccountPage.VerifyUsernameErrorIsCleared(),Is.False);
            Assert.That(createAccountPage.VerifyEmailErrorIsCleared(),Is.False);
            Assert.That(createAccountPage.VerifyPasswordErrorIsCleared(),Is.False);
            Assert.That(createAccountPage.VerifyConfirmPasswordErrorIsCleared(),Is.False);
            
        }

        [TearDown]
        public void QuitBrowser()
        {
            driver.Quit();
            System.Console.WriteLine("Browser closed");
        }
    }