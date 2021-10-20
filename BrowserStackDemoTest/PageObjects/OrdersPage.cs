using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class OrdersPage : PageBase
    {
        public OrdersPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public IList<OrderComponent> Orders =>
            WebDriver.FindElements(By.CssSelector("div.orders-listing div.order")).
            Select(el => new OrderComponent(el)).
            ToList();
    }
}
