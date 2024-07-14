using OpenQA.Selenium;

namespace Middle.Pages
{
    public class HomePage
    {
        public By SideBarAdminBlock = By.XPath("//ul[@class='oxd-main-menu']/li/a/span[text()='Admin']");
        public By JobDropDown = By.XPath("//span[text()='Job ']");
        public By PayGradesDropDownValue = By.XPath("//li/a[text()='Pay Grades']");
    }
}
