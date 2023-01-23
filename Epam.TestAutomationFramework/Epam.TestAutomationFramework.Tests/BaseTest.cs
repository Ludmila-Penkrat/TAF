using Epam.TestAutomationFramework.Core.Helpers;
using Epam.TestAutomationFramework.Core.Browser;
using Epam.TestAutomationFramework.Utilities;
using Epam.TestAutomationFramework.Core.Utils;
using NUnit.Framework;

namespace Epam.TestAutomationFramework.Tests
{
    public abstract class BaseTest
    {
        public TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Logger.InitLogger(TestContext.CurrentContext.Test.Name, Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.LogsPath));
        }

        [SetUp]
        public void BeforeTest()
        {
            Logger.Info("Test is began");
            BrowserFactory.Browser.GoToUrl(TestSettings.ApplicationUrl);
            Waiters.WaitForPageLoad();
        }

        [TearDown]
        public void CleanTest()
        {
            if(TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Logger.Info("Test is failed");           
                BrowserFactory.Browser.SaveScreenShot(TestContext.CurrentContext.Test.MethodName, Path.Combine(TestContext.CurrentContext.TestDirectory, TestSettings.ScreenShotPath));
            }
            Logger.Info("Test is finished");
            //BrowserFactory.Browser.Quite();
            BrowserFactory.CloseBrowser();
        }
    }
}