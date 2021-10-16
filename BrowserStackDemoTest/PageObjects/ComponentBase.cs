using System;
using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public abstract class ComponentBase
    {
        protected readonly IWebElement ContainerElement;

        public ComponentBase(IWebElement containerElement)
        {
            ContainerElement = containerElement ?? throw new ArgumentNullException(nameof(containerElement));
        }
    }
}
