#Inheritance =miras - kalıtım alması

# Person => name, lastname, age, eat(), run(),drink()
# Student(Person),Teacher(Person)
# Animal=>dog(),Cat()


class Person():
    def __init__(self,firstName,lastName):
        self.firstName=firstName
        self.lastName=lastName
        print('Person created.')
    
    def who_am_i(self):
        print('I am a person.')

    def eating(self):
        print('I am eating.')


class Student(Person):
    def __init__(self,firstName,lastName,number):
        Person.__init__(self,firstName,lastName)
        self.number= number
        print("student created.")
    #override
    def who_am_i(self):
        print('I am a student')
    
    def sayHello(self):
        print("hello I am a student.")


class Teacher(Person):
    def __init__(self,firstName,lastName,branch):
        super().__init__(firstName,lastName)
        self.branch=branch
    def who_am_i(self):
        print(f'I am a {self.branch} teacher.')







p1 = Person('Ali', 'Yılmaz')
s1 = Student('Kübra', 'Durmaz',1053)
t1= Teacher('Gülnisa','Aslan','Math')
print(p1.firstName+ '  ' + p1.lastName)
print(s1.firstName+ '  ' + s1.lastName+ ' '+str(s1.number))

p1.who_am_i()
s1.who_am_i()

p1.eating()
s1.eating()
s1.sayHello()
t1.who_am_i()


