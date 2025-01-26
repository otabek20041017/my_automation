import time

from selenium import webdriver
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.common.by import By
from selenium.webdriver.support.select import Select

options = Options()
options.add_experimental_option("detach", True)
options.add_argument("--disable-blink-features=AutomationControlled")
options.add_argument("enable-automation")
options.add_argument("--start-maximized")
options.add_argument("--lang=en-GB")

driver = webdriver.Chrome(options=options)
driver.implicitly_wait(10)
driver.get("https://formstone.it/components/dropdown/demo/")

select_label = driver.find_element(By.XPATH, "//select[@id='demo_basic']")
select_label = Select(select_label)
select_label.select_by_value("2")


select_demo = driver.find_element(By.XPATH, "//select[@id='demo_groups']")
select_demo = Select(select_demo)
select_demo.select_by_value("6")

select_cover = driver.find_element(By.XPATH, "//select[@id='demo_cover']")
select_cover = Select(select_cover)
select_cover.select_by_value("5")

select_native = driver.find_element(By.XPATH, "//select[@id='demo_native']")
select_native = Select(select_native)
select_cover.select_by_value("2")


select_state = driver.find_element(By.XPATH, "//select[@id='demo_label']")
select_state = Select(select_state)
select_state.select_by_value("TX")

select_custom = driver.find_element(By.XPATH, "//select[@id='demo_custom_1']")
select_custom = Select(select_custom)
select_custom.select_by_value("3")

select_customHTML = driver.find_element(By.XPATH, "//select[@id='demo_custom_2']")
select_customHTML = Select(select_customHTML)
select_customHTML.select_by_value("4")

select_demoBasic2 = driver.find_element(By.XPATH, "//select[@id='demo_basic_2']")
select_demoBasic2 = Select(select_demoBasic2)
select_demoBasic2.select_by_value("NV")
time.sleep(6)
driver.quit()
