import pandas as pd

# customers={
#      'CustomerId':[1,2,3,4],
#      'FirstName':["Ahmet","Ali","Hasan","Canan"],
#      'LastName':["Demir","Sancak","Mervan","Cankardes"]
# }

# orders={
#      'OrderId':[10,11,12,13],
#      'CustomerId':[1,2,5,7],
#      'OrderDate':['2010-07-04','2010-04-01','2010-04-23','2010-04-20']
# }
# df_customers=pd.DataFrame(customers,columns=["CustomerId","FirstName","LastName"])

# df_orders=pd.DataFrame(orders,columns=["OrderId","CustomerId","OrderDate"])
# # print(df_customers)
# # print(df_orders)
# result=pd.merge(df_customers,df_orders,how="right")

customersA={
     'CustomerId':[1,2,3,4],
     'FirstName':["Ahmet","Ali","Hasan","Canan"],
     'LastName':["Demir","Sancak","Mervan","Cankardes"]
}
customersB={
     'CustomerId':[5,6,7,8],
     'FirstName':["Nisa","Ali","Çağla","Cemre"],
     'LastName':["Aslan","Kerim","Mervan","Cankardes"]
}
df_customersA=pd.DataFrame(customersA,columns=["CustomerId","FirstName","LastName"])
df_customersB=pd.DataFrame(customersB,columns=["CustomerId","FirstName","LastName"])
result=pd.concat([df_customersA,df_customersB])
result=pd.concat([df_customersA,df_customersB],axis=1)


print(result)

