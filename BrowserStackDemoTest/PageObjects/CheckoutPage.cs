using BrowserStackDemoTest.Support;
using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class CheckoutPage : PageBase
    {
        public CheckoutPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private readonly By FirstNameInputLocator = By.Id("firstNameInput");
        private IWebElement FirstName => WebDriver.FindElement(FirstNameInputLocator);

        private readonly By LastNameInputLocator = By.Id("lastNameInput");
        private IWebElement LastName => WebDriver.FindElement(LastNameInputLocator);

        private readonly By AddressInputLocator = By.Id("addressLine1Input");
        private IWebElement Address => WebDriver.FindElement(AddressInputLocator);

        private readonly By ProvinceInputLocator = By.Id("provinceInput");
        private IWebElement Province => WebDriver.FindElement(ProvinceInputLocator);

        private readonly By PostalCodeLocator = By.Id("postCodeInput");
        private IWebElement PostalCode => WebDriver.FindElement(PostalCodeLocator);

        private readonly By SubmitButtonLocator = By.Id("checkout-shipping-continue");
        private IWebElement SubmitButton => WebDriver.FindElement(SubmitButtonLocator);

        public CheckoutPage FillInShippingDetails(ShippingDetails shippingDetails)
        {
            FirstName.SendKeys(shippingDetails.FirstName);
            LastName.SendKeys(shippingDetails.LastName);
            Address.SendKeys(shippingDetails.Address);
            Province.SendKeys(shippingDetails.State);
            PostalCode.SendKeys(shippingDetails.PostCode);

            return this;
        }

        public CheckoutPage Submit()
        {
            SubmitButton.Click();
            return this;
        }
    }
}
