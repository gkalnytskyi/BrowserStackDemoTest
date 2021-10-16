using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class ShoppingCartComponent : ComponentBase
    {
        public ShoppingCartComponent(IWebElement containerElement) : base(containerElement)
        {
        }

        private IWebElement BuyButton => ContainerElement.FindElement(By.ClassName("buy-btn"));

        public void Buy()
        {
            BuyButton.Click();
        }
    }
}
