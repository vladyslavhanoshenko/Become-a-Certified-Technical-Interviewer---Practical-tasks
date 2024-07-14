using OpenQA.Selenium;

namespace Middle.Pages
{
    public class LoginPage
    {
        public By UserNameField = By.XPath("//input[@name='username']");
        public By PasswordField = By.XPath("//input[@name='password']");
        public By LoginButton = By.XPath("//button[@type='submit']");
    }
}
