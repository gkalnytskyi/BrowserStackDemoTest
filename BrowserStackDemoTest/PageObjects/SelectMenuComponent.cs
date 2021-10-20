using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class SelectMenuComponent : ComponentBase
    {
        public SelectMenuComponent(IWebElement containerElement) : base(containerElement)
        {
        }

        private readonly By OptionsSelector = By.CssSelector(@"div[class$=""-option""]");

        public IDictionary<string, IWebElement> SelectOptions =>
            ContainerElement.FindElements(OptionsSelector).ToDictionary(el => el.Text);

        public void SelectOption(string itemName)
        {
            SelectOptions[itemName].Click();
        }
    }
}
