import numpy as np

numbers1 = np.random.randint(10,100,6)
numbers2 = np.random.randint(10,100,6)

print(numbers1)
print(numbers2)

result = numbers1 + numbers2
result = numbers1 + 10
result = numbers1 - numbers2
result = numbers1 - 10
result = numbers1 * numbers2
result = numbers1 * 10

result = np.sin(numbers1)
result = np.cos(numbers1)
result = np.sqrt(numbers1)
result = np.log(numbers1)

_numbers1 = numbers1.reshape(2,3)
_numbers2 = numbers2.reshape(2,3)

# print(_numbers1)
# print(_numbers2)
print("***********")
result = np.vstack((_numbers1,_numbers2))
result = np.hstack((_numbers1,_numbers2))


result = numbers1 >=50
result = numbers1 % 2 == 0

print(numbers1[result])


print(result)



# print(result)


