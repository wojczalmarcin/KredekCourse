using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense 
{
    class Army : IUnitActions
    {
        /// <summary>
        /// Lista jednostek piechoty
        /// </summary>
        public List<Infantry> InfantryList { get; set; }
        /// <summary>
        /// Lista czołgów
        /// </summary>
        public List<Tank> TankList { get; set; }
        /// <summary>
        /// Lista samolotów
        /// </summary>
        public List<Plane> PlaneList { get; set; }
        /// <summary>
        /// Lista wszystkich jednostek razem
        /// </summary>
        public List<Unit> UnitList { get; set; }
        /// <summary>
        /// Instancja fabryki jednostek
        /// </summary>
        private UnitFactory unitFactory = new UnitFactory();

        /// <summary>
        /// Konstruktor tworzący losową armie zależną od dnia
        /// </summary>
        /// <param name="day"></param>
        public Army(double day)
        {
            InfantryList = new List<Infantry>();
            TankList = new List<Tank>();
            PlaneList = new List<Plane>();

            for(int i = 0; i < day; i++)
            {
                InfantryList.Add(unitFactory.CreateInfantry.RandomInfantry()); 
            }
            for(int i = 0; i < day / 2; i++)
            {
                TankList.Add(unitFactory.CreateTank.RandomTank());
            }
            for (int i = 0; i < day / 3; i++)
            {
                PlaneList.Add(unitFactory.CreatePlane.RandomPlane());
            }
            RefreshUnitList();
        }
        /// <summary>
        /// Pusty konstruktor
        /// </summary>
        public Army()
        {
            InfantryList = new List<Infantry>();
            TankList = new List<Tank>();
            PlaneList = new List<Plane>();
        }
        /// <summary>
        /// Funkcja odświeżająca listę wszystkich jednostek
        /// </summary>
        public void RefreshUnitList()
        {
            UnitList = null;
            UnitList = new List<Unit>();
            UnitList.AddRange(InfantryList);
            UnitList.AddRange(TankList);
            UnitList.AddRange(PlaneList);
        }
        /// <summary>
        /// Funkcja odpowiedzialna za atak drugiej armii
        /// </summary>
        /// <param name="enemyArmy"></param>
        /// <param name="random"></param>
        public void Attack(Army enemyArmy,Random random)
        {
            if (InfantryList.Any())
            {
                foreach (Infantry infantry in InfantryList)
                {
                    infantry.Attack(enemyArmy, random);
                    enemyArmy.Sort();
                }
            }
            if (TankList.Any())
            {
                foreach (Tank tank in TankList)
                {
                    tank.Attack(enemyArmy, random);
                    enemyArmy.Sort();
                }
            }
            if (PlaneList.Any())
            {
                foreach (Plane plane in PlaneList)
                {
                    plane.Attack(enemyArmy, random);
                    enemyArmy.Sort();
                }
            }

        }
        /// <summary>
        /// Funkcja sortujaca wszystkie listy
        /// </summary>
        public void Sort()
        {
            InfantryList.Sort(new UnitListComparer());
            TankList.Sort(new UnitListComparer());
            PlaneList.Sort(new UnitListComparer());
        }
        /// <summary>
        /// Funkcja pobierająca koszt całej armii
        /// </summary>
        /// <returns></returns>
        public int GetTotalArmyCost()
        {
            int cost = 0;
            foreach (Unit unit in UnitList)
            {
                cost += unit.TotalCost;
            }
            return cost;
        }
    }
}
