using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Epam.TestAutomationFramework.Core.Browser
{
    public class FirefoxBrowser : IDriverFactory
    {
        public IWebDriver GetDriver()
        {
            return new FirefoxDriver();
        }
    }
}
