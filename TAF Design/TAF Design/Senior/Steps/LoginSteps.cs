using Senior.Config.Core;
using Senior.Data.Models;
using Senior.Pages;

namespace Senior.Steps
{
    public class LoginSteps
    {
        private LoginPage loginPage = new LoginPage();

        public void LoginIntoTheApplication(User user)
        {
            LoginIntoTheApplication(user.Login, user.Password);
        }

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