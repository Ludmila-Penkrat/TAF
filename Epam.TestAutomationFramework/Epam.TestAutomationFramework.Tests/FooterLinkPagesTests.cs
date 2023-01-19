using Epam.TestAutomationFramework.Core.Browser;
using Epam.TestAutomationFramework.Core.Utils;
using Epam.TestAutomationFramework.Web.PageObjects.Pages;
using Epam.TestAutomationFramework.Web.Pages;
using NUnit.Framework;

namespace Epam.TestAutomationFramework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]

    public class FooterLinkPagesTests : BaseTest
    {
        private MainPage _mainPage => new MainPage();
        private FooterLinkPages _footerLinkPages => new FooterLinkPages();

        
        [TestCase("Investors")]
        [TestCase("Open Source")]
        [TestCase("Privacy Policy")]
        [TestCase("Cookie Policy")]
        //[TestCase("Applicant Privacy Notice")]
        //[TestCase("Web Accessibility")]
        public void FooterLinksOpenPages(string linkName)
        {
            Thread.Sleep(2000);
            Waiters.WaitForCondition(() => _mainPage.BannerPanel.IsDisplayed());
            _mainPage.AcceptAllCookiesButton.Click();

            BrowserFactory.Browser.ScrollToElement(_mainPage.FooterBlock.OriginalElement);
            _mainPage.FooterBlock.GetFooterLinkByName(linkName).Click();

            Waiters.WaitForCondition(() => _footerLinkPages.Title.IsDisplayed());

            Assert.IsTrue(_footerLinkPages.IsPageOpenedByTitle(), $"Page by link with {linkName} isn't opened");
        }
    }
}
