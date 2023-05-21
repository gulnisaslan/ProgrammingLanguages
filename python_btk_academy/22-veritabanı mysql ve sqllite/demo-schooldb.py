from logging import info
import mysql.connector
from mysql.connector import cursor
from datetime import datetime
from connection import connection


class Student:
  connection = connection
  mycursor = connection.cursor()
  def __init__(self,id,studentNumber,name,surname,birthday,gender):
    if id is None:
      self.id=0
    else:
      self.id = id
      self.studentNumber = studentNumber
      self.name = name
      self.surname = surname
      self.birthday  = birthday
      self.gender = gender

  def saveStudent(self):
    sql = ("INSERT INTO Student(StudentNumber,Name,Surname,Birthday,Gender) VALUES(%s,%s,%s,%s,%s)")
    value = (self.studentNumber,self.name,self.surname,self.birthday,self.gender)
    Student.mycursor.execute(sql,value)
    try:
      Student.connection.commit()
      print(f"{Student.mycursor.rowcount} tane kayıt eklandi.")
      print(f"son eklenen kaydın id {Student.mycursor.lastrowid}")
    except mysql.connector.Error as err:
      print("hata: ",err)
    finally:
      Student.connection.close()
     
  @staticmethod
  def saveStudents(students):
    sql = ("INSERT INTO Student(StudentNumber,Name,Surname,Birthday,Gender) VALUES(%s,%s,%s,%s,%s)")
    values = students
    Student.mycursor.executemany(sql,values)
    try:
      Student.connection.commit()
      print(f"{Student.mycursor.rowcount} tane kayıt eklandi.")
      print(f"son eklenen kaydın id {Student.mycursor.lastrowid}")
    except mysql.connector.Error as err:
      print("hata: ",err)
    finally:
      Student.connection.close()
  
  @staticmethod
  def studentInfo():
    sql = "Select * From Student "
    sql = "Select * From Student LIMIT 5"

     #  sql = "Select studentnumber,name,surname From Student"
     #  sql = "Select studentnumber,name,surname From Student Where gender = 'K'"
     #  sql = "Select * From Student Where YEAR(Birthday) = 2003" 
     #  sql = "Select * From Student Where YEAR(Birthday) = 2005 and name = 'Ali'"
     #  sql = "Select * From Student Where name like '%an%' or  surname like  '%an%'"
     #  sql = "Select Count(id) From Student Where gender = 'E'"
     #  sql = "Select name,surname from Student where gender = 'K' order by name,surname"
    Student.mycursor.execute(sql)
       
    try:
     results = Student.mycursor.fetchall()
         
     for result in results:
        print(f"{result[0]} {result[1]} ")
          
        #  print(results)
    except mysql.connector.Error as err:
      print('hata:',err)
    finally:
      Student.connection.close()
  
  @staticmethod
  def getStudentById(id):
    sql = "Select * From Student Where id = %s"
    values = (id,)
    Student.mycursor.execute(sql, values)
    try: 
     obj = Student.mycursor.fetchone()
     return  Student(obj[0],obj[1],obj[2],obj[3],obj[4],obj[5])
    except  mysql.connector.Error as err:
      print('ERROR', err)
    # try: 
    #   return Student.mycursor.fetchone()
    # except  mysql.connector.Error as err:
    #   print('ERROR', err)
 
      
  def updateStudent(self):
    sql = "update student set studentnumber=%s,name=%s,surname=%s,birthday=%s,gender=%s where id=%s"
    values = (self.studentNumber,self.name,self.surname,self.birthday,self.gender,self.id)
    Student.mycursor.execute(sql,values)

    try:
      Student.connection.commit()
      print(f'{Student.mycursor.rowcount} tane kayıt güncellendi')
    except mysql.connector.Error as err:
      print('ERROR:',err)
  
  @staticmethod
  def getStudentsGender(gender):
    sql = "Select * from Student where gender = %s"
    value = (gender,)

    Student.mycursor.execute(sql, value)

    try:
       return Student.mycursor.fetchall()
      
    except mysql.connector.Error as err:
      print('Error:',err)
  
  @staticmethod
  def updateStudents(liste):
    sql = "update student set studentnumber=%s,name=%s,surname=%s,birthday=%s,gender=%s where id=%s"
    values = []
    order = [1,2,3,4,5,0]
    
    for item in liste:
      item = [item[i] for i in order]
      values.append(item)


    Student.mycursor.executemany(sql,values)

    try:
      Student.connection.commit()
      print(f'{Student.mycursor.rowcount} tane kayıt güncellendi')
    except mysql.connector.Error as err:
      print('ERROR:',err)
  

