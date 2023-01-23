﻿using Epam.TestAutomationFramework.Core.Browser;
using Epam.TestAutomationFramework.Core.Utils;
using Epam.TestAutomationFramework.Utilities;
using Epam.TestAutomationFramework.Web.PageObjects.Pages;
using Epam.TestAutomationFramework.Web.PageObjects.Panels;
using Epam.TestAutomationFramework.Web.Pages;
using NUnit.Framework;

namespace Epam.TestAutomationFramework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class SearchResultPageTests : BaseTest
    {
        private MainPage _mainPage => new MainPage();
        private SearchResultsPage _searchPage => new SearchResultsPage();

        [TestCase("Blockchain")]
        [TestCase("Open Source")]
        [TestCase("Automation")]
        [TestCase("Digital Risk Management")]
        public void CheckIfSearchResultTitleIsDisplayedWithInputWords(string inputLine)
        {
            _mainPage.SearchButton.Click();
            _mainPage.HeaderBlock.SearchPanel.InputStringInSearchField(inputLine);
            _mainPage.HeaderBlock.SearchPanel.ClickFindButton();

            var expectedResult = _searchPage.SearchResultTitleForArticles.IsDisplayed();

            Assert.IsTrue(expectedResult, "Search result of articles is not found");
        }
        
        private static List<string> _selectedWord = new List<string>()
        {
            "Cloud",
            "Blockchain",
            "Open Source",
            "RPA"
        };
        [TestCaseSource(nameof(_selectedWord))]
        public void CheckIfSearchResultPageIsDisplayedBySelectedWordsFromList(string selectedWord)
        {
            _mainPage.SearchButton.Click();
            Thread.Sleep(3000);

            Waiters.WaitForCondition(() => _mainPage.HeaderBlock.SearchPanel.IsDisplayed());

            var linkBySelectedItem = _mainPage.HeaderBlock.SearchPanel.GetElementFromCollection(selectedWord);

            Waiters.WaitForCondition(() => linkBySelectedItem.Enabled);
            BrowserFactory.Browser.Actions().MoveToElement(linkBySelectedItem).Build().Perform();

            Waiters.WaitForCondition(() => linkBySelectedItem.Displayed);
            linkBySelectedItem.Click();

            _mainPage.HeaderBlock.SearchPanel.ClickFindButton();

            var expectedResult = _searchPage.SearchResultTitleForArticles.GetAttribut("innerText");

            Assert.That(expectedResult.Contains(selectedWord, StringComparison.OrdinalIgnoreCase), "Search result title doesn't contain selected word.");
        }
    }
}
