using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class OrderPlacedPage : PageBase
    {
        public OrderPlacedPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public IWebElement ContinueShopping =>
            WebDriver.FindElement(By.CssSelector("div.continueButtonContainer a button"));
    }
}
