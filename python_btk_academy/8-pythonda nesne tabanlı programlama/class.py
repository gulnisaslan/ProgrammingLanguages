class Person:
    #attributes
    #class attributes
    address = 'no information'
    #constructor (yapıcı metod)

    def __init__(self, name, year):
      #object attributes
     self.name=name
     self.year=year


     print('init metodu çalıştı.')
    
     #instance methods
    def intro(self):
       print('hello there. I am '+ self.name)
    
    def calculateAge(self):
         return 2020-self.year
    
#objact, instance
p1 = Person(name = 'Gülnisa',year = 1996)
p2 = Person(name ='Ercan', year = 1997)

p1.intro()
p2.intro()

print(f"adım: {p1.name} yaşım:  {p1.calculateAge()}")
print(f"adım : {p2.name} yaşım: {p2.calculateAge()}")
#<<<<Updating>>>>>>>
p1.name='Ahmet'
p1.address='istanbul'

#accessing object attributes
print(f"p1 name: {p1.name} year: {p1.year} address : {p1.address}")
print(f"p2 name: {p2.name} year: {p2.year}  address: {p2.address}")
print(p2)
print(p1)
print(type(p2))
print(type(p1))
print(p1==p2)



