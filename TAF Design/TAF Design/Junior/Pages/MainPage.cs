using OpenQA.Selenium;

namespace Junior.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base (driver) {}

        public IWebElement HeaderUserIcon => driver.FindElement(By.XPath("//header//img[@alt='profile picture']"));

        public bool IsHeaderUserIconDisplayed()
        {
            return HeaderUserIcon.Displayed;
        }
    }
}