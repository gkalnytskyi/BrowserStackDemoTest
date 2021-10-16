using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;


namespace BrowserStackDemoTest.PageObjects
{
    public class MainPage : PageBase
    {
        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        // Products
        IEnumerable<ShelfItemComponent> ProductsForSale =>
            WebDriver.FindElements(By.ClassName("shelf-item")).
                Select(e => new ShelfItemComponent(e)).ToList();
    }
}
