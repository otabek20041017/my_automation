package automation_projects.automation;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.interactions.Actions;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.Test;
import java.util.concurrent.TimeUnit;

public class dragAndDropDown {

    ChromeOptions options;
    WebDriver driver;

    @BeforeMethod
    public void settingUpDriver(){
        options = new ChromeOptions();
        options.addArguments("--lang=en-GB");
        options.addArguments("--diasable-blink-features=AutomationControlled");
        options.addArguments("--start-maximized");
        driver = new ChromeDriver(options);
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
    }

    @Test
    public void dragAndDropDownAutomation() {

        driver.get("https://demo.automationtesting.in/Static.html");
        Actions actions = new Actions(driver);
        WebElement angular = driver.findElement(By.xpath("//*[@*='angular']"));
        WebElement mongo = driver.findElement(By.id("mongo"));
        WebElement node = driver.findElement(By.id("node"));
        WebElement target = driver.findElement(By.xpath("//div[@*='droparea']"));


        for (int i = 0; i < 5; i++) {
            actions.dragAndDrop(angular, target).build().perform();
        }

        for (int i = 0; i < 5; i++) {
            actions.dragAndDrop(mongo, target).build().perform();
        }

        for (int i = 0; i < 5; i++) {
            actions.dragAndDrop(node, target).build().perform();
        }

    }

    @AfterMethod
    public void tearDown() throws InterruptedException {
        Thread.sleep(6000);
        driver.quit();
    }
}
