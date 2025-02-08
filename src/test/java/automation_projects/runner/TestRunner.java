package automation_projects.runner;

import io.cucumber.junit.Cucumber;
import io.cucumber.junit.CucumberOptions;
import org.junit.runner.RunWith;

@RunWith(Cucumber.class)
@CucumberOptions(

        plugin = {
                "pretty",
                "json:target/cucumber-reports/Cucumber.json",
                "html:target/cucumber-reports/html-report.html"
        },
        features = "src/test/resources/features",
        glue = "automation_projects/step_definitions",
        tags = "@otabek",
        dryRun = false
)
public class TestRunner{

}
