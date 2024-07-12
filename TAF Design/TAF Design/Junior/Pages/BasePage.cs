using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Junior.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        protected readonly WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
        }
    }
}
