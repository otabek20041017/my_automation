import unittest
from selenium import webdriver
from selenium.webdriver.common.by import By

from selenium.webdriver.chrome.options import Options
from behave import given, when, then
import unittest


class MyPositiveBehaveTestCase(unittest.TestCase):
    pass

    def before_scenario(context):
        options = Options()
        options.add_experimental_option("detach", True)
        options.add_argument("--disable-blink-features=AutomationControlled")
        options.add_argument("enable-automation")
        options.add_argument("--start-maximized")
        options.add_argument("--lang=en-GB")
        # Setup WebDriver (use the browser driver of your choice, e.g., Chrome, Firefox)
        context.driver = webdriver.Chrome(options)  # Replace with `webdriver.Firefox()` for Firefox
        context.driver.implicitly_wait(10)  # Implicit wait for elements
        context.driver.maximize_window()

    def after_scenario(context, scenario):
        context.driver.quit()

    @given("I open web-site '{url}'")
    def step_navigate_to_url(context, url):
        driver = context.driver
        driver.get(url)

    @when('the user enters "{username}" and "{password}"')
    def step_enter_credentials(context, username, password):
        context.driver.find_element(By.ID, "username").send_keys(username)
        context.driver.find_element(By.ID, "password").send_keys(password)

    @when('clicks the submit button')
    def step_click_login_button(context):
        context.driver.find_element(By.ID, "submit").click()

    @then('the user should be logged in successfully')
    def step_verify_login(context):
        expected_title = "Logged In Successfully | Practice Test Automation"
        actual_title = context.driver.title
        unittest.TestCase().assertEqual(expected_title, actual_title, "Login failed")

if __name__ == '__main__':
    unittest.main()
