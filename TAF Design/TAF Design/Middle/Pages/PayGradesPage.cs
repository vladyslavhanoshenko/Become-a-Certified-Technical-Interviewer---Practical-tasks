using OpenQA.Selenium;

namespace Middle.Pages
{
    public class PayGradesPage
    {
        public By PayGradesAddButton = By.XPath("//button[text()=' Add ']");
        public By PayGradesAddNameField = By.XPath("//label[text()='Name']/parent::div/following-sibling::div/input");
        public By SaveButton = By.XPath("//button[@type='submit']");
    }
}
