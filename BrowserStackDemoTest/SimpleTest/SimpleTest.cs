using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BrowserStackDemoTest.SimpleTest
{
    [TestFixture]
    public class SimpleTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");

            driver = new ChromeDriver(chromeDriverService, chromeOptions);
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Close();
            driver?.Quit();
            driver?.Dispose();
        }

        [Test]
        public void OpenGoToPage()
        {
            driver.Navigate().GoToUrl(@"https://bstackdemo.com/");

            ;
        }
    }
}
