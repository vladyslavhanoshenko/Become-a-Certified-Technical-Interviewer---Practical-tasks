using Middle.Config.Core;
using Middle.Tests.Utils;
using NUnit.Framework;

namespace Middle.Tests
{
    [TestFixture]
    public class TestRunner : TestBase
    {
        [SetUp]
        public void StartBrowser()
        {
            StartExtentTest(TestContext.CurrentContext.Test.Name);

            DriverHolder.Driver.Url = ApplicationConfig.BaseUrl;

            DriverHolder.Driver.Manage().Window.Maximize();
            DriverHolder.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void CloseBrowser()
        {
            DriverHolder.Cleanup();
        }
    }
}
