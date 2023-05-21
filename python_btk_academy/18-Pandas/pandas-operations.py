import pandas as pd
import numpy as np


data={
     "Column1":[1,2,4,5,6,9],
     "Column2":[12,13,45,52,85,63],
     "Column3":["abc","defa","jk","mno","gjk","bde"]
}

def kareAl(x):
     return x*x

kareAl2=lambda x:x*x
df=pd.DataFrame(data)
result=df
result=df["Column2"].unique()
result=df["Column2"].nunique()
result=df["Column2"].value_counts()
result=df["Column1"]*2

result=df["Column1"].apply(kareAl2)
result=df["Column3"].apply(len)
df["Columns4"]=df["Column3"].apply(len)
result=df.columns
result=df.index
result=len(df.index)

result=df.info

result=df.sort_values("Column2")
result=df.sort_values("Column3" ,ascending=False)
print(result)