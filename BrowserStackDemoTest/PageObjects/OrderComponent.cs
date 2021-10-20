using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class OrderComponent : ComponentBase
    {
        public OrderComponent(IWebElement containerElement) : base(containerElement)
        {
        }

        public DateTime OrderPlaced =>
            DateTime.Parse(
                ContainerElement.FindElement(By.CssSelector("div.order-info span.value")).Text);

        // Could there be a better way to select element? ':nth-child(3) doesn't seem to work.
        public string ShipTo => ContainerElement.FindElements(
                    By.CssSelector("div.order-info span.value"))[2].Text;
    }
}
