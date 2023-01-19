using Epam.TestAutomationFramework.Core.Browser;
using Epam.TestAutomationFramework.Core.Utils;
using Epam.TestAutomationFramework.Web.PageObjects.Pages;
using Epam.TestAutomationFramework.Web.Pages;
using NUnit.Framework;


namespace Epam.TestAutomationFramework.Tests
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        private MainPage _mainPage => new MainPage();
        private HowWeDoItPage _howWeDoItPage => new HowWeDoItPage();
        private OurWorkPage _ourWorkPage => new OurWorkPage();

        [Test]
        public void MainPageIsOpened()
        {
            Thread.Sleep(2000);
            //Waiters.WaitForPageLoad();
            var actualResult = BrowserFactory.Browser.GetUrl();
            var expectedUrlForMainPage = _mainPage.GetPageUrl();

            Assert.That(actualResult, Is.EqualTo(expectedUrlForMainPage), "Main page isn't opened.");
        }

        [Test]
        public void CheckWeDoItPageIsOpenedAfterMoveAndReload()
        {
            //Waiters.WaitForPageLoad();
            Thread.Sleep(2000);
            _howWeDoItPage.NavigateToPage();
            _ourWorkPage.NavigateToPage();
            BrowserFactory.Browser.Refresh();
            BrowserFactory.Browser.NavigateBack();            

            Assert.That(BrowserFactory.Browser.GetUrl(), Is.EqualTo(_howWeDoItPage.GetPageUrl()), $"Expected result {_mainPage.GetPageUrl} is'n equal to actual result {BrowserFactory.Browser.GetUrl()}");
        }
    }
}
