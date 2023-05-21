import requests
import json


api_url="https://api.exchangeratesapi.io/latest?base="
#print(result.text)

bozulanDovizTuru=input("bozulan döviz türü:  ")
alinan_doviz=input("alınan  döviz türü: ")
miktar=int(input(f"ne kadar {bozulanDovizTuru} bozdurmak istiyorsunuz.: "))

result=requests.get(api_url+bozulanDovizTuru)
result = json.loads(result.text)
print("1 {0} = {1} {2} ".format(bozulanDovizTuru,result["rates"][alinan_doviz],alinan_doviz))
print("{0} {1}={2} {3}".format(miktar,bozulanDovizTuru,miktar*result["rates"][alinan_doviz],alinan_doviz))
