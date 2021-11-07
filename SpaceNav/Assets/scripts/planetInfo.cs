using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class planetInfo : MonoBehaviour
{
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

    Text text;
    // Start is called before the first frame update
    void Start()
    {
        string jsonString = File.ReadAllText(@"C:\Atul\TigerHacks\TigerHacks\SpaceNav\Assets\scripts\data.json");
        string[] localPlanets = { "Earth", "Venus", "Mars", "Mercury", "Saturn", "Neptune", "Uranus", "Pluto", "Jupiter" };

        var planets = DeserializeObjects<Root>(jsonString).ToList();

        List<Root> planetList = new List<Root>();

        foreach (var planet in planets)
        {
            if (localPlanets.Contains(planet.name))
            {
                planetList.Add(planet);
            }
        }
        text = GetComponent<Text>();
        string sceneName = SceneManager.GetActiveScene().name;

        Root currentPlanet = new Root();
        Debug.Log("Pain");
        foreach(var obj in planetList)
        {
            if(obj.name == sceneName)
            {
                currentPlanet = obj;
                break;
            }
        }

        if(sceneName == "EarthLanding")
        {
            for (int i = 0; i < planetList.Count(); i++)
            {
                if (planetList[i].name == sceneName)
                {
                    currentPlanet = planetList[i];
                }
            }
            text.text = currentPlanet.name + "\nTemperature: " + currentPlanet.temp + "K\nMass: " + Math.Round(currentPlanet.mass.massValue, 2) + "x10^" + currentPlanet.mass.massExponent + "kg\nGravity: " + currentPlanet.gravity
            + "m/s^2\nDiscovered By: StL. Bread Co \n" + "in 1980";
        }
        else
        {
            text.text = currentPlanet.name + "\nTemperature: " + currentPlanet.temp + "K\nMass: " + Math.Round(currentPlanet.mass.massValue, 2) + "x10^" + currentPlanet.mass.massExponent + "kg\nGravity: " + currentPlanet.gravity
            + "\nDiscovered By: " + currentPlanet.discoveredBy + "\non " + currentPlanet.discoveryDate;
        }
    }

    // Update is called once per frame
    void Update()
    {
        string jsonString = File.ReadAllText(@"C:\Atul\TigerHacks\TigerHacks\SpaceNav\Assets\scripts\data.json");
        string[] localPlanets = { "Earth", "Venus", "Mars", "Mercury", "Saturn", "Neptune", "Uranus", "Pluto", "Jupiter" };

        var planets = DeserializeObjects<Root>(jsonString).ToList();

        List<Root> planetList = new List<Root>();

        foreach (var planet in planets)
        {
            if (localPlanets.Contains(planet.name))
            {
                planetList.Add(planet);
            }
        }
        text = GetComponent<Text>();
        string sceneName = SceneManager.GetActiveScene().name;

        Root currentPlanet = new Root();
        Debug.Log("Pain");
        //foreach (var obj in planetList)
        for(int i=0; i<planetList.Count(); i++)   
        {
            if (planetList[i].name == sceneName)
            {
                currentPlanet = planetList[i];
            }
        }

        if (sceneName == "EarthLanding")
        {
            foreach (var obj in planetList)
            {
                if (obj.name == "Earth")
                {
                    currentPlanet = obj;
                }
            }
            text.text = currentPlanet.name + "\nTemperature: " + currentPlanet.temp + " K\nMass: " + Math.Round(currentPlanet.mass.massValue, 2) + "x10^" + currentPlanet.mass.massExponent + " kg\nGravity: " + currentPlanet.gravity
            + " m/s^2\nDiscovered By: StL. Bread Co \n" + "in 1980";
        }
        else
        {
            text.text = currentPlanet.name + "\nTemperature: " + currentPlanet.temp + " K\nMass: " + Math.Round(currentPlanet.mass.massValue, 2) + "x10^" + currentPlanet.mass.massExponent + " kg\nGravity: " + currentPlanet.gravity
            + " m/s^2\nDiscovered By: " + currentPlanet.discoveredBy + "\non " + currentPlanet.discoveryDate;
        }
    }
}