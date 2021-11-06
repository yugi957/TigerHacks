import requests
import json
response_API = requests.get("https://api.le-systeme-solaire.net/rest/bodies/")
data = response_API.text
body_data = json.loads(data)
bodies = body_data["bodies"]

#print(bodies)

localSystem = []

for object in bodies:
    localSystem.append(object['englishName'])

#print(localSystem)
localSystem = {"name":[], "temp":[], "mass":[], "volume":[], "density":[], "gravity":[]}

data = []

for planet in bodies:
    if(planet["isPlanet"]==True):
        item = {"name": planet["englishName"], 
            "temp": planet["avgTemp"],
            "mass":planet["mass"], 
            "volume": planet["vol"],
            "density": planet["density"],
            "gravity": planet["gravity"],
            "moons": planet["moons"]}
        data.append(item)

with open("data.json", "w") as outfile:
    json.dump(data, outfile)

print(json.dumps(data, indent=4))