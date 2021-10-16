using System;
using BrowserStackDemoTest.Support;
using TechTalk.SpecFlow;

namespace BrowserStackDemoTest.Steps
{
    [Binding]
    public class Steps
    {
        private readonly BrowserDriver Driver;

        public Steps(BrowserDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        [Given(@"I arrived on the Main page")]
        public void GivenIArrivedOnTheMainPage()
        {
            Driver.Current.Navigate().GoToUrl(@"https://bstackdemo.com/");
        }


        [Given(@"I am on the page")]
        public void GivenIAmOnThePage()
        {
        }
    }
}
