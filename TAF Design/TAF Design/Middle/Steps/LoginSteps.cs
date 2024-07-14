using Middle.Config.Core;
using Middle.Pages;

namespace Middle.Steps
{
    public class LoginSteps
    {
        private LoginPage loginPage = new LoginPage();

        public void LoginIntoTheApplication(string userName, string password)
        {
            var firstNameInput = DriverHolder.Driver.FindElement(loginPage.UserNameField);
            firstNameInput.SendKeys(userName);
            var passwordInput = DriverHolder.Driver.FindElement(loginPage.PasswordField);
            passwordInput.SendKeys(password);

            DriverHolder.Driver
                    .FindElement(loginPage.LoginButton)
                    .Click();
        }
    }
}
