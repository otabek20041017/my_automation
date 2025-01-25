package automation_projects.automation;

import io.cucumber.java.eo.Se;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.support.ui.Select;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;

import java.util.concurrent.TimeUnit;

public class select {

    ChromeOptions options;
    WebDriver driver;
    @BeforeMethod
    public void setUp(){
        options = new ChromeOptions();
        options.addArguments("--lang=en-GB");
        options.addArguments("--diasable-blink-features=AutomationControlled");
        options.addArguments("--start-maximized");
        driver = new ChromeDriver(options);
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
    }

    @Test
    public void automation_Of_Calculation_Of_Age() throws InterruptedException{
        driver.get("https://formstone.it/components/dropdown/demo/");
        Select selectLabel = new Select(driver.findElement(By.xpath("//select[@id='demo_basic']")));
        selectLabel.selectByValue("2");

        Select selectDemo = new Select(driver.findElement(By.xpath("//select[@id='demo_groups']")));
        selectDemo.selectByValue("6");

        Select selectCover = new Select(driver.findElement(By.xpath("//select[@id='demo_cover']")));
        selectCover.selectByValue("5");

        Select selectNative = new Select(driver.findElement(By.xpath("//select[@id='demo_native']")));
        selectNative.selectByValue("2");

        Select selectState = new Select(driver.findElement(By.xpath("//select[@id='demo_label']")));
        selectState.selectByValue("TX");

        Select custom = new Select(driver.findElement(By.xpath("//select[@id='demo_custom_1']")));
        custom.selectByValue("3");

        Select customHTML_Lables = new Select(driver.findElement(By.xpath("//select[@id='demo_custom_2']")));
        customHTML_Lables.selectByValue("4");

//        Select goingToURL = new Select(driver.findElement(By.xpath("//select[@id='demo_links']")));
//        goingToURL.selectByValue("http://google.com");
//        driver.close();
//
//
//        Select externalLinks = new Select(driver.findElement(By.xpath("//select[@id='demo_external']")));
//        externalLinks.selectByValue("http://cnn.com");
//        driver.close();

        Select demoBasic2 = new Select(driver.findElement(By.xpath("//select[@id='demo_basic_2']")));
        demoBasic2.selectByValue("NV");

        Thread.sleep(7000);
        driver.quit();

    }
}
