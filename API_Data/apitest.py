import requests
import json
response_API = requests.get("https://api.le-systeme-solaire.net/rest")
data = response_API.text
json = json.loads(data)
case = json['bodies']
print(case)