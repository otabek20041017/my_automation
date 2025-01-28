import time
import unittest

from selenium import webdriver
from selenium.webdriver import Keys
from selenium.webdriver.chrome.options import Options
from  selenium.webdriver.common.by import By


class MyYouTube(unittest.TestCase):

    def setUp(self):
        options = Options()
        options.add_experimental_option("detach", True)
        options.add_argument("--disable-blink-features=AutomationControlled")
        options.add_argument("enable-automation")
        options.add_argument("--start-maximized")
        options.add_argument("--lang=en-GB")
        self.driver = webdriver.Chrome(options)
        self.driver.implicitly_wait(10)

    def test_youtube_video(self):
        driver = self.driver
        driver.get("https://youtube.com")
        driver.find_element(By.XPATH, "//input[@*='ytSearchboxComponentInput yt-searchbox-input title']").send_keys("Eminem" + Keys.ENTER)
        eminemVideo = driver.find_element(by=By.XPATH, value="//*[@*='Eminem - Lose Yourself [HD]']")
        eminemVideo.click()
        expectedYouTubeText = driver.find_element(By.XPATH, "//a[contains(@title, 'Eminem - Lose Yourself [HD]')]").text
        print(expectedYouTubeText)
        assert expectedYouTubeText == "Eminem - Lose Yourself [HD]"

    def tearDown(self):
        time.sleep(3)
        self.driver.quit()


if __name__ == '__main__':
    unittest.main()
