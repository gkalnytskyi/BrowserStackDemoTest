using System;
using System.Linq;

using BrowserStackDemoTest.PageObjects;
using BrowserStackDemoTest.Support;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BrowserStackDemoTest.Steps
{
    [Binding]
    public class Steps
    {
        private readonly BrowserDriver Driver;
        private readonly TestContext Context;

        public Steps(TestContext context, BrowserDriver driver)
        {
            Context = context ?? throw new ArgumentNullException(nameof(driver));
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        [Given(@"""(.*)"" accesses the website")]
        public void GivenAccessesTheWebsite(string username)
        {
            Context.SessionUser = new User()
            {
                Username = username,
                Password = "testingisfun99"
            };
        }

        [Given(@"they arrived on the Main page")]
        public void GivenTheyArrivedOnTheMainPage()
        {
            Driver.Current.Navigate().GoToUrl(@"https://bstackdemo.com/");
        }

        [Given(@"they arrived on Login Page")]
        public void GivenTheyArrivedOnLoginPage()
        {
            Driver.Current.Navigate().GoToUrl(@"https://bstackdemo.com/signin");
        }

        [Given(@"they added ""(.*)"" to cart")]
        public void GivenTheyAddedToCart(string phoneTitle)
        {
            var mainPage = new MainPage(Driver.Current);

            mainPage.ProductsForSale.First(x => x.Title == phoneTitle).AddToCart();
        }

        [Given(@"checked out their purchase")]
        public void GivenCheckedOutTheirPurchase()
        {
            var mainPage = new MainPage(Driver.Current);

            mainPage.ShoppingCart.Buy();
        }

        [Given(@"they logged in")]
        public void GivenTheyLoggedIn()
        {
            var loginPage = new LoginPage(Driver.Current);

            loginPage.Login(Context.SessionUser);
        }

        [Given(@"they filled in shipping details")]
        public void GivenTheyFilledInShippingDetails(ShippingDetails shippingDetails)
        {
            var checkoutPage = new CheckoutPage(Driver.Current);

            checkoutPage.FillInShippingDetails(shippingDetails);
        }
        
        [When(@"they submit the order")]
        public void WhenTheySubmitTheOrder()
        {
            var checkoutPage = new CheckoutPage(Driver.Current);

            checkoutPage.Submit();
        }

        [Given(@"they checked Orders page")]
        [When(@"they checked Orders page")]
        public void GivenTheyCheckedOrdersPage()
        {
            Driver.Current.Navigate().GoToUrl(@"https://bstackdemo.com/orders");
        }

        [Then(@"they can see their order")]
        public void ThenTheyCanSeeTheirOrder()
        {
            var orderPage = new OrdersPage(Driver.Current);

            orderPage.Orders.Should().HaveCount(1);
            var order = orderPage.Orders[0];
            order.OrderPlaced.Should().Be(DateTime.Today.Date);
            order.ShipTo.Should().Be(Context.SessionUser.Username);

            // Going deeper into order seems hard, as there is no simple way to
            // deconstruct items in the list. There is no specific selectors available
            // to get items for the order.
        }
    }
}
