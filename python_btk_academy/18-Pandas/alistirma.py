import pandas as pd
from numpy.random import randn


df = pd.DataFrame(randn(4,4), index=["A","B","C","D"], columns=["Column1","Column2","Column3","Column4"])
result = df
result = df["Column1"]
result = df[["Column1",  "Column2"]]
result = df.loc["A"]
result = df.iloc[2]
result = df.loc[:,["Column1"]]
result = df.loc[:,["Column1","Column2"]]
result = df.loc[["A","B"],["Column1","Column2"]]
result = df.loc["A":"C",:"Column3"]
result = df.loc["A":"C",:"Column3"].sum()





print(result)

