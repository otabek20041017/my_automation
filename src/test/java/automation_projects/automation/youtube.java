package automation_projects.automation;

import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;

import java.util.concurrent.TimeUnit;

public class youtube {

    WebDriver driver;
    ChromeOptions options;
    @BeforeClass
    public void settingUp(){
        options = new ChromeOptions();
        options.addArguments("--lang=en-GB");
        options.addArguments("--disable-blink-features=AutomationControlled");
        options.addArguments("--start-maximized");
        driver = new ChromeDriver(options);
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);

    }

    @Test
    public void automatingYoutube(){

        driver.get("https://www.youtube.com");
        driver.findElement(By.xpath("//input[@*='ytSearchboxComponentInput yt-searchbox-input title']")).sendKeys("Eminem" + Keys.ENTER);
        driver.findElement(By.xpath("//*[@*='Eminem - Lose Yourself [HD]']")).click();

        String actualText = "Eminem - Lose Yourself [HD]";
        String expectedText = driver.findElement(By.xpath("//a[contains(@title, 'Eminem - Lose Yourself [HD]')]")).getText();
        System.out.println("SONG IS NAME -----> " + expectedText);
        Assert.assertEquals("TEXT IS NOT MATCHING", expectedText, actualText);



    }


    @AfterClass
    public void shuttingDown() throws InterruptedException {
        Thread.sleep(3000);
        driver.quit();
    }
}
