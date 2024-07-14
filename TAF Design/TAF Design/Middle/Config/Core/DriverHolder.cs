using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Middle.Config.Core
{
    public class DriverHolder
    {
        private static IWebDriver _instance;

        public static IWebDriver Driver
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new ChromeDriver();
                }

                return _instance;
            }
        }

        public static void Cleanup()
        {
            _instance?.Quit();
            _instance = null;
        }
    }
}
