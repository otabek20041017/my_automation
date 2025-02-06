Feature: Positive Automation

  Scenario: Run positive Testing
    Given I open web-site url "https://practicetestautomation.com/practice-test-login/"
    When  I enter "student" log-in and "Password123" password
    When I click the submit button
    Then  the user should be logged in successfully