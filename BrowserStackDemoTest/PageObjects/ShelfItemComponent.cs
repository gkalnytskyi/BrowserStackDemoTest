using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class ShelfItemComponent : ComponentBase
    {
        public ShelfItemComponent(IWebElement webElement) : base(webElement)
        {
        }

        public string Title => ContainerElement.FindElement(By.ClassName("shelf-item__title")).Text;

        private IWebElement AddToCartButton => ContainerElement.FindElement(By.ClassName("shelf-item__buy-btn"));

        public void AddToCart()
        {
            AddToCartButton.Click();
        }
    }
}
