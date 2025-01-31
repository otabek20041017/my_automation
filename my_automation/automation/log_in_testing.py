import unittest
from selenium import webdriver
from selenium.webdriver import Keys
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.common.by import By




class My_Log_In_Test(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        options = Options()
        options.add_experimental_option("detach", True)
        options.add_argument("--disable-blink-features=AutomationControlled")
        options.add_argument("enable-automation")
        options.add_argument("--start-maximized")
        options.add_argument("--lang=en-GB")
        cls.driver = webdriver.Chrome(options)
        cls.driver.implicitly_wait(10)
        cls.driver.get("https://practicetestautomation.com/practice-test-login/")




    def test_1_positive_logging(self):
        driver = self.driver
        userName = driver.find_element(by=By.XPATH, value="//input[@id='username']")
        userName.send_keys("student")
        userName.send_keys(Keys.ENTER)

        password = driver.find_element(by=By.ID, value="password")
        password.send_keys("Password123")
        password.send_keys(Keys.ENTER)

        driver.find_element(by=By.ID, value="submit").click()



        print("========== TEST 1 POSITIVE LOG IN TEST ==========")
        actualURL = "https://practicetestautomation.com/logged-in-successfully/"
        expectedText = driver.find_element(by=By.XPATH, value="//h1[@class='post-title']")


        print("ERROR MESSAGE: ----> " + str(expectedText.is_displayed()))
        print("URL VALUE:     ----> "+ str(driver.current_url))


        expectedCurrentURL = driver.current_url
        if expectedCurrentURL == "https://practicetestautomation.com/logged-in-successfully/":
            print("EXPECTED AND ACTUAL URLS MATCHING: ---> |=>" + str(expectedCurrentURL) + "<=| <--- This one its value!")
        else:
            print("EXPECTED AND ACTUAL URLS IS MATCHING: ---> |=>" + str(expectedCurrentURL) + "<=| <--- This one its value!")

        if  "Logged In Successfully" == expectedText.text:
            print("EXPECTED TEXT AND ACTUAL IS MATCHING |=>" + expectedText.text + "<=| <---- This one its value")
        else:
            print("EXPECTED TEXT AND ACTUAL IS NOT MATCHING |=>" + expectedText.text + "<=| <---- This one its value")

        driver.find_element(by=By.XPATH, value="//a[@class='wp-block-button__link has-text-color has-background has-very-dark-gray-background-color']").click()

    def test_2_negative_username(self):
        driver = self.driver
        incorrectUserName = driver.find_element(by=By.XPATH, value="//input[@id='username']")
        incorrectUserName.send_keys("incorrectUser")
        incorrectUserName.send_keys(Keys.ENTER)

        negativePassword = driver.find_element(by=By.ID, value="password")
        negativePassword.send_keys("Password123")
        negativePassword.send_keys(Keys.ENTER)

        driver.find_element(by=By.ID, value="submit").click()

        print("\n========== TEST 2 NEGATIVE USERNAME TEST ==========")

        expectedErrorMessage = driver.find_element(By.XPATH, "//*[@class='show']")
        print("ERROR MESSAGE: ----> " + str(expectedErrorMessage.is_displayed()))
        print("TEXT VALUE:     ----> " + str(expectedErrorMessage.text))
        driver.find_element(By.ID, "submit").click()
        if "Your username is invalid!" == expectedErrorMessage.text:
            print("EXPECTED TEXT AND ACTUAL IS MATCHING |=>" + expectedErrorMessage.text + "<=| <---- This one its value!")
        else:
            print("EXPECTED TEXT AND ACTUAL IS NOT MATCHING |=>" + expectedErrorMessage.text + "<=| <---- This one its value!")

    def test_3_negative_password(self):
        driver = self.driver
        correctUserName = driver.find_element(by=By.XPATH, value="//input[@id='username']")
        correctUserName.send_keys("student")
        correctUserName.send_keys(Keys.ENTER)

        incorrectPassword = driver.find_element(by=By.ID, value="password")
        incorrectPassword.send_keys("incorrectPassword")
        incorrectPassword.send_keys(Keys.ENTER)

        driver.find_element(by=By.ID, value="submit").click()

        print("\n========== TEST 3 NEGATIVE PASSWORD TEST ==========")
        expectedIncorrectPassword = driver.find_element(By.XPATH, "//div[@class='show']")
        print("ERROR MESSAGE: ----> " + str(expectedIncorrectPassword.is_displayed()))
        print("TEXT VALUE:     ----> " + str(expectedIncorrectPassword.text))

        if "Your password is invalid!"  == expectedIncorrectPassword.text:
            print("EXPECTED TEXT AND ACTUAL IS MATCHING |=>" + expectedIncorrectPassword.text + "<=| <---- This one its value!")
        else:
            print("EXPECTED TEXT AND ACTUAL IS NOT MATCHING |=>" + expectedIncorrectPassword.text + "<=| <---- This one its value!")



    @classmethod
    def tearDownClass(cls):
        """Runs once after all test cases"""
        if cls.driver:
            cls.driver.quit()
            print("Browser closed successfully.")


if __name__ == '__main__':
    unittest.main()
