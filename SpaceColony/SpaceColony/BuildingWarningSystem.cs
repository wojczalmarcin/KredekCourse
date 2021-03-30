using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony
{
    public class BuildingWarningSystem : Building
    {
        // zmienna osłony jaką zapewni ten budynek planecie
        private double basePlanetProtection;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="baseGoldIncome"></param>
        /// <param name="baseCrystalsIncome"></param>
        /// <param name="baseTitanIncome"></param>
        /// <param name="baseFoodIncome"></param>
        /// <param name="basePopularity"></param>
        /// <param name="Name"></param>
        /// <param name="baseGoldCost"></param>
        /// <param name="baseCrystalCost"></param>
        /// <param name="baseTitanCost"></param>
        /// <param name="basePlanetProtection"></param>
        public BuildingWarningSystem(int baseGoldIncome, int baseCrystalsIncome,
           int baseTitanIncome, int baseFoodIncome, double basePopularity, string Name,
           int baseGoldCost, int baseCrystalCost, int baseTitanCost, double basePlanetProtection)
        {
            BuildingLevel = 0;
            this.baseGoldIncome = baseGoldIncome;
            this.baseCrystalsIncome = baseCrystalsIncome;
            this.baseTitanIncome = baseTitanIncome;
            this.baseFoodIncome = baseFoodIncome;
            this.basePopularity = basePopularity;
            this.Name = Name;
            this.baseGoldCost = baseGoldCost;
            this.baseCrystalCost = baseCrystalCost;
            this.baseTitanCost = baseTitanCost;
            GoldCost = baseGoldCost;
            CrystalCost = baseCrystalCost;
            TitanCost = baseTitanCost;
            this.basePlanetProtection = basePlanetProtection;

            GoldIncome = 0;
            CrystalsIncome = 0;
            TitanIncome = 0;
            FoodIncome = 0;
            Popularity = 0;
        }
        /// <summary>
        /// Funkcja aktualizuje poziom osłony planety
        /// </summary>
        /// <param name="planet"></param>
        public void UpgradeProtection(Planet planet)
        {
            planet.PlanetProtection = basePlanetProtection * BuildingLevel;
        }
        /// <summary>
        /// Funkcja zwaracająca wartość osłony jaką będzie dawać następny poziom budynku
        /// </summary>
        /// <returns></returns>
        public double GetNextProtectionLevel()
        {
            return basePlanetProtection * (BuildingLevel + 1);
        }
    }
}
