# def cube():
#      for i in range(5):
#           yield i**3

# for i in cube():
#      print(i)

   
# iterator=cube()

# iterator=iter(generator)
# print(next(iterator))
# print(next(iterator))
# print(next(iterator))
# print(next(iterator))
# print(next(iterator))

generator=[i**3 for i in range(5)]
generator=(i**3 for i in range(5))

for i in generator:
     print(i)
# print(next(generator))
# print(next(generator))
# print(next(generator))
# print(next(generator))






