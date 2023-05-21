# def my_decorator(func):
#      def wrapper(name):
#           print("fonksiyondan önceki işlemler.")
#           func()
#           print("fonksiyondan sonraki işlemler.")
#      return wrapper

# @my_decorator
# def sayHello(name):
#      print("hello",name)

# # def sayGreeting():
# #      print("greeting")

# # sayHello=my_decorator(sayHello)
# # sayGreeting=my_decorator(sayGreeting)
# # sayGreeting()
# sayHello()

import math
import time
def calculate_time(func):
     def inner(*args,**kargs):
          start=time.time()
          time.sleep(1)
          func(*args,**kargs)
          finish=time.time()
          print("Fonksiyon " + func.__name__+ str(finish-start) + "saniye sürdü.")
     return inner

@calculate_time
def usAlma(a,b):
     print(math.pow(a,b))

@calculate_time
def faktoriyel(num):
     print(math.factorial(num))

@calculate_time
def toplama(a,b):
     print(a+b)


    

usAlma(2,3)
faktoriyel(5)
toplama(10,20)