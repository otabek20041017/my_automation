using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowSeleniumProject.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class positive_log_in
    {
        private readonly browsersDrivers _webDriverSetup;
        private IWebDriver _driver;

        public positive_log_in()
        {
            _webDriverSetup = new browsersDrivers();
            _driver = _webDriverSetup.InitDriver("chrome");
        }

        [Given(@"the user navigates to ""(.*)""")]
        public void GivenUserNavigatesTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [When(@"the user enters ""(.*)"" and ""(.*)""")]
        public void WhenUserEntersCredentials(string username, string password)
        {
            _driver.FindElement(By.Id("username")).SendKeys(username);
            _driver.FindElement(By.Id("password")).SendKeys(password);
        }

        [When(@"clicks the submit button")]
        public void WhenClicksLoginButton()
        {
            _driver.FindElement(By.XPath("//*[@id='submit']")).Click();
        }

        [Then(@"the user should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            string pageTitle = _driver.Title;
            if (pageTitle.Equals("Logged In Successfully | Practice Test Automation"))
            {
                Console.WriteLine("ITS MATCHING ===TRUE===");
            }
            else
            {
                Console.WriteLine("ITS NOT MATCHING ===FALSE===");
            }
            _webDriverSetup.QuitDriver();
        }
    }
}
