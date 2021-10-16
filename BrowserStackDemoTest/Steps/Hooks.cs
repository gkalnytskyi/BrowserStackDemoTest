using System;

using BrowserStackDemoTest.Support;
using TechTalk.SpecFlow;

namespace BrowserStackDemoTest.Steps
{
    [Binding]
    public class Hooks
    {
        private readonly BrowserDriver Driver;

        public Hooks(BrowserDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Current.Close();
        }
    }
}
