using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior.Pages
{
    public class PayGradesPage
    {
        public By PayGradesAddButton = By.XPath("//button[text()=' Add ']");
        public By PayGradesAddNameField = By.XPath("//label[text()='Name']/parent::div/following-sibling::div/input");
        public By SaveButton = By.XPath("//button[@type='submit']");
    }
}
