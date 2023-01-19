using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Core.Elements
{
    public class BasePanel : BaseElement
    {
        public BasePanel(IWebElement element) : base(element)
        {
        }

        public BasePanel(By locator) : base(locator)
        {
        }
    }
}
