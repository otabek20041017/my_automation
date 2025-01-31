using NUnit.Framework;
using System.Reflection.PortableExecutable;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject1;

public class log_in_testing
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
        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
    }

    [Test, Order(1)]
    public void Positive_Log_In_Testing()
    {
        
        IWebElement userName = driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement positivePassword = driver.FindElement(By.XPath("//*[@id='password']"));
        userName.SendKeys("student");
        positivePassword.SendKeys("Password123");
        driver.FindElement(By.XPath("//*[@id='submit']")).Click();
        IWebElement texting = driver.FindElement(By.XPath("//h1[@class='post-title']"));
        string actualText = "Logged In Successfully";
        string expectedText = driver.FindElement(By.XPath("//*[@class='post-title']")).Text;
        string actualURL = "https://practicetestautomation.com/logged-in-successfully/";
        string expectedURL = driver.Url;
        Console.WriteLine("ERROR MESSAGE: " + texting.Displayed);
        Console.WriteLine("EXPECTED TEXT VALUE IS: ----> |" + expectedText + "| <---- This is TEXT value!");
        Console.WriteLine("URL's value: ----> |"+expectedURL+"| <--- This is URL value!");
        driver.FindElement(By.XPath("//a[@class='wp-block-button__link has-text-color has-background has-very-dark-gray-background-color']")).Click();

        if (expectedText.Equals(actualText)) 
        {
            Console.WriteLine("EXPECTED AND ACTUAL TEXT IS MATCHING TO EACH OTHER: ---> |" + expectedText + "| <---- This is value of EXPECTED TEXT!");
        }
        else
        {
            Console.WriteLine("EXPECTED AND ACTUAL TEXT IS NOT MATCHING TO EACH OTHER: ---> | " + expectedText + " | < ----This is value of EXPECTED TEXT!");
        }

        if (expectedURL.Equals(actualURL))
        {
            Console.WriteLine("EXPECTED AND ACTUAL URL IS MATCHING TO EACH OTHER: ---> |" + expectedURL + "| <---- This is value of EXPECTED URL!");
        }
        else
        {
            Console.WriteLine("EXPECTED AND ACTUAL URL IS NOT MATCHING TO EACH OTHER: ---> |" + expectedURL + "| <---- This is value of EXPECTED URL!");
        }
    }

    [Test, Order(2)]
    public void Negative_UserName_Test()
    {
        IWebElement incorrectUserName = driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement positivePassword = driver.FindElement(By.XPath("//*[@id='password']"));
        incorrectUserName.SendKeys("incorrectUser ");
        positivePassword.SendKeys("Password123");
        driver.FindElement(By.XPath("//*[@id='submit']")).Click();
        IWebElement invalidUserName = driver.FindElement(By.XPath("//div[@id='error']"));
        string actualInvalidUserName = "Your username is invalid!";
        var expectedInvalidUserName = driver.FindElement(By.XPath("//div[@id='error']"));
        string messageOfExpectedInavlidUserName = expectedInvalidUserName.Text;
        Console.WriteLine("ERROR MESSAGE: ---> " + invalidUserName.Displayed);
        Console.WriteLine("EXPECTATION OF MESSAGE: ----> |" + messageOfExpectedInavlidUserName + "| <---- This is the value of EXPECTED WARNING!!!");

        if (messageOfExpectedInavlidUserName.Equals(actualInvalidUserName))
        {
            Console.WriteLine("EXPECTED AND ACTUAL TEXT IS MATCHING TO EACH OTHER: ----> |" + messageOfExpectedInavlidUserName + "| <---- This is the value of EXPECTED TEXT!!!");
        }
        else
        {
            Console.WriteLine("EXPECTED AND ACTUAL TEXT IS MATCHING NOT TO EACH OTHER: ----> |" + messageOfExpectedInavlidUserName + "| <---- This is the value of EXPECTED TEXT!!!");
        }

    }

    [Test, Order(3)]
    public void Negative_Password_Test()
    {
        IWebElement correctUserName = driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement incorrectPassword = driver.FindElement(By.XPath("//*[@id='password']"));
        correctUserName.SendKeys("student");
        incorrectPassword.SendKeys("incorrectPassword");
        driver.FindElement(By.XPath("//*[@id='submit']")).Click();
        IWebElement invalidUserName = driver.FindElement(By.XPath("//div[@id='error']"));
        string actualInvalidPassword = "Your password is invalid!";
        var expectedInvalidPassword = driver.FindElement(By.XPath("//div[@class='show']"));
        string messageOfExpectedInavlidPassword = expectedInvalidPassword.Text;
        Console.WriteLine("ERROR MESSAGE: ---> " + invalidUserName.Displayed);
        Console.WriteLine("EXPECTATION OF MESSAGE: ----> |" + messageOfExpectedInavlidPassword + "| <---- This is the value of EXPECTED WARNING!!!");

        if (messageOfExpectedInavlidPassword.Equals(actualInvalidPassword))
        {
            Console.WriteLine("EXPECTED AND ACTUAL TEXT IS MATCHING TO EACH OTHER: ----> |" + messageOfExpectedInavlidPassword + "| <---- This is the value of EXPECTED TEXT!!!");
        }
        else
        {
            Console.WriteLine("EXPECTED AND ACTUAL TEXT IS MATCHING NOT TO EACH OTHER: ----> |" + messageOfExpectedInavlidPassword + "| <---- This is the value of EXPECTED TEXT!!!");
        }
    }

    [TearDown]
    public void tearDown()
    {
        driver.Quit();
    }
}
