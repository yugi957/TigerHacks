import datetime

class PlanetLocation:
    def __init__(self, name, period):
      self.planetName = name #Stored as str
      self.orbitalPeriod = period #Stored as a float
      
    #Calculates position of the planet today
    #Returns current position in degrees
    def calcPosition(self):
      start_date = datetime.date(949, 1, 1)
      end_date = datetime.date.today()
      delta = end_date - start_date
      return (delta.days % self.orbitalPeriod) / self.orbitalPeriod * 360

def main():
  #Create variables for planets
  mercury = PlanetLocation("Mercury",88)
  venus = PlanetLocation("Venus", 224.7)
  earth = PlanetLocation("Earth", 365.2)
  mars = PlanetLocation("Mars", 687)
  jupiter = PlanetLocation("Jupiter",4331)
  saturn = PlanetLocation("Saturn",10747)
  uranus = PlanetLocation("Uranus",30589)
  neptune = PlanetLocation("Neptune",59800)
  pluto = PlanetLocation("Pluto",90560)

  #Create array
  array_of_planets = [mercury, venus, earth, mars, jupiter, saturn, uranus, neptune, pluto]

  #Print position for all planets
  for planet in array_of_planets:
    print(planet.calcPosition())
  
if __name__ == "__main__":
  main()


'''the last time all the planets were lined up 
is 949 ad. The next time is May 6, 2492'''
#orbitalPeriod is in earth days
#orbitalPeriod is Earth days it takes to go around the sun
#Mercury orbitalPeriod = 88.0
#Venus orbitalPeriod = 224.7
#Earth orbitalPeriod = 365.2
#Mars orbitalPeriod = 687.0
#Jupiter orbitalPeriod = 4331
#Saturn orbitalPeriod = 10,747
#Uranus orbitalPeriod = 30,589
#Neptune orbitalPeriod = 	59,800
#Pluto orbitalPeriod = 90,560