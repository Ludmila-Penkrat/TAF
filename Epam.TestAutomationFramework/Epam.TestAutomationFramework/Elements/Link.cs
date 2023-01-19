using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Core.Elements
{
    public class Link : BaseElement
    {
        public Link(IWebElement element) : base(element)
        {
        }

        public Link(By locator) : base(locator)
        {
        }
    }
}
