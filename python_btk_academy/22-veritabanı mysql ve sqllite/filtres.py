from logging import error
import mysql.connector
from mysql.connector import connection
from mysql.connector import cursor

def insertProduct(name, price, imageUrl, description):
     connection = mysql.connector.connect(host="localhost",user="root",password="30011971",database="node-app")
     cursor=connection.cursor()

     sql = ("INSERT INTO Products(name,price,imageUrl,description) VALUES(%s,%s,%s,%s)")
     # values=("Samsung S8",5000,"3.jpg","çok iyi telefon")
     values = (name,price,imageUrl,description)
     cursor.execute(sql, values)
     
     try:
        connection.commit()
        print(f'{cursor.rowcount} tane kayıt eklendi.')
        print(f'son eklenen kaydın id {cursor.lastrowid}')
     except mysql.connector.Error as err:
          print("hata: ",err)
     finally:
          connection.close()
          print("database bağlantısı kapandı")



def insertProducts(list):
     connection = mysql.connector.connect(host="localhost",user="root",password="30011971",database="node-app")
     cursor=connection.cursor()

     sql = ("INSERT INTO Products(name,price,imageUrl,description) VALUES(%s,%s,%s,%s)")
     # values=("Samsung S8",5000,"3.jpg","çok iyi telefon")
     values = list
     cursor.executemany(sql, values)
     
     try:
        connection.commit()
        print(f'{cursor.rowcount} tane kayıt eklendi.')
        print(f'son eklenen kaydın id {cursor.lastrowid}')
     except mysql.connector.Error as err:
          print("hata: ",err)
     finally:
          connection.close()


def getProducts():
      connection = mysql.connector.connect(host="localhost",user="root",password="30011971",database="node-app")
      cursor=connection.cursor()
      
     #  cursor.execute("Select * from Products Where name LiKE '%Samsung%' and  price = 5000 ")
     #  cursor.execute("Select * from Products Where name LiKE 'Samsung S6' and  price = 2000")

      cursor.execute("Select  name, price from Products Where id=1")
     #  result = cursor.fetchall()
      result = cursor.fetchone()
      print(result)
   
      #for product in result:
           #print(f" id: {product[0]} name : {product[1]} price :{product[2]}")
      #      print(f"name : {product[0]} price :{product[1]}")

          #  print(product)


    
def getProductById(id):
      connection = mysql.connector.connect(host="localhost",user="root",password="30011971",database="node-app")
      cursor=connection.cursor()
      
      sql= "Select * From Products Where id=%s"
      params = (id,)
      
      cursor.execute(sql,params)
     
      result = cursor.fetchone()
      print(f"id: {result[0]} name: {result[1]} price : {result[2]}")
   
     
getProductById(10)   
