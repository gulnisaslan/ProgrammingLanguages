import mysql.connector

connection = mysql.connector.connect(
     host = "localhost",
     user = "root",
     password = "30011971",
     databe = "school-database"
)

mycursor = connection.cursor() 

# mycursor.execute("SHOW DATABASES ")

# for i in mycursor:
#      print(i)