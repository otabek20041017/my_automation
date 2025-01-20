package automation_projects.automation;


import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;

import java.util.concurrent.TimeUnit;

public class testing {

    public static void main(String[] args) throws Exception {

        ChromeOptions options = new ChromeOptions();
        options.addArguments("--lang=en-GB");
        options.addArguments("--disable-blink-features=AutomationControlled");
        options.addArguments("--start-maximized");

        WebDriver driver = new ChromeDriver(options);
        Thread.sleep(3000);
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        Thread.sleep(3000);
        driver.manage().window().maximize();
        Thread.sleep(3000);
        driver.get("https://www.google.com");
        Thread.sleep(3000);
        driver.findElement(By.xpath("//*[@title='Search']")).sendKeys("Multiplication table" + Keys.ENTER);
        driver.findElement(By.xpath("(//*[@class='VuuXrf'])[1]")).click();

        String actualTitle = "Multiplication Tables | Times Tables Charts | Maths Tables";
        String expectedTitle = driver.getTitle();

        //Assert.assertEquals(expectedTitle,actualTitle);

        Assert.assertEquals("This isn't true", expectedTitle, actualTitle);

        if (expectedTitle.equals(actualTitle)) {
            System.out.println("\n\nTitle value is mathching to expected Title value");
        } else {
            System.out.println("Title value is not matching try to look carefully");
        }

        System.out.println("\nWeb-Title's name equal = \""+ driver.getTitle() +"\"");

        Thread.sleep(10000);
        driver.quit();
    }

}
