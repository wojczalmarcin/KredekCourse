using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony
{
    public class Building
    {
        // Bazowe wartości przychodu poszczególnych surowców
        protected int  baseGoldIncome, baseCrystalsIncome,
            baseTitanIncome, baseFoodIncome, baseGoldCost,baseCrystalCost,baseTitanCost;
        protected double basePopularity;
        // Potrzebne złoto do zwiększenia poziomu
        public int GoldCost { get; set; }
        // Potrzebne kryształy do zwiększenia poziomu
        public int CrystalCost { get; set; }
        // Potrzebny tytan do zwiększenia poziomu
        public int TitanCost { get; set; }
        // Ilość zwiększającej się populacji w jednostce czasu
        public int GoldIncome { get; set; }
        // Ilość otrzymywanych kryształów w jednostce czasu
        public int CrystalsIncome { get; set; }
        // Ilość otrzymywanego tytanu w jednostce czasu
        public int TitanIncome { get; set; }
        // Ilość otrzymywanego jedzenia w jednostce czasu
        public int FoodIncome { get; set; }
        // Zadowolenie w procentach
        public double Popularity { get; set; }
        // Poziom budynku
        public int BuildingLevel { get; set; }
        // Nazwa budynku
        public string Name { get; set; }
        // Czy poziom jest już maksymalny
        public bool maxLevel { get; set; }  = false;

        /// <summary>
        /// Pusty konstruktor
        /// </summary>
        public Building()
        {
            BuildingLevel = 0;
            baseGoldIncome = 0;
            baseCrystalsIncome = 0;
            baseTitanIncome = 0;
            baseFoodIncome = 0;
            basePopularity = 0;
            Name = "";
            baseGoldCost = 0;
            baseCrystalCost = 0;
            baseTitanCost = 0;
            GoldCost = 0;
            CrystalCost = 0;
            TitanCost = 0;

            GoldIncome = 0;
            CrystalsIncome = 0;
            TitanIncome = 0;
            FoodIncome = 0;
            Popularity = 0;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="baseGoldIncome"></param>
        /// <param name="baseCrystalsIncome"></param>
        /// <param name="baseTitanIncome"></param>
        /// <param name="baseFoodIncome"></param>
        /// <param name="basePopularity"></param>
        /// <param name="basebuildingLevel"></param>
        public Building(int baseGoldIncome, int baseCrystalsIncome,
            int baseTitanIncome, int baseFoodIncome, double basePopularity, string Name,
            int baseGoldCost, int baseCrystalCost,int baseTitanCost)
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

            GoldIncome = 0;
            CrystalsIncome = 0;
            TitanIncome = 0;
            FoodIncome = 0;
            Popularity = 0;
        }

        /// <summary>
        /// Funkcja zwiększająca poziom budynku oraz aktualizująca jego przychody
        /// </summary> 
        public void Upgrade(int lvl,Planet planet)
        {
            if (BuildingLevel < 10)
            {
                BuildingLevel += lvl;
                GoldIncome = baseGoldIncome * BuildingLevel;
                CrystalsIncome = baseCrystalsIncome * BuildingLevel;
                TitanIncome = baseTitanIncome * BuildingLevel;
                FoodIncome = baseFoodIncome * BuildingLevel;
                Popularity = basePopularity * BuildingLevel;
                planet.Gold -= GoldCost;
                planet.Titan -= TitanCost;
                planet.Crystals -= CrystalCost;

                GoldCost = baseGoldCost * (BuildingLevel + 1);
                TitanCost = baseTitanCost * (BuildingLevel + 1);
                CrystalCost = baseCrystalCost * (BuildingLevel + 1);
            }
            else
                maxLevel = true;
        }
        /// <summary>
        /// Funkcja zwaracająca wartość przypływu złota jaką będzie dawać następny poziom budynku
        /// </summary>
        /// <returns></returns>
        public int GetNextGoldIncome()
        {
            return baseGoldIncome * (BuildingLevel + 1);
        }
        /// <summary>
        /// Funkcja zwaracająca wartość przypływu tytanu jaką będzie dawać następny poziom budynku
        /// </summary>
        /// <returns></returns>
        public int GetNextTitanIncome()
        {
            return baseTitanIncome * (BuildingLevel + 1);
        }
        /// <summary>
        /// Funkcja zwaracająca wartość przypływu kryształów jaką będzie dawać następny poziom budynku
        /// </summary>
        /// <returns></returns>
        public int GetNextCrystalIncome()
        {
            return baseCrystalsIncome * (BuildingLevel + 1);
        }
        /// <summary>
        /// Funkcja zwaracająca wartość przypływu jedzenia jaką będzie dawać następny poziom budynku
        /// </summary>
        /// <returns></returns>
        public int GetNextFoodIncome()
        {
            return baseFoodIncome * (BuildingLevel + 1);
        }
        /// <summary>
        /// Funkcja zwaracająca wartość o jaką powiększy się popularnośc przy następnym poziomie budynku
        /// </summary>
        /// <returns></returns>
        public double GetNextPopularity()
        {
            return basePopularity * (BuildingLevel + 1);
        }

    }
}
