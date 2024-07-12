using OpenQA.Selenium;

namespace Junior.Pages
{
    public class MainPage
    {
        private readonly IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement HeaderUserIcon => driver.FindElement(By.XPath("//header//img[@alt='profile picture']"));

        public bool IsHeaderUserIconDisplayed()
        {
            return HeaderUserIcon.Displayed;
        }
    }
}
