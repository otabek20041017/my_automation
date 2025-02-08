Feature: Positive Testing Log-In automation

  @otabek
  Scenario: I'm doing automation
    Given I'm openning "https://practicetestautomation.com/practice-test-login/"
    When the user enters "student" and "Password123"
    And clicks the submit button
    Then The user should be logged in successfully