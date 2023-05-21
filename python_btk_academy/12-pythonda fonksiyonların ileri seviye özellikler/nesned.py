# def greeting(name):
#      print("Hello" , name)
# sayHello=greeting
# print(greeting('Ali'))
# print(sayHello('Ali'))
# print(sayHello)
# print(greeting)
# print(greeting('ali'))
# print(greeting)
# del sayHello
# print(greeting)


#*********************************
#******encapsulation********* 
# def outer(num1):
#      print("outer")
#      def inner_increment(num1):
#           print("inner")
#           return num1+1
     
#      num2=inner_increment(num1)
     
#      print(num1,num2)
# outer(10)


def factorial(number):
     if not isinstance(number,int):
          raise TypeError("number must be an integer.")
     if not number>=0:
          raise ValueError("number must be zero and positive")

     def inner_factorial(number):
          if number<=1:
               return 1
          
          
          return number *inner_factorial(number-1)
     return inner_factorial(number)
try: 
     print(factorial("4"))

except Exception as ex:
     print(ex)


