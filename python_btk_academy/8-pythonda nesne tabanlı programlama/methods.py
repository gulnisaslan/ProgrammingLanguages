#class

class Person:
  #class attributes
  #address= "no information"
  #constructor(yapıcı metod)
  #def __init__(self,name,year):
    #object attributes
    # self.name=name
    # self.year=year
    # print("init metodu çalıştı.")

  # instance methods=
  # def intro(self):
  #   print("hello there. I am"+ self.name)

  # def calculateAge(self):
  #   return 2020-self.year  

#object (instance)
# p1 = Person(name ='Beyza',year=1997)
# p2 = Person(name='Zehra',year=1997)

#accessing object attributes

# print(f"p1: name{p1.name} year: {p1.year} address{p1.address}")
# print(f"p2: name{p2.name} year: {p2.year} address{p2.address}")

# p1.intro()
# p2.intro()

# print(f'adım : {p1.name} yaşım :{p1.calculateAge()}')
# print(f'adım :{p2.name} yaşım :{p2.calculateAge()}')


class Circle:
  pi=3.14
  def __init__(self,yaricap=2):
    self.yaricap=yaricap

  def  cevre_hesapla(self):
    return 2*self.pi+self.yaricap

  def alan_hesapla(self):
    return self.pi*(self.yaricap**2)


c1=Circle() #yarıçap=1
c2=Circle(5)

print(f' c1:alan = {c1.alan_hesapla()} çevre hesapla = {c1.cevre_hesapla()}')
print(f' c2:alan = {c2.alan_hesapla()} çevre hesapla = {c2.cevre_hesapla()}')

























