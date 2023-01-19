using Epam.TestAutomationFramework.Core.BasePage;
using Epam.TestAutomationFramework.Core.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Web.PageObjects.Pages
{
    public class EpamContinuumPage : BasePage
    {
        private const string _breadCrumbsEpanContinuumPageXPath = "//*[@href='/services/consult-and-design' and @class='breadcrumbs__link']";

        public override string Url => "https://www.epam.com/services/consult-and-design";

        public override Title Title => new Title(By.TagName("h1"));

        public BreadCrumbs EpanContinuumPageBreadCrumbs => new BreadCrumbs(By.XPath(_breadCrumbsEpanContinuumPageXPath));

        public bool BreadCrumsIsDisplayed()
        {
            return EpanContinuumPageBreadCrumbs.IsDisplayed();
        }
    }
}
