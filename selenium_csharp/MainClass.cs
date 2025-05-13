// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;
// using NUnit.Framework;

// namespace selenium_csharp;

// public class MainClass
// {

// private IWebDriver driver;


// [Test]
// public void initBrowser(){
//     driver = new ChromeDriver();

//     driver.Manage().Window.Maximize();
//     driver.Manage().Cookies.DeleteAllCookies();

//     driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
//     driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

//     driver.Navigate().GoToUrl("https://www.advantageonlineshopping.com/");

//     driver.FindElement(By.Id("hrefUserIcon")).Click();
//     driver.FindElement(By.XPath("//a[text()='CREATE NEW ACCOUNT']")).Click();

//     driver.FindElement(By.XPath("//input[@name='usernameRegisterPage']")).Click();
//     driver.FindElement(By.XPath("//input[@name='emailRegisterPage']")).Click();
//     driver.FindElement(By.XPath("//input[@name='passwordRegisterPage']")).Click();
//     driver.FindElement(By.XPath("//input[@name='confirm_passwordRegisterPage']")).Click();
//     driver.FindElement(By.XPath("//input[@name='first_nameRegisterPage']")).Click();

//  //   Assert.Equals(driver.FindElement(By.XPath("//input[@name='usernameRegisterPage']//..//label[@class='invalid']")).Text,"Username field is required");
//  //   Assert.Equals(driver.FindElement(By.XPath("//input[@name='emailRegisterPage']//..//label[@class='invalid']")).Text,"Email field is required");
//     // Assert.Equals(driver.FindElement(By.XPath("//input[@name='passwordRegisterPage']//..//label[@class='invalid']")).Text,"Password field is required");
//     // Assert.Equals(driver.FindElement(By.XPath("//input[@name='confirm_passwordRegisterPage']//..//label[@class='invalid']")).Text,"Confirm password field is required");

// Assert.That(driver.FindElement(By.XPath("//input[@name='usernameRegisterPage']//..//label[@class='invalid']")).Text,Is.EqualTo("Username field is required"));
// Assert.That(driver.FindElement(By.XPath("//input[@name='emailRegisterPage']//..//label[@class='invalid']")).Text,Is.EqualTo("Email field is required"));
// Assert.That(driver.FindElement(By.XPath("//input[@name='passwordRegisterPage']//..//label[@class='invalid']")).Text,Is.EqualTo("Password field is required"));
// Assert.That(driver.FindElement(By.XPath("//input[@name='confirm_passwordRegisterPage']//..//label[@class='invalid']")).Text,Is.EqualTo("Confirm password field is required"));


//     driver.FindElement(By.XPath("//input[@name='usernameRegisterPage']")).SendKeys("anand");
//     driver.FindElement(By.XPath("//input[@name='emailRegisterPage']")).SendKeys("anand@gmail.com");
//     driver.FindElement(By.XPath("//input[@name='passwordRegisterPage']")).SendKeys("Abc123");
//     driver.FindElement(By.XPath("//input[@name='confirm_passwordRegisterPage']")).SendKeys("Abc123");

// }

// }
