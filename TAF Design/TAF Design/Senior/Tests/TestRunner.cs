using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Senior.Config.Core;
using Senior.Tests.Utils;
using System.Reflection;

namespace Senior.Tests
{
    [TestFixture]
    public class TestRunner : TestBase
    {
        [SetUp]
        public void StartBrowser()
        {

            StartExtentTest(TestContext.CurrentContext.Test.Name);

            IConfiguration config = new ConfigurationBuilder()
                        .AddJsonFile("Test.config.json")
                        .AddEnvironmentVariables()
                        .Build();

            DriverSettings settings = config.GetRequiredSection(nameof(DriverSettings)).Get<DriverSettings>(); ;

            DriverHolder.InitDriver(settings);

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
