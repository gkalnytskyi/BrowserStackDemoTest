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
        public IEnumerable<ShelfItemComponent> ProductsForSale =>
            WebDriver.FindElements(By.ClassName("shelf-item")).
                Select(e => new ShelfItemComponent(e)).ToList();

        public ShoppingCartComponent ShoppingCart =>
            new ShoppingCartComponent(WebDriver.FindElement(By.CssSelector(".float-cart.float-cart--open")));
    }
}
