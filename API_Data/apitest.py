import requests
import json
response_API = requests.get("https://api.le-systeme-solaire.net/rest/bodies/")
data = response_API.text
body_data = json.loads(data)
bodies = body_data["bodies"]

localSystem = []

for object in bodies:
    localSystem.append(object['englishName'])

#print(localSystem)
localSystem = {"name":[], "temp":[], "mass":[], "volume":[], "density":[], "gravity":[]}

data = []

for planet in bodies:
    """print("Name: {name}, AvgTemp: {temp}, Mass: {mass}, Volume: {volume}, Density: {density}, Gravity: {gravity}".format(
        name=planet["englishName"],
        temp=planet["avgTemp"],
        mass=planet["mass"],
        volume=planet["vol"],
        density=planet["density"],
        gravity=planet["gravity"]
    ))"""
    item = {"name": planet["englishName"], 
        "temp": planet["avgTemp"],
        "mass":planet["mass"], 
        "volume": planet["vol"],
        "density": planet["density"],
        "gravity": planet["gravity"]}
    data.append(item)


print(data)