using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject1;

public class selectingHTML
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
    public void automatingSelectingWebSite()
    {
        driver.Navigate().GoToUrl("https://formstone.it/components/dropdown/demo/");
        var selectLabel = driver.FindElement(By.XPath("//select[@id='demo_basic']"));
        var selectingLabel = new SelectElement(selectLabel);
        selectingLabel.SelectByValue("2");

        var selectDemo = driver.FindElement(By.XPath("//select[@id='demo_groups']"));
        var selectingDemo = new SelectElement(selectDemo);
        selectingDemo.SelectByValue("6");

        var selectCover = driver.FindElement(By.XPath("//select[@id='demo_cover']"));
        var selectingCover = new SelectElement(selectCover);
        selectingCover.SelectByValue("5");

        var selectNative = driver.FindElement(By.XPath("//select[@id='demo_native']"));
        var selectingNative = new SelectElement(selectNative);
        selectingNative.SelectByValue("2");

        var selectState = driver.FindElement(By.XPath("//select[@id='demo_label']"));
        var selectingState = new SelectElement(selectState);
        selectingState.SelectByValue("TX");

        var custom = driver.FindElement(By.XPath("//select[@id='demo_custom_1']"));
        var customing = new SelectElement(custom);
        customing.SelectByValue("3");

        var customHTML = driver.FindElement(By.XPath("//select[@id='demo_custom_2']"));
        var customingHTML = new SelectElement(customHTML);
        customingHTML.SelectByValue("4");


        var demoBasic2 = driver.FindElement(By.XPath("//select[@id='demo_basic_2']"));
        var demoBasics2 = new SelectElement(demoBasic2);
        demoBasics2.SelectByValue("NV");

    }


    [TearDown]
    public void TearDown()
    {
        Thread.Sleep(7000);
        driver.Quit();
    }
}
