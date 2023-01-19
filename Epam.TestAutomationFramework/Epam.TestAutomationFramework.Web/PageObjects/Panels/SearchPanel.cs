﻿using Epam.TestAutomationFramework.Core.Browser;
using Epam.TestAutomationFramework.Core.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Web.PageObjects.Panels
{
    public class SearchPanel : BasePanel
    {
        public SearchPanel(By locator) : base(locator) { }

        private const string _searchFieldXPath = "//input[@name = 'q']";
        private const string _findButtonXPath = "//*[@class = 'header-search__submit']";
        private const string _itemInDropDownSearchPanelXPath = "//*[@class='frequent-searches__item']";
        
        private TextInput SearchField => new TextInput(By.XPath(_searchFieldXPath));
        private Button FindButton => new Button(By.XPath(_findButtonXPath));

        private List<IWebElement> _collectionOfItemsInDropDown => BrowserFactory.Browser.FindElements(By.XPath(_itemInDropDownSearchPanelXPath)).ToList();

        public void InputStringInSearchField(string input)
        {
            SearchField.SendKeys(input);
        }

        public void ClickFindButton()
        {
            FindButton.Click();
        }

        public IWebElement GetElementFromCollection(string name)
        {
            var elementFromCollection = _collectionOfItemsInDropDown.Where(x => x.Text.Contains(name)).FirstOrDefault();
            return elementFromCollection;
        }
    }
}
