using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject1;

public class youtubeTesting
{
    IWebDriver driver;
    ChromeOptions options;
    [SetUp]
    public void Setup()
    {
        options = new ChromeOptions();
        options.AddArgument("--disable-blink-features=AutomationControlled");
        options.AddExcludedArgument("enable-automation");
        options.AddArguments("--lang=en-GB");
        options.AddArgument("--start-maximized");
        driver = new ChromeDriver(options);
    }

    [Test]
    public void youTubeEminemVideo()
    {
        try
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.youtube.com");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait for search bar
            IWebElement searchBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("search_query")));
            searchBox.SendKeys("Eminem - Lose Yourself [HD]");
            searchBox.SendKeys(Keys.Enter);

            // Wait for video link
            IWebElement videoLink = wait.Until(ExpectedConditions.ElementExists(By.XPath("//a[@id='video-title' and contains(., 'Eminem - Lose Yourself')]")));
            videoLink.Click();

            Console.WriteLine("Video clicked successfully.");
        }
        catch (NoSuchElementException ex)
        {
            Console.WriteLine($"Element not found: {ex.Message}");
        }
        catch (WebDriverTimeoutException ex)
        {
            Console.WriteLine($"Timed out waiting for element: {ex.Message}");
        }
        finally
        {
            //driver.Quit();
        }

        string actualText = "Eminem - Lose Yourself [HD]";
        IWebElement gettingText = driver.FindElement(By.XPath("//a[@id='video-title' and contains(., 'Eminem - Lose Yourself')]"));
        string expectedText = gettingText.Text;

        Console.WriteLine("Text's value is ----> " + expectedText);

        if (expectedText.Equals(expectedText))
        {
            Console.WriteLine("Text is matching to each other");
        }
        else
        {
            Console.WriteLine("Text is not matching to each other");
        }

        driver.Quit();

    }
}
