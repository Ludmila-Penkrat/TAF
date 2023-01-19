using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Core.Elements
{
    public class TextInput : BaseElement
    {
        public TextInput(IWebElement element) : base(element)
        {
        }

        public TextInput(By locator) : base(locator)
        {
        }
    }
}
