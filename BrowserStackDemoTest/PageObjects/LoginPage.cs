using BrowserStackDemoTest.Support;
using OpenQA.Selenium;

namespace BrowserStackDemoTest.PageObjects
{
    public class LoginPage : PageBase
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private readonly By UsernameLocator = By.Id("username");
        private readonly By PasswordLocator = By.Id("password");
        private readonly By LoginButton = By.Id("login-btn");

        public void EnterUsername(string username)
        {
            var usernameField = WebDriver.FindElement(UsernameLocator);
            usernameField.Click();
            var menu = new SelectMenuComponent(usernameField);
            menu.SelectOption(username);
        }

        public void EnterPassword(string password)
        {
            var passwordField = WebDriver.FindElement(PasswordLocator);
            passwordField.Click();
            var menu = new SelectMenuComponent(passwordField);
            menu.SelectOption(password);
        }

        public void PressLogin()
        {
            WebDriver.FindElement(LoginButton).Click();
        }

        public void Login(User user)
        {
            EnterUsername(user.Username);
            EnterPassword(user.Password);
            PressLogin();
        }
    }
}
