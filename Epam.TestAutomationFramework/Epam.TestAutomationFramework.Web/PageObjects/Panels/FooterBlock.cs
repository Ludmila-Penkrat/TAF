﻿using Epam.TestAutomationFramework.Core.Elements;
using OpenQA.Selenium;

namespace Epam.TestAutomationFramework.Web.PageObjects.Panels
{
    public class FooterBlock : BasePanel
    {
        private const string _epamContinuumBrandFooterLinkXPath = "//*[@href='/epam-continuum']";
        private const string _footerLinksXPath = "//*[@class='footer__links-item']";

        public FooterBlock(By locator) : base(locator) { }

        public Link EpamContinuumLink => new Link(By.XPath(_epamContinuumBrandFooterLinkXPath));

        public ElementsList<Link> FooterLinks => new ElementsList<Link>(By.XPath(_footerLinksXPath));

        public Link GetFooterLinkByName(string footerLinkName)
        {
            var result = FooterLinks.GetElements().Where(x => x.GetText().ToLower().Equals(footerLinkName.ToLower())).FirstOrDefault();
            return result;
        }
    }
}
