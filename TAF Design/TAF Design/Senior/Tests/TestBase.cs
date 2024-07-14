using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Reflection;

namespace Senior.Tests
{
    public class TestBase
    {
        public static ExtentReports extent;
        public static ExtentTest testlog;

        [OneTimeSetUp]
        public void StartReport()
        {
            string path = Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\";

            Directory.CreateDirectory(reportPath);
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            LoggingTestStatusExtentReport();
            extent.Flush();
        }

        public static void StartExtentTest(string testsToStart)
        {
            testlog = extent.CreateTest(testsToStart);
        }

        public static void LoggingTestStatusExtentReport()
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = string.Empty + TestContext.CurrentContext.Result.StackTrace + string.Empty;
                var errorMessage = TestContext.CurrentContext.Result.Message;
                Status logstatus;
                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        testlog.Log(Status.Fail, "Test steps NOT Completed for Test case " + TestContext.CurrentContext.Test.Name + " ");
                        testlog.Log(Status.Fail, "Test ended with " + Status.Fail + " – " + errorMessage);
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        testlog.Log(Status.Skip, "Test ended with " + Status.Skip);
                        break;
                    default:
                        logstatus = Status.Pass;
                        testlog.Log(Status.Pass, "Test steps finished for test case " + TestContext.CurrentContext.Test.Name);
                        testlog.Log(Status.Pass, "Test ended with " + Status.Pass);
                        break;
                }
            }
            catch (WebDriverException ex)
            {
                throw ex;
            }

        }

    }

}
