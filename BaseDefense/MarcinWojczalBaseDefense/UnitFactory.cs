using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalBaseDefense
{
    class UnitFactory
    {
        /// <summary>
        /// Instancja klasy zagnieżdżonej służącej to tworzenia piechoty
        /// </summary>
        public InfantryFactory CreateInfantry { get; } = new InfantryFactory();
        /// <summary>
        /// Instancja klasy zagnieżdżonej służącej to tworzenia czołgów
        /// </summary>
        public TankFactory CreateTank { get; } = new TankFactory();
        /// <summary>
        /// Instancja klasy zagnieżdżonej służącej to tworzenia samolotów
        /// </summary>
        public PlaneFactory CreatePlane { get; } = new PlaneFactory();

        /// <summary>
        /// Klasa zagnieżdżona służąca do tworzenia piechoty
        /// </summary>
        public class InfantryFactory
        {
            // instancja pseudolosowości
            private Random random = new Random();

            /// <summary>
            /// Tworzy lekką piechotę
            /// </summary>
            /// <returns></returns>
            public Infantry LightInfantry()
            {
                return new Infantry("Lekka piechota", 64, 15, 1, 1, 5,ETarget.Infantry,10);
            }
            /// <summary>
            /// Tworzy komandosów
            /// </summary>
            /// <returns></returns>
            public Infantry Commandos()
            {
                return new Infantry("Komandosi", 130, 40, 2, 6, 1, ETarget.Infantry,40);
            }
            /// <summary>
            /// Tworzy ciężką piechotę
            /// </summary>
            /// <returns></returns>
            public Infantry HeavyInfantry()
            {
                return new Infantry("Ciężka piechota", 160, 35, 1, 1, 2, ETarget.Infantry,30);
            }
            /// <summary>
            /// Tworzy piechotę przeciwlotniczą
            /// </summary>
            /// <returns></returns>
            public Infantry AAInfantry()
            {
                return new Infantry("Piechota przeciwlotnicza", 48, 7, 0, 0, 20, ETarget.Plane,25);

            }
            /// <summary>
            /// Tworzy piechotę przeciwpancerną
            /// </summary>
            /// <returns></returns>
            public Infantry ATInfantry()
            {
                return new Infantry("Piechota przeciwpancerna", 64, 7, 20, 30, 0, ETarget.Tank,25);
            }
            /// <summary>
            /// Tworzy losową jednostkę piechoty
            /// </summary>
            /// <returns></returns>
            public Infantry RandomInfantry()
            {
               
                int chooseRandom = random.Next(7);
                switch (chooseRandom)
                {
                    case 0:
                        return ATInfantry();
                    case 1:
                        return Commandos();
                    case 2:
                        return HeavyInfantry();
                    case 3:
                        return AAInfantry();
                    default:
                        return LightInfantry();
                }
            }
        }
        /// <summary>
        /// Instancja klasy zagnieżdżonej służącej to tworzenia czołgów
        /// </summary>
        public class TankFactory
        {
            // instancja pseudolosowości
            private Random random = new Random();
            /// <summary>
            /// Tworzy czołg lekki
            /// </summary>
            /// <returns></returns>
            public Tank LightTank()
            {
                return new Tank("Czołg lekki", 120, 50, 6, 10, 10, 10, ETarget.Infantry,55);
            }
            /// <summary>
            /// Tworzy czołg średni
            /// </summary>
            /// <returns></returns>
            public Tank MediumTank()
            {
                return new Tank("Czołg średni", 140, 30, 15, 25, 5, 20, ETarget.Infantry,70);
            }
            /// <summary>
            /// Tworzy czołg ciężki
            /// </summary>
            /// <returns></returns>
            public Tank HeavyTank()
            {
                return new Tank("Czołg ciężki", 280, 10, 30, 40, 1, 40, ETarget.Tank,140);
            }
            /// <summary>
            /// Tworzy czołg podstawowy
            /// </summary>
            /// <returns></returns>
            public Tank MBTank()
            {
                return new Tank("Czołg podstawowy", 200, 30, 30, 30, 5, 30, ETarget.Tank,110);
            }
            /// <summary>
            /// Tworzy niszczyciel czołgów
            /// </summary>
            /// <returns></returns>
            public Tank TankDestroyer()
            {
                return new Tank("Niszczyciel czołgów", 40, 5, 45, 30, 0, 5, ETarget.Tank,80);
            }
            /// <summary>
            /// Tworzy losowy czołg
            /// </summary>
            /// <returns></returns>
            public Tank RandomTank()
            {
                int chooseRandom = random.Next(8);
                switch (chooseRandom)
                {
                    case 0:
                        return HeavyTank();
                    case 1:
                        return LightTank();
                    case 2:
                        return LightTank();
                    case 3:
                        return TankDestroyer();
                    case 4:
                        return TankDestroyer();
                    case 5:
                        return MBTank();
                    default:
                        return MediumTank();
                }
            }
        }
        /// <summary>
        /// Instancja klasy zagnieżdżonej służącej to tworzenia samolotów
        /// </summary>
        public class PlaneFactory
        {
            // instancja pseudolosowości
            private Random random = new Random();
            /// <summary>
            /// Tworzy myśliwiec
            /// </summary>
            /// <returns></returns>
            public Plane Fighter()
            {
                return new Plane("Myśliwiec", 64, 30, 2, 2, 45, 11, ETarget.Plane,220);
            }
            /// <summary>
            /// Tworzy lekki bombowiec
            /// </summary>
            /// <returns></returns>
            public Plane LightBomber()
            {
                return new Plane("Lekki Bombowiec", 80, 90, 10, 10, 5, 6,ETarget.Infantry,120);
            }
            /// <summary>
            /// Tworzy ciężki bombowiec
            /// </summary>
            /// <returns></returns>
            public Plane HeavyBomber()
            {
                return new Plane("Ciężki bombowiec", 104, 200, 35, 200, 3, 2, ETarget.Tank,280);
            }
            /// <summary>
            /// Tworzy samolot wielozadaniowy
            /// </summary>
            /// <returns></returns>
            public Plane MultiPurpose()
            {
                return new Plane("Samolot wielozadaniowy", 72, 27, 20, 40, 30, 10, ETarget.Tank,200);
            }
            /// <summary>
            /// Tworzy losowy samolot
            /// </summary>
            /// <returns></returns>
            public Plane RandomPlane()
            {
                int chooseRandom = random.Next(6);
                switch (chooseRandom)
                {
                    case 0:
                        return Fighter();
                    case 1:
                        return LightBomber();
                    case 2:
                        return HeavyBomber();
                    default:
                        return MultiPurpose();
                }
            }
        }
    }
}
