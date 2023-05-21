import os
import datetime
# result=dir(os)
# result=os.name#işletim sisteminin türü

#******ETKİN DİZİN ÖĞRENME*****
# result=os.getcwd()#dosyanın hangi klasörde oldugunu gösterir.
#******KLASÖR OLUŞTURMA*****
#os.mkdir("newdirectory")#klasör olusturduk
#os.makedirs("D:\\newdirectory/yeniklasör")
#os.rename("newdirectory","newfile")
#os.rmdir("yeniklador")#alt klasör olmadığında kullanılır.
#os.removedirs("newfile/newfile")#tüm klasorler silinir.

#********DİZİN DEĞİŞTİRME******
# os.chdir("../..")
# os.chdir("D:\\")#bizi anadizine götürür. yazdığımız dizine götürür

#****LİSTELEME******
#result = os.listdir()
#result = os.listdir("C:\\")

# for dosya in os.listdir():
#      if dosya.endswith(".py"):
#           print(dosya)

#result=os.stat("_datetime.py")
#result=result.st_size/1024
#result=datetime.datetime.fromtimestamp(result.st_ctime)   #oluşturulma tarihi
#result=datetime.datetime.fromtimestamp(result.st_atime)   #son erişilme tarihi
# result=datetime.datetime.fromtimestamp(result.st_mtime)  #değiştirilme tarihi

#os.system("notepad.exe")

#******path****
result=os.path.abspath("_os.py")#dosyanının ismi
result=os.path.dirname("D:/gülnisaslan yazılım/yazılım/python/15-ileri seviye python modülleri ve web scraping/_os.py ")#dizin yolunu verir.
result=os.path.dirname(os.path.abspath("_os.py"))#dosyanın tam yolunu buluyor ve veriyor
result=os.path.exists("_os.py")#buda dosyanın klasörde olup olmadığın kontrol ediyor yada klsörün olup olmadığını kontrol eder.
result=os.path.isdir("D:/gülnisaslan yazılım/yazılım/python/15-ileri seviye python modülleri ve web scraping")#klasorün o konumda olup olmadığını belirtir
result=os.path.isfile("D:/gülnisaslan yazılım/yazılım/python/15-ileri seviye python modülleri ve web scraping/_os.py")#dosyanın o konumda olup olmadığını kontrol eder
result=os.path.join("D:\\","merhaba","deneme1")
result=os.path.split("D:\\merhaba")
result=os.path.splitext("_os.py")
result=result[0]
result=result[1]

print(result)


