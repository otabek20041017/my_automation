package automation_projects.step_definitions;

import io.cucumber.java.en.And;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import org.junit.Assert;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import java.util.concurrent.TimeUnit;

public class positive_automation_testing {

    public static final WebDriver driver = new ChromeDriver();

    @Given("I'm openning {string}")
    public void openingWebSite(String url) {
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        driver.manage().window().maximize();
        driver.get(url);
    }


    @When("the user enters {string} and {string}")
    public void enteringValues(String student, String password) {
        driver.findElement(By.xpath("//*[@id='username']")).sendKeys(student);
        driver.findElement(By.xpath("//input[@id='password']")).sendKeys(password);
    }


    @And("clicks the submit button")
    public void clickingSubmitButton(){
        driver.findElement(By.xpath("//*[@id='submit']")).click();
    }

    @Then("The user should be logged in successfully")
    public void successfullFrame(){

        String actualTitle = "Logged In Successfully | Practice Test Automation";
        String expectedTitle = driver.getTitle();

        Assert.assertEquals("FALSE", expectedTitle, actualTitle);



        driver.quit();

    }

}
