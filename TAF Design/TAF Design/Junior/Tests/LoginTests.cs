using Junior.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Junior.Tests
{
    [TestFixture]
    public class LoginTests
    {
        private IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void VerifyLoginIntoApplication()
        {
            driver!.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com");

            var loginPage = new LoginPage(driver);
            loginPage.LoginIntoTheApplication("Admin", "admin123");

            var mainPage = new MainPage(driver);
            var IsHeaderUserIconDisplayed = mainPage.IsHeaderUserIconDisplayed();

            Assert.That(IsHeaderUserIconDisplayed, Is.True);
        }

        [TearDown]
        public void Teardown()
        {
            driver!.Quit();
        }
    }
}
