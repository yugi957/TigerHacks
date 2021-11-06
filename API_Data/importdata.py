# This file imports data from the planet data json file

import requests
import json

class PlanetInfo:
  def __init__(self,name,discDate,discBy,radius,massVal,massExp,avgTemp,moons):
    self.name = name #Stored as str
    self.discoveryDate = discDate #Stored as a str in dd/mm/yyyy
    self.discoveredBy = discBy #Stored as str
    self.radius = radius #Stored as float. Mean radius in km
    self.massValue = massVal #Stored as float
    self.massExponent = massExp #Stored as float. Body mass is massValue*10^massExponent
    self.avgTemp = avgTemp #Stored as float. Mean temp in Kelvin
    self.moons = moons #Dictionary of strings with names of moons

def main():
  dataJson = open('data.json')
  planetData = json.load(dataJson)
  #print(planetData)
  localPlanets = ["Earth", "Venus", "Mars", "Mercury", "Saturn", "Neptune","Uranus", "Pluto", "Jupiter"]
  planets = []
  
  for planet in planetData:
    if planet["name"] in localPlanets:
      planets.append(PlanetInfo(
        name = planet["name"],
        discDate = planet["discoveryDate"],
        discBy = planet["discoveredBy"],
        radius = planet["radius"],
        massVal = planet["mass"]["massValue"],
        massExp = planet["mass"]["massExponent"],
        avgTemp = planet["temp"],
        moons = planet["moons"]
      ))
  for planet in planets:
    print(planet.name)

  dataJson.close()

  

if __name__ == "__main__":
  main()

