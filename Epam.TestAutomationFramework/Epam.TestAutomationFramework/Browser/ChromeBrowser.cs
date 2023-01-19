using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.TestAutomationFramework.Core.Browser
{
    public class ChromeBrowser : IDriverFactory
    {
        public IWebDriver GetDriver()
        {
            var chromeOption = new ChromeOptions();
            chromeOption.AddArgument("--start-maximized");
            var service = ChromeDriverService.CreateDefaultService();
            var chromeDriver = new ChromeDriver(service, chromeOption, TimeSpan.FromMinutes(2));
            return chromeDriver;
        }
    }
}
