# # Object Oriented Programming(OOP) 

# #Class=>person(name,  surname, birtday,calculateAge())
# #instance(object)

list1=[1, 2, 3]
list2=[1, 2, 3, 4]

result = type(list1)
result = type(list2)

print(result)



















class Circle:
    #class object attribute
    pi=3.14
    def __init__(self,yaricap=1):
        self.yaricap=yaricap

    #methods
    def cevre_hesapla(self):
        return 2 * self.pi + self.yaricap
    def alan_hesapla(self):
        return self.pi*(self.yaricap**2)

c1= Circle() #yaricap=1  kaldığım yer   28:52
c2= Circle(5)
print(f"c1: alan {c1.alan_hesapla()} çevre: {c1.cevre_hesapla()}")
print(f"c2: alan {c2.alan_hesapla()} çevre: {c2.cevre_hesapla()}")