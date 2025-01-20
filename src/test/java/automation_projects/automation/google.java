package automation_projects.automation;

import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;

import java.util.concurrent.TimeUnit;

public class google {

    public static void main(String[] args) throws Exception {

        ChromeOptions options = new ChromeOptions();
        options.addArguments("--lang=en-GB");
        options.addArguments("--disable-blink-features=AutomationControlled");
        options.addArguments("--start-maximized");
        WebDriver driver = new ChromeDriver(options);

        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        driver.manage().window().maximize();

        driver.get("https://www.google.com/");
        Thread.sleep(5000);
        driver.findElement(By.xpath("//*[@title='Search']")).sendKeys("Uzbek noodle" + Keys.ENTER);
        Thread.sleep(5000);
        driver.findElement(By.xpath("//*[@*='VuuXrf']")).click();

        String actualTitle = "Uzbek Laghman Traditional Noodle Dish — Naturally Zuzu";
        String expectedTitle = driver.getTitle();
        String expectedText = driver.findElement(By.xpath("//*[@*='entry-title entry-title--large p-name preScale scaleIn']")).getText();
        String actualText = "Uzbek Laghman Traditional Noodle Dish";
        if (expectedText.equals(actualText)) {
            System.out.println("\n===== IT'S MATCHING TO ITS TEXT VALUE =====");
        } else {
            System.out.println("\n===== IT'S NOT MATCHING TO ITS TEXT VALUE =====");
        }

        if (expectedTitle.equals(actualTitle)) {
            System.out.println("\n===== WEB TITLE's VALUE ITS MATCHING =====");
        } else {
            System.out.println("\n===== WEB TITLE'S VALUE IT'S NOT MATCHING =====");
        }
        Thread.sleep(4000);
        driver.quit();
    }
}
