from skyfield.api import load

ts = load.timescale()
t = ts.now()

planets = load('de421.bsp')
earth, mars = planets['earth'], planets['mars']

astrometric = earth.at(t).observe(mars)
ra, dec, distance = astrometric.radec()

print(ra)
print(dec)
print(distance)
