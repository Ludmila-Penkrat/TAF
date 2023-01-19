using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Core.Elements
{
    public class BreadCrumbs : BaseElement
    {
        public BreadCrumbs(IWebElement element) : base(element)
        {
        }

        public BreadCrumbs(By locator) : base(locator)
        {
        }
    }
}
