#1-themoviedb.org=>film ve dizi arşivi
#2*themoviedb'nin sunduğu apiyi uygulamanızda kullanınız.
#3-anahtar kelimeye göre arayınız.
#4-En popüler film listesi
#5-vizyondaki film listesi

import requests
import json

class theMovieDb:
     def __init__(self):
          self.api_url="https://api.themoviedb.org/3"
          self.api_key="76a5969b94003bb8ed70158bd288b16a"

     def getPopulars(self):
          response = requests.get(f"{self.api_url}/movie/popular?api_key={self.api_key}&language=en-US&page=1")

          return response.json()

     def getSreachResults(self,keyword):
          response=requests.get(f"{self.api_url}/search/company?api_key={self.api_key}&query={keyword}&page=1")
          return response.json()
movieApi=theMovieDb()

while True:
     secim=input("1-Popular movies\n2-Sreach moives\n3-exit\nseçim:")   

     if secim=="3":
          break
     else:
          if secim=="1":
              moives= movieApi.getPopulars()
              for movie in moives["results"]:
                   print(movie("title"))
          if secim=="2":
              keyword=input("keyword: ")
              moives= movieApi.getSreachResults(keyword)
              for movie in moives["results"]:
                   print(movie["name"])

          
               
          


# web script=html etkiketleriiçinde saklanmıştır.
# html kodlarını içine saklanmış olan bilgileri requeats göndererek anlık bilgi alınır. bu alay web script denir.





