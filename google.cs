using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Diagnostics.Metrics;

namespace TestProject1;

public class google
{
    public IWebDriver driver;
    [SetUp]
    public void Setup()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--disable-blink-features=AutomationControlled");
        options.AddExcludedArgument("enable-automation");
        options.AddArgument("--start-maximized");
        options.AddArguments("--lang=en-GB");
        driver = new ChromeDriver(options);
        //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10)); 
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void uzbekNoodleTesting()
    {
        
        driver.Navigate().GoToUrl("https://google.com");
        Thread.Sleep(4000);
        driver.FindElement(By.XPath("//*[@*='Search']")).SendKeys("Uzbek noodle" + Keys.Enter);
        Thread.Sleep(4000);
        driver.FindElement(By.XPath("//*[@*='VuuXrf']")).Click();
        Thread.Sleep(4000);
        string actualText = "Uzbek Laghman Traditional Noodle Dish";
        IWebElement element = driver.FindElement(By.XPath("//*[@class='blog-item-title']/h1"));
        string expectedText = element.Text;
        string actualWebSiteTitle = "Uzbek Laghman Traditional Noodle Dish — Naturally Zuzu";
        string expectedWebSiteTitle = driver.Title;
        //Assert.That(actualText, Is.EqualTo(expectedText));

        if (expectedText.Equals(actualText))
        {
            Console.WriteLine("==========   TEXT IT'S MATCHING WITH ACTUAL AND EXPECTED TO EACH OTHER                   ==========");
        }
        else
        {
            Console.WriteLine("==========   TEXT IT'S NOT MATCHING WITH ACTUAL AND EXPECTED TO EACH OTHER   ==========");
        }

        //====================================================================================================================
        //====================================================================================================================
        //====================================================================================================================
        //                          SECOND IF-ELSE STATEMENT FOR WEB TITLE SECTION
        //      ==========   WEB-SITE TITLE IT'S MATCHING WITH ACTUAL AND EXPECTED TO EACH OTHER         ==========
        //      ==========   TEXT IT'S MATCHING WITH ACTUAL AND EXPECTED TO EACH OTHER                   ==========
        if (expectedWebSiteTitle.Equals(actualWebSiteTitle))
        {
            Console.WriteLine("==========   WEB-SITE TITLE IT'S MATCHING WITH ACTUAL AND EXPECTED TO EACH OTHER         ==========");
        }
        else
        {
            Console.WriteLine("==========   WEB-SITE TITLE IT'S NOT MATCHING WITH ACTUAL AND EXPECTED TO EACH OTHER     ==========");
        }

        Console.WriteLine("\n================================================================================== \n");
        Console.WriteLine("EXPECTED TEXT VALUE:      -----> " +  "\"" + expectedText + "\"");
        Console.WriteLine("EXPECTED WEB SITE VALUE:  -----> " + "\"" + expectedWebSiteTitle + "\"");
        Console.WriteLine("Hello Otabek Ozbeg");
    }

    [TearDown]
    public void TearDown()
    {
        Thread.Sleep(10000);
        driver.Quit();
    }
}
