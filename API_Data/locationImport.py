from skyfield.api import load
import json
import requests
'''
ts = load.timescale()
t = ts.now()

planets = load('de440.bsp')
print(planets)
earth, mars = planets['earth'], planets['mars']

astrometric = earth.at(t).observe(mars)
ra, dec, distance = astrometric.radec()

print(ra)
print(dec)
print(distance)
'''

astrology_data = requests.get("https://json.astrologyapi.com/v1/planets")
temp = astrology_data.text
astroData = json.loads(temp)
print(astroData)