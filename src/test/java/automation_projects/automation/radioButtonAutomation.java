package automation_projects.automation;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;

import java.util.concurrent.TimeUnit;

public class radionButtonAutomation {

    ChromeOptions options;
    WebDriver driver;
    @BeforeMethod
    public void settingUpBrowser(){
        options = new ChromeOptions();
        options.addArguments("--lang=en-GB");
        options.addArguments("--diasable-blink-features=AutomationControlled");
        options.addArguments("--start-maximized");
        driver = new ChromeDriver(options);
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
    }

    @Test
    public void automating_radio_button() throws InterruptedException{

        driver.get("https://practice.expandtesting.com/radio-buttons");
        WebElement red = driver.findElement(By.xpath("//input[@id='red']"));
        Thread.sleep(4000);
        red.click();

        WebElement yellow = driver.findElement(By.xpath("//input[@id='yellow']"));
        Thread.sleep(4000);
        yellow.click();

        WebElement black = driver.findElement(By.xpath("//input[@id='black']"));
        Thread.sleep(4000);
        black.click();

        WebElement football = driver.findElement(By.xpath("//*[@id='football']"));
        Thread.sleep(4000);
        football.click();

        WebElement tennis = driver.findElement(By.xpath("//*[@id='tennis']"));
        Thread.sleep(4000);
        tennis.click();

        WebElement basketball = driver.findElement(By.xpath("//*[@id='basketball']"));
        //basketball.click();
        Thread.sleep(4000);
        yellow.click();

        Thread.sleep(4000);
        red.click();

        Thread.sleep(4000);
        WebElement blue = driver.findElement(By.xpath("//*[@id='blue']"));
        blue.click();

        Thread.sleep(4000);
        football.click();
        Thread.sleep(4000);
        basketball.click();

    }

    @AfterMethod
    public void tearDown() throws InterruptedException {
        Thread.sleep(6000);
        driver.quit();
    }
}
