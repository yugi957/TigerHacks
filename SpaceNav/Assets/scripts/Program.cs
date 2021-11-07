using System;
using System.IO;
using Newtonsoft.Json;
//using System.Text.Json.Serialization;
//using System.Web.Script.Serialization;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
//using UnityEngine;

namespace DeserializeFromFile
{
    /*
    public class PlanetInfo
    {
        public string name { get; set; } // Stored as str
        public float temp { get; set; } // Stored as float. Mean temp in Kelvin
        public List<float> mass { get; set; } /// Stored as float. Body mass is massValue*10^massExponent
        public List<float> volume { get; set; }
        public float density { get; set; }
        public float gravity { get; set; }
        public List<string> moons { get; set; } // Dictionary of strings with names of moons
        public string discoveredBy { get; set; } // Stored as str
        public string discoveryDate { get; set; } // Stored as a str in dd/mm/yyyy
        public float radius { get; set; } // Stored as float. Mean radius in km
    }*/

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Mass
    {
        public double massValue { get; set; }
        public int massExponent { get; set; }
    }

    public class Volume
    {
        public double volValue { get; set; }
        public int volExponent { get; set; }
    }

    public class Moon
    {
        public string moon { get; set; }
        public string rel { get; set; }
    }

    public class Root
    {
        public string name { get; set; }
        public int temp { get; set; }
        public Mass mass { get; set; }
        public Volume volume { get; set; }
        public double density { get; set; }
        public double gravity { get; set; }
        public List<Moon> moons { get; set; }
        public string discoveredBy { get; set; }
        public string discoveryDate { get; set; }
        public double radius { get; set; }
    }

    public class Program
    {
        static IEnumerable<T> DeserializeObjects<T>(string input)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (var strreader = new StringReader(input))
            using (var jsonreader = new JsonTextReader(strreader))
            {
                //you should use this line
                jsonreader.SupportMultipleContent = true;
                while (jsonreader.Read())
                {
                    yield return serializer.Deserialize<T>(jsonreader);
                }
            }
        }

        public static void Main()
        {

            //string fileName = "data.json";
            var jsonString = File.ReadAllText(@"/Users/cameron/Documents/GitHub/TigerHacks/API_Data/data.json");
            //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonString);
            

            // Array of planet names that we need to get from the json file
            string[] localPlanets = { "Earth", "Venus", "Mars", "Mercury", "Saturn", "Neptune", "Uranus", "Pluto", "Jupiter" };

            // Iterates through the planet json and makes a new object for each planet

            /*string[] jsonFileContent = File.ReadAllLines(@"/Users/cameron/Documents/GitHub/TigerHacks/API_Data/data.json");
            foreach (string value in jsonFileContent)
            {

            }*/

            var planets = DeserializeObjects<Root>(jsonString).ToList();

            List<Root> planetList = new List<Root>();

            foreach(var planet in planets)
            {
                if(localPlanets.Contains(planet.name))
                {
                    planetList.Add(planet);
                }
            }

            string json = JsonConvert.SerializeObject(planetList);
            System.IO.File.WriteAllText(@"/Users/cameron/Documents/GitHub/TigerHacks/API_Data/planetdata.json", json);

            /*foreach(var planet in planetList)
            {
                Console.WriteLine(planet.name + planet.temp);
            }*/

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