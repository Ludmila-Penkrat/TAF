using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Core.Elements
{
    public class Title : BaseElement
    {
        public Title(IWebElement element) : base(element)
        {
        }

        public Title(By locator) : base(locator)
        {
        }
    }
}
