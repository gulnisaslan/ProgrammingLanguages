import numpy  as np

#python list
py_list = [1, 2, 3, 4, 5, 6, 7, 8, 9]

#numpy arrays

np_arrays=np.array([1, 2, 3, 4, 5, 6, 7, 8, 9])
print(type(py_list))
print(type(np_arrays))

py_multi = [[1,2,3],[4,5,6],[7,8,9]]
np_multi = np_arrays.reshape(3,3)

print(py_multi)
print(np_multi)

print(np_arrays.ndim)
print(np_multi.ndim)

print(np_arrays.shape)
print(np_multi.shape)



