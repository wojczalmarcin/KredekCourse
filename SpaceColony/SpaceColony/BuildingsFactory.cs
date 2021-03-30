using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceColony
{
    class BuildingsFactory
    {
        /// <summary>
        ///  Funkcja tworząca instancję kopalni tytanu
        /// </summary>
        /// <returns></returns>
        public Building CreateTitanMine()
        {
            return new Building(-100, 0, 3, 0, -0.03, "KOPALNIA TYTANU",1500,0,10);
        }
        /// <summary>
        /// Funkcja tworząca instancję kopalni złota
        /// </summary>
        /// <returns></returns>
        public Building CreateGoldMine()
        {
            return new Building(500,0,0,0,-0.02,"KOPALNIA ZŁOTA",3500,0,30);
        }
        /// <summary>
        /// Funkcja tworząca instancję kopalni kryształów
        /// </summary>
        /// <returns></returns>
        public Building CreateCrystalMine()
        {
            return new Building(-300, 1, 0, 0, 0, "KOPALNIA KRYSZTAŁÓW", 5000, 0, 60);
        }
        /// <summary>
        /// Funkcja tworząca instancję zrobotyzowanej farmy
        /// </summary>
        /// <returns></returns>
        public Building CreateDronesFarms()
        {
            return new Building(-100, 0, 0, 2000, 0, "ZROBOTYZOWANE FARMY", 1000, 0, 15);
        }
        /// <summary>
        /// Funkcja tworząca instancję gildii kupców
        /// </summary>
        /// <returns></returns>
        public Building CreateMerchantsGuild()
        {
            return new Building(1500, 1, 0, -100, 0.01, "GILDIA KUPCÓW", 10000, 10, 100);
        }
        /// <summary>
        /// Funkcja tworząca instancję centrum kultury
        /// </summary>
        /// <returns></returns>
        public Building CreateCulturalCenter()
        {
            return new Building(-200, 0, 0, 0, 0.02, "CENTRUM KULTURY", 1500, 1, 30);
        }
        /// <summary>
        /// Funkcja tworząca instancję systemu monitorowania zagrożeń
        /// </summary>
        /// <returns></returns>
        public BuildingWarningSystem CreateWarningSystem()
        {
            return new BuildingWarningSystem(-200, -1, -2, 0, 0.02, "SYSTEM MONITOROWANIA ZAGROŻEŃ", 2000, 1, 25,0.05);
        }
    }
}