students = Student.getStudentsGender('E')
# print(students)

liste=[]
for student in students:
  student = list(student)
  student[2] = 'Mr' + student[2]
  liste.append(student)

Student.updateStudents(liste)



# student = Student.getStudentById(34)
# student.name = 'Halime'    
# student.surname = 'Alkar'
# student.gender= 'K'
# student.updateStudent()
#**********
# obj = Student.getStudentById(34)
# student = Student(obj[0],obj[1],obj[2],obj[3],obj[4],obj[5])
# student.name = 'Halime'    
# student.surname = 'Alkar'
# student.gender= 'K'
# student.updateStudent()


       

# print(obj)
# Student.studentInfo()            
       
# ogrenciler = [
#       ("350","Ahmet emir","Yılmaz",datetime(2005, 5, 17),"E"),
#       ("390","Alican","Can",datetime(2005, 6, 17),"E"),
#       ("400","Canan","Tan",datetime(2005, 7, 7),"K"),
#       ("401","Ayşe Nisa","Taner",datetime(2005, 9, 23),"K"),
#       ("409","Bahadır","Toksöz",datetime(2004, 7, 27),"E"),
#       ("408","Ali Murat","Cenk",datetime(2003, 8, 25),"E")
# ]
# Student.saveStudents(ogrenciler)

         
# gulnisa = Student("721","Gülnisa","Aslan", datetime(1996,4,1),"K")
# gulnisa.saveStudent()
# connection = mysql.connector.connect(
#      host = "localhost",
#      user = "root",
#      password = "30011971",
#      database = "school-database"
#      )
# mycursor = connection.cursor()
# sql = ("INSERT INTO Student(StudentNumber,Name,Surname,Birthday,Gender) VALUES(%s,%s,%s,%s,%s)")
# values = [
#       ("380","Ahmet","Yılmaz",datetime(2005, 5, 17),"E"),
#       ("320","Ali","Can",datetime(2005, 6, 17),"E"),
#       ("307","Canan","Tan",datetime(2005, 7, 7),"K"),
#       ("308","Ayşe","Taner",datetime(2005, 9, 23),"K"),
#       ("309","Bahadır","Toksöz",datetime(2004, 7, 27),"E"),
#       ("310","Ali","Cenk",datetime(2003, 8, 25),"E")
# ]
# mycursor.executemany(sql, values)
# try:
#         connection.commit()
#         print(f"{mycursor.rowcount} tane kayıt eklandi.")
#         print(f"son eklenen kaydın id {mycursor.lastrowid}")
# except mysql.connector.Error as err:
#         print("hata: ",err)
# finally:
#           connection.close()


# def student(list):
#    connection = mysql.connector.connect(
#      host = "localhost",
#      user = "root",
#      password = "30011971",
#      database = "school-database"
#      )
#    mycursor = connection.cursor()
#    sql = ("INSERT INTO Student(StudentNumber,Name,Surname,Birthday,Gender) VALUES(%s,%s,%s,%s,%s)")
#    values = list
#    cursor.executemany(sql, values)
#    try:
#         connection.commit()
#         print(f"{cursor.rowcount} tane kayıt eklandi.")
#         print(f"son eklenen kaydın id {cursor.lastrowid}")
#    except mysql.connector.Error as err:
#         print("hata: ",err)
#    finally:
#           connection.close()

# list = []
# while True:
#      StudentNumber = int(input("Öğrenci numarasını girirniz:"))
#      Name = input("Öğrenci adı giriniz:")
#      Surname = input("Öğrenci soyadını Giriniz:")
#      Birthday = datetime(input(" Öğrenci doğum tarihi giriniz:"))
#      Gender = input("Öğrencinin cinsiyetini giriniz:")

#      list = ((StudentNumber,Name,Surname,Birthday,Gender))
#      result = input("Veritabanına bilgi kaydetmek istiyormusun (e/h):")
#      if result == "h":
#           print("Kayıtlarınız Veritabanına aktarılıyor.")
#           print(list)
#           student(list)
#           break
      

    












