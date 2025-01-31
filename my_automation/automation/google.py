import time


from selenium import webdriver
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.chromium.options import ChromiumOptions
from selenium.webdriver.common.keys import Keys
from  selenium.webdriver.common.by import By
from selenium.webdriver.remote.webelement import WebElement

options = ChromiumOptions()
options = Options()
options.add_argument("--lang=en-GB")
options.add_experimental_option("detach", True)
options.add_argument("--disable-blink-features=AutomationControlled")
options.add_argument("enable-automation")
options.add_argument("--start-maximized")
driver = webdriver.Chrome(options)

driver.maximize_window()
driver.implicitly_wait(10)

driver.get("https://google.com/")
time.sleep(2)
driver.find_element(By.XPATH, "//*[@title='Search']").send_keys("Uzbek noodle" + Keys.ENTER)
driver.find_element(By.XPATH, "//span[.='Naturally Zuzu']").click()


actualText = "Uzbek Laghman Traditional Noodle Dish"
actualWebTitle = "Uzbek Laghman Traditional Noodle Dish — Naturally Zuzu"
expectedText = driver.find_element(By.XPATH, "//h1[@class='entry-title entry-title--large p-name preScale scaleIn']").text
expectedWebTitle = driver.title
title = expectedWebTitle
text = expectedText


print("\nTEXT IS VALUE -----> " + text)
print("WEB-SITE'S TITLE -----> " + title)
print("\n")
if expectedWebTitle == actualWebTitle:
     print("===== WEB TITLE IS MATCHING =====")
else:
    print("===== WEB TITLE ISN'T MATCHING =====")

if expectedText == actualText:
    print("===== TEXT IS MATCHING      =====")
else:
     print("===== TEXT ISN'T MATCHING =====")

time.sleep(7)
driver.quit()
#input("") ITS TO PREVENT FROM AUTOCLOSING

