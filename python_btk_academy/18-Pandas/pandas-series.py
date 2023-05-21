from numpy.compat.py3k import open_latin1
import pandas as pd
import numpy as np

# numbers = np.array[10,20,30,40]
# letters = ['a','b','c','d']
# scalar = 5
# dict = {'a':10, 'b':20, 'c':30, 'd':40}
# random_numbers = np.random.randint(10,100,6)


# pandas_series = pd.Series() #int64 #pandas'ta birçok veri tipin tek diziye verebiliyorsun
# pandas_series = pd.Series(numbers) # object
# pandas_series = pd.Series(letters)
# pandas_series = pd.Series(scalar, [0,1,2,3,4]) #verdigimiz beş bilgisi yazdıgımızda ikinci parametredeki sayı kadar beş bilgisi artırlır   
# pandas_series = pd.Series(numbers, ['a','b','c','d'])  #key bilgisi atama
# pandas_series = pd.Series(dict)
# pandas_series = pd.Series(random_numbers)

# pandas_series = pd.Series([10,20,30,27],['a','b','c','d'])
# result = pandas_series[0]
# result = pandas_series[-1]
# result = pandas_series[:2]
# result = pandas_series[-2:]
# result = pandas_series['a']
# result = pandas_series['d']
# result = pandas_series[['a','d']]
# result = pandas_series.ndim
# result = pandas_series.dtype
# result = pandas_series.shape
# result = pandas_series.sum()
# result = pandas_series.max()
# result = pandas_series.min()
# result = pandas_series + pandas_series
# result = pandas_series + pandas_series + 50
# result = np.sqrt(pandas_series)
# result = pandas_series >= 50
# result = pandas_series % 2 == 0

# print(pandas_series[result])
# print(pandas_series)
# print(result)


opel2018 = pd.Series([20,30,40,10],["astra","corsa","mokka","insignia"])
opel2019 = pd.Series([40,30,20,10],["astra","corsa","grandland","insignia"])

total = opel2018 + opel2019
print(total["astra"])
