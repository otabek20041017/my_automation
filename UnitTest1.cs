using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Diagnostics.Metrics;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.com");

            Assert.That(driver.Url, Is.EqualTo("https://www.google.com/"));
            Assert.That(driver.Title, Is.EqualTo("Google"));

            IWebElement element = driver.FindElement(By.XPath("//*[@*='Search']"));
            element.SendKeys("Uzbek Somsa" + Keys.Enter);

            driver.FindElement(By.XPath("//*[@class='VuuXrf']")).Click();

            Assert.That(driver.Url, Is.EqualTo("https://people-travels.com/cuisines/uzbek-somsa"));
            Assert.That(driver.Title, Is.EqualTo("Uzbek samsa – a queen of Uzbek cuisine, history and origin of Uzbek somsa"));
            
            
        }

     

        [TearDown]
        public void TearDown() {
            driver.Quit();
        }
    }
}