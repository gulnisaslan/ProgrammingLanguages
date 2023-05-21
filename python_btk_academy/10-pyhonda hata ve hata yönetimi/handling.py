# error handling = hata yönetimi

# try:
#      x = int(input("x:"))
#      y = int(input("y:"))
#      print(x/y)


# except:
#      print("yanlış bilgi girdiniz")
     
   

# except (ZeroDivisionError,ValueError) as e:
#      print("yanlış bilgi girdiniz")
     
#      print(e)
    
 # print("y için sıfır girilemez")

# except ValueError:
#      print("x ve y için harf girmesiniz.")

while True:
     try:
          x=int(input("x: "))
          y=int(input("y: "))
          print(x/y)
     
     except Exception as ex:
          print("yanlış bilgi girdiniz.",ex)
     
     else:
          break

     finally:
          print("try expect sonlandı.")

    





   

