import time
import unittest
from webbrowser import Chrome

from selenium import webdriver
from selenium.webdriver import ActionChains
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.chromium.options import ChromiumOptions
from selenium.webdriver.common.keys import Keys
from  selenium.webdriver.common.by import By



class MyTestCase(unittest.TestCase):

    def setUp(self):
        options = Options()
        options.add_experimental_option("detach", True)
        options.add_argument("--disable-blink-features=AutomationControlled")
        options.add_argument("enable-automation")
        options.add_argument("--start-maximized")
        options.add_argument("--lang=en-GB")
        # Setup WebDriver (use the browser driver of your choice, e.g., Chrome, Firefox)
        self.driver = webdriver.Chrome(options)  # Replace with `webdriver.Firefox()` for Firefox
        self.driver.implicitly_wait(10)  # Implicit wait for elements
        self.driver.maximize_window()


    def test_something(self):
        driver = self.driver
        driver.get("https://practicetestautomation.com/practice-test-login/")
        driver.find_element(By.ID, "username").send_keys("student")
        driver.find_element(By.ID, "password").send_keys("Password")
        driver.find_element(By.XPATH, "//*[@id='submit']").click()

        expected_title = "Test Login | Practice Test Automation"
        actual_title = driver.title

        print(actual_title)
        self.assertEqual(expected_title, actual_title, "Login Failed")

    def tearDown(self):
        self.driver.quit()

if __name__ == '__main__':
    unittest.main()
