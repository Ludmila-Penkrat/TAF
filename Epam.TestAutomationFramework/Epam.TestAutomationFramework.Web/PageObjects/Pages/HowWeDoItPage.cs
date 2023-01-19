using Epam.TestAutomationFramework.Core.BasePage;
using Epam.TestAutomationFramework.Core.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Web.PageObjects.Pages
{
    public class HowWeDoItPage : BasePage
    {
        private const string _breadCrumbsHowWeDoItPageXPath = "//*[@href='/how-we-do-it' and @class='breadcrumbs__link']";

        public override string Url => "https://www.epam.com/how-we-do-it";

        public override Title Title => new Title(By.TagName("h1"));

        public BreadCrumbs HowWeDoItPageBreadCrumbs => new BreadCrumbs(By.XPath(_breadCrumbsHowWeDoItPageXPath));

        public bool BreadCrumsHowWeDoItPageIsDisplayed()
        {
            return HowWeDoItPageBreadCrumbs.IsDisplayed();
        }
    }
}
