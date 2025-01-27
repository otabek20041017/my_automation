using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1;

public class radioButton
{
    IWebDriver driver;
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
    public void radioButtongAutomation()
    {
        driver.Navigate().GoToUrl("https://practice.expandtesting.com/radio-buttons");
        IWebElement blueButton = driver.FindElement(By.XPath("//*[@id='blue']"));
        IWebElement redButton = driver.FindElement(By.XPath("//*[@id='red']"));
        IWebElement yellowButton = driver.FindElement(By.XPath("//*[@id='yellow']"));
        IWebElement blackButton = driver.FindElement(By.XPath("//*[@id='black']"));

        IWebElement basketballButton = driver.FindElement(By.XPath("//*[@id='basketball']"));
        IWebElement footballButton = driver.FindElement(By.XPath("//*[@id='football']"));
        IWebElement tennisButton = driver.FindElement(By.XPath("//*[@id='tennis']"));

        Thread.Sleep(3000);
        redButton.Click();
        Thread.Sleep(3000);
        yellowButton.Click();
        Thread.Sleep(3000);
        blackButton.Click();
        Thread.Sleep(3000);
        yellowButton.Click();
        Thread.Sleep(3000);
        redButton.Click();
        Thread.Sleep(3000);
        blueButton.Click();

        // sport buttons
        Thread.Sleep(3000);
        footballButton.Click();
        Thread.Sleep(3000);
        basketballButton.Click();
        Thread.Sleep(3000);
        footballButton.Click();
        Thread.Sleep(3000);
        tennisButton.Click();
    }


    [TearDown]
    public void tearDown() 
    {
        Thread.Sleep(5000);
        driver.Quit();
    }
}
