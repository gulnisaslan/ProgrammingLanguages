# # #key=value
# # #41=>kocaeli 34=>istanbul
# # #sehirler=['kocaeli','istanbul']
# # #plakalar=[41,34]
# # #print(plakalar[sehirler.index('kocaeli')])
# # #print(plakalar['kocaeli'])=> 41
# # #plakalar={'kocaeli': 41, 'istanbul': 34}
# # #print(plakalar['kocaeli'])
# # # #plakalar['ankara']=6
# # #plakalar['kocaeli']='new value'
# # #print(plakalar)

# # users={
# #     'gülnisa aslan':24,
# #     'ercan aslan':23
# }

users={
    'gülnisaaslan':{
        'age':24,
        'email':'gülnisa@hotmail.com',
        'roles':['admin','user'],
        'address':'istanbul'
    },
    'ercanaslan':{
        'age':23,
        'email':'ercan@hotmail.com',
        'roles':['user'],
        'address':'istanbul'
    }
}
print(users['gülnisaaslan']['roles'][0])