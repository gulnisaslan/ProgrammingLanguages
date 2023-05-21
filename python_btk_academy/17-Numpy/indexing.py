import numpy as np


numbers = np.array([0,5,15,20,25,30,50])

result = numbers[-1]
result = numbers[:3]
result = numbers[3:]
result = numbers[::-2]

numbers2 = np.array([[0,5,15],[20,25,30],[50,70,90]])
result =numbers2[2]
result =numbers2[0,1]
result = numbers2[:,0]
result = numbers2[:,0:2]
result = numbers2[:2,:2]
arr1=np.arange(0,10)
# arr2 = arr1#referance
arr2=arr1.copy()


print(result)
