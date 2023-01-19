using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Core.Elements
{
    public class DropDown : BaseElement
    {
        public DropDown(IWebElement element) : base(element)
        {
        }

        public DropDown(By locator) : base(locator)
        {
        }
    }
}
