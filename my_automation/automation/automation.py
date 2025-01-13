import time
# Specify the path to the WebDriver executable if not in PATH
# This is how you import in Python on PyCharm IDE
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By

# No need to specify path if added to PATH
driver = webdriver.Chrome()
# It's not similar to Java maximize method but Java one is "driver.manage().window().maximize"
driver.maximize_window()
# This is similar to Java one but, you don't need to write "TimeUnit.SECONDS"
driver.implicitly_wait(10)
# It is same like Java one
driver.get("https://practicetestautomation.com/practice-test-login/")
# You don't need to declare "WebElement" like Java and driver.find_elemet(By.XPATH, "") is different from Java one
log_in_box = driver.find_element(By.XPATH, "//*[@name='username']")
log_in_box.send_keys("student", Keys.ENTER)
# Thread.sleep(3000)millis but in Python one is time.sleep
time.sleep(10)
password_box = driver.find_element(By.XPATH, "//*[@id='password']")
password_box.send_keys("Password123", Keys.ENTER)
time.sleep(10)
submit_button = driver.find_element(By.CLASS_NAME, "btn")
submit_button.click()
time.sleep(10)
# same like Java one without semicolon
driver.quit()
time.sleep(8)