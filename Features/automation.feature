Feature: Login Functionality
  Scenario: Verify user can log in with valid credentials
    Given the user navigates to "https://practicetestautomation.com/practice-test-login/"
    When the user enters "student" and "Password123"
    And clicks the submit button
    Then the user should be logged in successfully
