using System;
using System.IO;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System.Web.Script.Serialization;
using System.Linq;
using System.Collections.Generic;
//using UnityEngine;

namespace DeserializeFromFile
{
    public class PlanetInfo
    {
        public string Name { get; set; } // Stored as str
        public string DiscoveryDate { get; set; } // Stored as a str in dd/mm/yyyy
        public string DiscoveredBy { get; set; } // Stored as str
        public float Radius { get; set; } // Stored as float. Mean radius in km
        public float MassValue { get; set; } // Stored as float
        public float MassExponent { get; set; } // Stored as float. Body mass is massValue*10^massExponent
        public float AvgTemp { get; set; } // Stored as float. Mean temp in Kelvin
        public string Moons { get; set; } // Dictionary of strings with names of moons
    }

    public class Program
    {
        public static void Main()
        {
          object DeserializeJson<T>(string Json)
          {
              JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();
              return JavaScriptSerializer.Deserialize<T>(Json);
          }
          string fileName = "data.json";
          string planetData = File.ReadAllText(fileName);
          Console.WriteLine("Hello");
          var deserialized = DeserializeJson<PlanetInfo>(planetData);
          Console.WriteLine(deserialized);
          
          // Array of planet names that we need to get from the json file
          string[] localPlanets = {"Earth", "Venus", "Mars", "Mercury", "Saturn", "Neptune","Uranus", "Pluto", "Jupiter"};
          List<string> planets = new List<string>();

          // Iterates through the planet json and makes a new object for each planet

          /*foreach (string planet in deserialized)
          {
            Console.WriteLine(planet);
            if (localPlanets.Contains((string)planet["name"]))
            {
              planets.Add("name");
            }
          }*/
        }
    }
}
// output:
//Date: 8/1/2019 12:00:00 AM -07:00
//TemperatureCelsius: 25
//Summary: Hot