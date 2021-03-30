using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony
{
    public  class CataclysmEvents
    {
        // zmienna losowa
        private  Random random = new Random();
        // instancja planety
        private Planet planet;
        // string informujący o stratach podczas wydarzenia
        public string eventStatus { get; set; } = "";
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="planet"></param>
        public CataclysmEvents(Planet planet)
        {
            this.planet = planet;
        }
        /// <summary>
        /// Funkcja realizująca katastrofę wiatru słonecznego
        /// </summary>
        public void SolarWind()
        {
            int deathCount = random.Next((int)(planet.Population * 0.005 / planet.PlanetProtection));
            planet.Population -= deathCount;
            eventStatus += "Do naszej planety dotarł wiatr słoneczny.\nPodczas katastrofy zginęło:" + deathCount + " osób";
            if (random.Next(10) < 1/ planet.PlanetProtection)
            {
                if (planet.buildingList[3].BuildingLevel > 0)
                {
                    planet.buildingList[3].Upgrade(-1, planet);
                    eventStatus += " oraz zostały uszkodzone farmy";
                }
                    
            }
        }
        /// <summary>
        /// Funkcja realizująca katastrofę meteorytu
        /// </summary>
        public void Meteorite()
        {
            int deathCount = planet.Population -= random.Next((int)(planet.Population * 0.009 / planet.PlanetProtection));
            planet.Population -= deathCount;
            eventStatus += "Na naszą planetę spadł meteoryd.\nPodczas katastrofy zginęło:" + deathCount + " osób";
            if (random.Next(10) < 3 / planet.PlanetProtection)
            {
                int buildingIndex = random.Next(5);
                if (planet.buildingList[buildingIndex].BuildingLevel > 0)
                {
                    planet.buildingList[buildingIndex].Upgrade(-1, planet);
                    eventStatus += "\nUszkodzone: " + planet.buildingList[buildingIndex].Name;
                }
                    
            }
            if (random.Next(10) < 3 / planet.PlanetProtection)
            {
                int buildingIndex = random.Next(5);
                if (planet.buildingList[buildingIndex].BuildingLevel > 0)
                {
                    planet.buildingList[buildingIndex].Upgrade(-1, planet);
                    eventStatus += "\nUszkodzone: " + planet.buildingList[buildingIndex].Name;
                }
                    
            }
            if (random.Next(10) < 3 / planet.PlanetProtection)
            {
                int buildingIndex = random.Next(5);
                if (planet.buildingList[buildingIndex].BuildingLevel > 0)
                {
                    planet.buildingList[buildingIndex].Upgrade(-1, planet);
                    eventStatus += "\nUszkodzone: " + planet.buildingList[buildingIndex].Name;
                }
                    
            }
        }
        /// <summary>
        /// Funkcja realizująca katastrofę wulkaniczną
        /// </summary>
        public void VolcanoEuption()
        {
            int deathCount = planet.Population -= random.Next((int)(planet.Population * 0.006 / planet.PlanetProtection));
            planet.Population -= deathCount;
            eventStatus += "Na naszej planecie wybuchł wulkan.\nPodczas katastrofy zginęło:" + deathCount + " osób";
            if (random.Next(10) < 2 / planet.PlanetProtection)
            {
                int buildingIndex = random.Next(5);
                if (planet.buildingList[buildingIndex].BuildingLevel > 0)
                {
                    planet.buildingList[buildingIndex].Upgrade(-1, planet);
                    eventStatus += "\nUszkodzone: " + planet.buildingList[buildingIndex].Name;
                }
                   
            }
            if (random.Next(10) < 1 / planet.PlanetProtection)
            {
                int buildingIndex = random.Next(5);
                if (planet.buildingList[buildingIndex].BuildingLevel > 0)
                {
                    planet.buildingList[buildingIndex].Upgrade(-1, planet);
                    eventStatus += "\nUszkodzone: " + planet.buildingList[buildingIndex].Name;
                }
                  
            }
        }
       
    }
}
