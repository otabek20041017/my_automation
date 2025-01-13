package automation_projects.automation;

import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import java.util.concurrent.TimeUnit;

public class google {

    public static void main(String[] args) {

        WebDriver driver = new ChromeDriver();

        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);

        driver.manage().window().maximize();

        driver.get("https://www.google.com/");

        driver.findElement(By.xpath("//*[@title='Search']")).sendKeys("Uzbek noodle" + Keys.ENTER);

        driver.findElement(By.xpath("//*[@*='VuuXrf']")).click();

    }
}
