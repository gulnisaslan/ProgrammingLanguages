from instagramUserInfo import username, password
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time

class Instagram:
     def __init__(self, username, password):
          self.browserProfile = webdriver.ChromeOptions()
          self.browserProfile.add_experimental_option('prefs', {'intl.accept_languages':'en,en_US'} )
          self.browser = webdriver.Chrome('chromedriver.exe', chrome_options=self.browserProfile)
          self.username = username
          self.password = password 
     

     def signIn(self):
          self.browser.get("https://www.instagram.com/accounts/login/")
          time.sleep(2)
          
          usernameInput = self.browser.find_element_by_xpath('//*[@id="loginForm"]/div/div[1]/div/label/input')
          passwordInput = self.browser.find_element_by_xpath('//*[@id="loginForm"]/div/div[2]/div/label/input')
          
          # self.usernameInput.send_keys(self.username)
          # self.passwordInput.send_keys(self.password) hatalı giriştir bu tekrarlanmasın.
          
          usernameInput.send_keys(self.username)
          passwordInput.send_keys(self.password)
          passwordInput.send_keys(Keys.ENTER)
          
          time.sleep(3)

     def getFollowers(self):

          self.browser.get(f"https://www.instagram.com/{self.username}")
          time.sleep(2)
          self.browser.find_element_by_xpath("xpath blgisi alınacak takipçiler sayfasından").click()
          time.sleep(3)
          
          dialog = self.browser.find_element_by_css_selector("div[role=dialog] ul")
          followerCount = len(followers=dialog.find_elements_by_css_selector("li"))
         
          print(f"Firts Count {followerCount}")

          action = webdriver.ActionChains(self.browser)
          while True:
               dialog.click()
               action.key_down(Keys.SPACE).key_up(Keys.SPACE).perform()
               time.sleep(2)

         
               newCount = len(followers=dialog.find_elements_by_css_selector("li"))
               if followerCount != newCount:
                    followerCount = newCount
                    print(f"Second Count : {newCount} ")
                    time.sleep(3)
               else:
                   break
          

          
          followers=dialog.find_elements_by_css_selector("li")
         
          for user in followers:
               link=user.find_element_by_css_selector("a").get_attribute("href")
               print(link)


     def followerUser(self, username):
          self.browser.get("https://www.instagram.com/"+ username)
          time.sleep(2)

          followButton = self.browser.find_element_by_tag_name("button")
          if followButton.text != "following":
               followButton.click
               time.sleep(2)
          else:
               print("zaten kullanıcıyı takip ediyorsun")

     def unFollowUser(self, username):
          self.browser.get("https://www.instagram.com/"+ username)
          time.sleep(2)

          followButton = self.browser.find_element_by_tag_name("button")
          if followButton == "Following":
               followButton.click()
               time.sleep(2)
               self.browser.find_element_by_xpath('//button[text()="UnFollow"]').click()
          else:
               print("zaten kullanıcıyı takip etmiyorsunuz.")








instagram=Instagram(username, password)
instagram.signIn()
#instagram.getFollowers()
instagram.followerUser("")
# instagram.unFollowUser()
# list = []
# for user in list:
#      instagram.followerUser(user)
#      time.sleep(3)







