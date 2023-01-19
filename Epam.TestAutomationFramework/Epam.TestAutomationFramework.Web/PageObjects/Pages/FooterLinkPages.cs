using Epam.TestAutomationFramework.Core.BasePage;
using Epam.TestAutomationFramework.Core.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Web.PageObjects.Pages
{
    public class FooterLinkPages : BasePage
    {
        public override string Url => throw new NotImplementedException();

        public override Title Title => new Title(By.TagName("h1"));

    }
}
