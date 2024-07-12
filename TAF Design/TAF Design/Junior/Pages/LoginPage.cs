using OpenQA.Selenium;

namespace Junior.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement UserNameField => driver.FindElement(By.XPath("//input[@name='username']"));
        public IWebElement PasswordField => driver.FindElement(By.XPath("//input[@name='password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        public void LoginIntoTheApplication(string userName, string password)
        {
            UserNameField.SendKeys(userName);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}
