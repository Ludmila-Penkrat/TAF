using Epam.TestAutomationFramework.Core.Browser;
using Epam.TestAutomationFramework.Core.Utils;
using Epam.TestAutomationFramework.Web.PageObjects.Pages;
using Epam.TestAutomationFramework.Web.Pages;
using NUnit.Framework;

namespace Epam.TestAutomationFramework.Tests
{
    [TestFixture]
    public class EpemContinuumPageTests : BaseTest
    {
        private MainPage _mainPage => new MainPage();
        private EpamContinuumPage _continuumPage => new EpamContinuumPage();

        [Test]
        public void EpamContinuumPageIsOpened()
        {
            Waiters.WaitForCondition(()=> _mainPage.BannerPanel.IsDisplayed());
            _mainPage.AcceptAllCookiesButton.Click();

            BrowserFactory.Browser.ScrollToElement(_mainPage.FooterBlock.OriginalElement);
            _mainPage.FooterBlock.EpamContinuumLink.Click();

            Assert.That(_continuumPage.BreadCrumsIsDisplayed(), "Epam Continuum page isn't opened.");
        }
    }
}
