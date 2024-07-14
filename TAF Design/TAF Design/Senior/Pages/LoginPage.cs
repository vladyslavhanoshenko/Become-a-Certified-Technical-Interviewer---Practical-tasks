using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior.Pages
{
    public class LoginPage
    {
        public By UserNameField = By.XPath("//input[@name='username']");
        public By PasswordField = By.XPath("//input[@name='password']");
        public By LoginButton = By.XPath("//button[@type='submit']");
    }
}
