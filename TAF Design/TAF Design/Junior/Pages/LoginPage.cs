using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Junior.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
        }

        public IWebElement UserNameField => wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='username']")));
        public IWebElement PasswordField => wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='password']")));
        public IWebElement LoginButton => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@type='submit']")));

        public void LoginIntoTheApplication(string userName, string password)
        {
            UserNameField.SendKeys(userName);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}
