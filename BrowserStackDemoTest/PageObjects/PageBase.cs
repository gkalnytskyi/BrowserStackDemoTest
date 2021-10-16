using System;
using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public abstract class PageBase
    {
        protected readonly IWebDriver WebDriver; 

        public PageBase(IWebDriver webDriver)
        {
            WebDriver = webDriver ?? throw new ArgumentNullException(nameof(webDriver));
        }
    }
}
