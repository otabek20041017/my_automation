using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace TestProject1;

public class dragAndDropDown
{

    public IWebDriver driver;
    ChromeOptions options;
    [SetUp]
    public void Setup()
    {
        options = new ChromeOptions();
        options.AddArgument("--disable-blink-features=AutomationControlled");
        options.AddExcludedArgument("enable-automation");
        options.AddArgument("--start-maximized");
        options.AddArguments("--lang=en-GB");
        driver = new ChromeDriver(options);
        
        
    }

    [Test]
    public void DragAndDropDown()
    {
        driver.Navigate().GoToUrl("https://demo.automationtesting.in/Static.html");
        Actions actions = new Actions(driver);
        IWebElement angular = driver.FindElement(By.XPath("//*[@*='angular']"));
        IWebElement mongo = driver.FindElement(By.Id("mongo"));
        IWebElement node = driver.FindElement(By.Id("node"));
        IWebElement target = driver.FindElement(By.XPath("//div[@*='droparea']"));

        for (int i = 0; i < 5; i++)
        {
            actions.DragAndDrop(angular, target).Build().Perform();
        }


        for (int i = 0; i < 5; i++)
        {
            actions.DragAndDrop(mongo, target).Build().Perform();
        }


        for (int i = 0; i < 5; i++)
        {
            actions.DragAndDrop(node, target).Build().Perform();
        }
    }


    [TearDown]
    public void TearDown()
    {
        Thread.Sleep(7000);
        driver.Quit();
    }
}
