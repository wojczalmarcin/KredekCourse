using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony
{
    public class Planet
    {
        // Bazowe własności planety
        private int basePopulationIncome, baseGoldIncome, baseTitanIncome, baseCrystalsIncome,
            baseFoodIncome;
        // Liczba populacji
        public int Population { get; set; } = 0;
        // Ilość złota
        public int Gold { get; set; } = 0;
        // Ilość kryształów
        public int Crystals { get; set; } = 0;
        // Ilość tytanu
        public int Titan { get; set; } = 0;
        // Ilość jedzenia
        public int Food { get; set; } = 0;
        // Podatki w procentach
        public double Taxes { get; set; } = 0.01;
        // Zadowolenie w procentach
        public double Popularity { get; set; } = 0.00;
        // Zadowolenie w procentach pochodzące z budynków
        public double PopularityFromBuildings { get; set; } = 0;

        // Ilość zwiększającej się populacji w jednostce czasu
        public int PopulationIncome { get; set; } = 0;
        // Ilość otrzymywanego złota w jednostce czasu
        public int GoldIncome { get; set; } = 0;
        // Ilość otrzymywanego złota z budynków w jednostce czasu
        public int GoldIncomeBuildings { get; set; } = 0;
        // Ilość otrzymywanych kryształów w jednostce czasu
        public int CrystalsIncome { get; set; } = 0;
        // Ilość otrzymywanego tytanu w jednostce czasu
        public int TitanIncome { get; set; } = 0;
        // Ilość otrzymywanego jedzenia w jednostce czasu
        public int FoodIncome { get; set; } = 0;
        // Bonus popularności
        private int popularityBonus = 0;

        // Współczynnik osłony planety przed zagrożeniami
        public double PlanetProtection { get; set; } = 0.01;

        public List<Building> buildingList { get; set; }
        public BuildingWarningSystem buildingWarningSystem { get; set; }
        private BuildingsFactory BuildingsFactory;
        /// <summary>
        /// Pusty konstruktor
        /// </summary>
        public Planet() {
            InitBuildingList();
        }
        /// <summary>
        /// Konstruktor przychodów
        /// </summary>
        /// <param name="populationIncome"></param>
        /// <param name="goldIncome"></param>
        /// <param name="crystalsIncome"></param>
        /// <param name="titanIncome"></param>
        /// <param name="foodIncome"></param>
        public Planet(int basePopulationIncome, int baseGoldIncome, int baseCrystalsIncome, int baseTitanIncome, int baseFoodIncome)
        {
            InitBuildingList();
            Taxes = 0.01;
            this.basePopulationIncome = basePopulationIncome;
            this.baseGoldIncome = baseGoldIncome;
            this.baseCrystalsIncome = baseCrystalsIncome;
            this.baseTitanIncome = baseTitanIncome;
            this.baseFoodIncome = baseFoodIncome;
            PopulationIncome = basePopulationIncome;
            GoldIncome = baseGoldIncome;
            CrystalsIncome = baseCrystalsIncome;
            TitanIncome = baseTitanIncome;
            FoodIncome = baseFoodIncome;
        }


        /// <summary>
        /// Funkcja obsługująca czas w planecie
        /// </summary>
        public void PlanetTick()
        {
            // zadowolenie rośnie gdy podatki są mniejsze od 20% w innym przypadku maleje
            if (Taxes < 0.2)
            {
                Popularity = PopularityFromBuildings + (0.007 / Taxes);
            }
            else
                Popularity = PopularityFromBuildings - Taxes * Taxes;

            Population += PopulationIncome;
            int foodConsumption = Population / 2 - popularityBonus;
            Gold += GoldIncome;
            Crystals += CrystalsIncome;
            Titan += TitanIncome;
            Food += FoodIncome;
            Food -= foodConsumption;
            if (Population < 0)
                Population = 0;
            PopulationIncome = FoodIncome - foodConsumption;

            //Wyliczanie przychodu na następny tydzień
            FoodIncome = baseFoodIncome;
            GoldIncome = baseGoldIncome + (int)(Population * Taxes * 0.1);
            CrystalsIncome = baseCrystalsIncome;
            TitanIncome = baseTitanIncome;
            foreach (Building building in buildingList){
                GoldIncome += building.GoldIncome;
                CrystalsIncome += building.CrystalsIncome;
                TitanIncome += building.TitanIncome;
                Popularity += building.Popularity;
                FoodIncome += building.FoodIncome;
            }
                GoldIncome += buildingWarningSystem.GoldIncome;
                CrystalsIncome += buildingWarningSystem.CrystalsIncome;
                TitanIncome += buildingWarningSystem.TitanIncome;
                Popularity += buildingWarningSystem.Popularity;
                FoodIncome += buildingWarningSystem.FoodIncome;

            if (Popularity > -0.3)
                popularityBonus = (int)(Popularity * 0.2 * Population);
            else
                popularityBonus = (int)(Popularity * 0.5 * Population);
        }
        /// <summary>
        /// Inicjacja budynków
        /// </summary>
        private void InitBuildingList()
        {
            buildingList = new List<Building>();
            BuildingsFactory = new BuildingsFactory();
            buildingList.Add(BuildingsFactory.CreateGoldMine());
            buildingList.Add(BuildingsFactory.CreateTitanMine());
            buildingList.Add(BuildingsFactory.CreateCrystalMine());
            buildingList.Add(BuildingsFactory.CreateDronesFarms());
            buildingList.Add(BuildingsFactory.CreateCulturalCenter());
            buildingList.Add(BuildingsFactory.CreateMerchantsGuild());
            buildingWarningSystem = BuildingsFactory.CreateWarningSystem();

        }
    }
}
