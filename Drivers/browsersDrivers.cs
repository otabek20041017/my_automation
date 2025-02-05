using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SpecFlowSeleniumProject.Drivers
{
    public class browsersDrivers
    {
        public ChromeOptions options;
        public IWebDriver driver;

        public IWebDriver InitDriver(string browser)
        {
            
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentException("Browser not supported: " + browser);
            }

            driver.Manage().Window.Maximize();
            return driver;
        }

        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
