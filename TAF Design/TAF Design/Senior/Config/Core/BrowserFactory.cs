using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace Senior.Config.Core
{
    static class BrowserFactory
    {
        internal static IWebDriver GetBrowser(DriverSettings driverSettings)
        {
            switch ((driverSettings.BrowserName, driverSettings.RemoteMode))
            {
                case (BrowserName.Chrome, false):
                    var chromeOptions = GetChromeOptions();
                    chromeOptions.EnableHeadless();
                    return new ChromeDriver(chromeOptions);

                default:
                case (BrowserName.Chrome, true):
                    var chromeRemoteOptions = GetChromeOptions();
                    chromeRemoteOptions.EnableHeadless();
                    return new RemoteWebDriver(chromeRemoteOptions);
            }
        }

        private static ChromeOptions GetChromeOptions()
        {
            var options = new ChromeOptions() { PageLoadStrategy = PageLoadStrategy.Normal };
            options.AddArgument("--no-sandbox");
            return options;
        }

        private static void EnableHeadless(this ChromeOptions options)
        {
            options.AddArguments("--headless", "--window-size=1920,1080");
            options.AddUserProfilePreference("download.default_directory", Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads");
        }
    }
}