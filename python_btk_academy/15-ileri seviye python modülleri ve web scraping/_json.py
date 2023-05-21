import json

#dict
person_string = '{"name":"Ali","languages":["Python","C#"]}'
person_dict={
     "name":"ali",
     "languages":["python","C#"]
}


# result=person["name"]
# result=person["languages"]
# result=person["languages"][0]

#*********JSON string to dict**********
# result = json.loads(person_string)
# result=result["name"]
# result=result["languages"]
# print(result)
# print(type(result))

# with open("person.json") as f:
#     data = json.load(f)
#     print(data["name"])
#     print(data["languages"])

#Dict to JSON string 

# result=json.dumps(person_dict)
# print(result)
# print(type(result))

# with open("person.json","w") as f:
#      json.dump(person_dict,f)
person_dict=json.loads(person_string)
result = json.dumps(person_dict,indent=4,sort_keys=True)
print(result)
print(person_dict)

