package automation_projects.automation;

import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeOptions;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;

public class practice_test_automation {

    ChromeOptions options;
    WebDriver driver;

    @BeforeClass
    public void setUp(){
        options = new ChromeOptions();
        options.addArguments("--lang=en-GB");
        options.addArguments("--diasable-blink-features=AutomationControlled");
        options.addArguments("--start-maximized");
        driver = new ChromeDriver(options);
    }

    @Test (priority = 1)
    public void positiveTest() {
        driver.get("https://practicetestautomation.com/practice-test-login/");
        WebElement userName = driver.findElement(By.xpath("//input[@id='username']"));
        userName.sendKeys("student");
        userName.sendKeys(Keys.ENTER);

        WebElement password = driver.findElement(By.id("password"));
        password.sendKeys("Password123");
        password.sendKeys(Keys.ENTER);

        driver.findElement(By.className("btn")).click();

        String actualURL = "https://practicetestautomation.com/logged-in-successfully/";
        String expectedURL = driver.getCurrentUrl();

        String actualText = "Congratulations student. You successfully logged in!";
        String expectedText = driver.findElement(By.className("has-text-align-center")).getText();

        System.out.println("\n========= TEST 1 POSITIVE LOG-IN TEST ==========\n");

        if(expectedURL.equals(actualURL)){
            System.out.println("EXPECTED AND ACTUAL URL IS MATCHING SUCCESSFULLY");
        } else {
            System.out.println("EXPECTED AND ACTUAL URL IS NOT MATCHING SUCCESSFULLY");
        }

        if (expectedText.equals(actualText)) {
            System.out.println("EXPECTED AND ACTUAL TEXT IS MATCHING SUCCESSFULLY \n");
        } else {
            System.out.println("EXPECTED AND ACTUAL TEXT IS MATCHING SUCCESSFULLY");
        }

        System.out.println("URL's value: ----> " + expectedURL + "\n");
        System.out.println("Verifying new page's Text: ----> " + expectedText);

        driver.findElement(By.xpath("//a[@class='wp-block-button__link has-text-color has-background has-very-dark-gray-background-color']")).click();
    }

    @Test(priority = 2)
    public void negativeUserNameTest() {
        WebElement negativeUserName = driver.findElement(By.xpath("//input[@id='username']"));
        negativeUserName.sendKeys("incorrectUser");
        negativeUserName.sendKeys(Keys.ENTER);

        WebElement passwordNegative = driver.findElement(By.id("password"));
        passwordNegative.sendKeys("Password123");
        passwordNegative.sendKeys(Keys.ENTER);

        driver.findElement(By.className("btn")).click();
        WebElement displayed = driver.findElement(By.id("error"));
        String actual_isDiplayedText = "Your username is invalid!";
        String expected_isDisplayedText = displayed.getText();
        System.out.println("\n\n========= TEST 2 NEGATIVE USERNAME TEST ==========");
        System.out.println("\nERROR MESSAGE: " + displayed.isDisplayed());
        System.out.println("VALUE OF ERROR MESSAGE: ----> " + expected_isDisplayedText);

        if (expected_isDisplayedText.equals(actual_isDiplayedText)) {
            System.out.println("ERROR MESSAGE MATCHING TO EAH OTHER WITH ACTUAL AND EXPECTED");
        } else {
            System.out.println("ERROR MESSAGE IS NOT MATCHING TO EAH OTHER WITH ACTUAL AND EXPECTED");
        }
    }

    @Test(priority = 3)
    public void negativePasswordTest() {
        WebElement username = driver.findElement(By.xpath("//input[@id='username']"));
        username.sendKeys("student");
        username.sendKeys(Keys.ENTER);

        WebElement incorrectPassword = driver.findElement(By.id("password"));
        incorrectPassword.sendKeys("incorrectPassword");
        incorrectPassword.sendKeys(Keys.ENTER);

        driver.findElement(By.className("btn")).click();
        WebElement displayed = driver.findElement(By.id("error"));
        String actual_isDiplayedText = "Your password is invalid!";
        String expected_isDisplayedText = displayed.getText();
        System.out.println("\n\n========= TEST 3 INCORRECT PASSWORD TEST ==========");
        System.out.println("\nERROR MESSAGE: " + displayed.isDisplayed());
        System.out.println("VALUE OF ERROR MESSAGE: ----> " + expected_isDisplayedText);

        if (expected_isDisplayedText.equals(actual_isDiplayedText)) {
            System.out.println("ERROR MESSAGE MATCHING TO EAH OTHER WITH ACTUAL AND EXPECTED");
        } else {
            System.out.println("ERROR MESSAGE IS NOT MATCHING TO EAH OTHER WITH ACTUAL AND EXPECTED");
        }
    }

    @AfterClass
    public void tearDown() throws InterruptedException {
        Thread.sleep(3000);
        driver.quit();
    }
}
