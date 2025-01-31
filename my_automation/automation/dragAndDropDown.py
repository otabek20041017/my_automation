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

    def test_google_search(self):
        driver = self.driver
        driver.get("https://demo.automationtesting.in/Static.html")
        angular = driver.find_element(By.XPATH, "//*[@*='angular']")
        mongo = driver.find_element(By.ID, "mongo")
        node = driver.find_element(By.ID, "node")
        dropBox = driver.find_element(By.XPATH, "//div[@*='droparea']")



        actions = ActionChains(driver)
        #actions.drag_and_drop(angular, dropBox).perform()
        print("dropping angulars ...")
        for angulars in range(5):

            angulars = actions.drag_and_drop(angular, dropBox).perform()
            print(angulars)

        print("dropping mongos ...")
        for mongos in range(5):
            mongos = actions.drag_and_drop(mongo, dropBox).perform()
            print(mongos)

        print("dropping nodes ...")
        for nodes in range(5):
            nodes = actions.drag_and_drop(node, dropBox).perform()
            print(nodes)

        print("ending of for looping ...")



    def tearDown(self):
        time.sleep(7)
        # Close the browser
        self.driver.quit()

if __name__ == "__main__":
    unittest.main(verbosity=2)
