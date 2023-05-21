#global scope
# x = 'global x'

# def function():
#     #lokal scope
#     #x='local x'
#     print(x)

# function()
# print(x)
   

#################
# name = 'Çınar'

# def changeName(new_name):
#     name=new_name
#     print(name)

# changeName('ada')
# print(name)

##########################

# name='global string'

# def greeeting():
#   #  name='çınar'

#     def hello():
#         #name='ada'
#         print('hello'+name)

#     hello()

# greeeting()

#####

x=50
def test():
    global x
    print(f'x:{x}')

    x=100
    print(f'change x to:{x}')

test()
print(x)