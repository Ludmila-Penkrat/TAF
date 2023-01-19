using Epam.TestAutomationFramework.Core.BasePage;
using Epam.TestAutomationFramework.Core.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Web.PageObjects.Pages
{
    public class OurWorkPage : BasePage
    {
        private const string _ourWorkPageBreadCrumbsXPath = "//*[@href='/our-work' and @class='breadcrumbs__link']";

        public override string Url => "https://www.epam.com/our-work";

        public override Title Title => new Title(By.TagName("h1"));

        public BreadCrumbs OurWorkPageBreadCrumbs => new BreadCrumbs(By.XPath(_ourWorkPageBreadCrumbsXPath));

        public bool OurWorkBreadcrumbsIsDisplayed()
        {
            return OurWorkPageBreadCrumbs.IsDisplayed();
        }
    }
}
