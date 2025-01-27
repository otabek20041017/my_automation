import time
import unittest

from selenium import webdriver
from selenium.webdriver.chrome.options import Options
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

    def test_radio_button(self):

        driver = self.driver
        driver.get("https://practice.expandtesting.com/radio-buttons")
        red_button = driver.find_element(By.XPATH, "//*[@id='red']")
        time.sleep(4)
        red_button.click()
        yellow_button = driver.find_element(By.XPATH, "//*[@id='yellow']")
        time.sleep(4)
        yellow_button.click()
        black_button = driver.find_element(By.XPATH, "//*[@id='black']")
        time.sleep(4)
        black_button.click()
        time.sleep(3)
        yellow_button.click()
        red_button.click()
        blue_button = driver.find_element(By.XPATH, "//*[@id='blue']")
        blue_button.click()

        basketball_button = driver.find_element(By.XPATH, "//*[@id='basketball']")
        football_button = driver.find_element(By.XPATH, "//*[@id='football']")
        tennis_button = driver.find_element(By.XPATH, "//*[@id='tennis']")

        time.sleep(3)
        football_button.click()
        time.sleep(3)
        basketball_button.click()
        time.sleep(3)
        football_button.click()
        time.sleep(3)
        tennis_button.click()


    def tearDown(self):
        time.sleep(5)
        self.driver.quit()


if __name__ == '__main__':
    unittest.main()
