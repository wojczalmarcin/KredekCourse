using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MarcinWojczalZadDomLab8
{
    /// <summary>
    /// Klasa reprezentująca losowo jadące samochody
    /// </summary>
    class RandomCars
    {
        /// <summary>
        /// Lista losowych samochodów
        /// </summary>
        public List<Car> RandomCarsList { get; set; }
        // Fabryka samochodów
        private CarsFactory carsFactory = new CarsFactory();
        // Typ losowy
        private Random random = new Random();

        /// <summary>
        /// Konstruktor
        /// </summary>
        public RandomCars()
        {
            RandomCarsList = new List<Car>()
            {
                carsFactory.CreateRandomCar(),
                carsFactory.CreateRandomCar(),
                carsFactory.CreateRandomCar(),
                carsFactory.CreateRandomCar(),
                carsFactory.CreateRandomCar()
            };
            foreach (Car car in RandomCarsList)
            {
                car.PosX = 0;
                car.PosY = -1200;
            }
        }
        
        /// <summary>
        /// Metoda rysująca losowe samochody
        /// </summary>
        /// <param name="e"></param>
        public void Draw(PaintEventArgs e)
        {
            foreach(Car car in RandomCarsList)
            {
                car.Draw(e);
            }
        }

        /// <summary>
        /// Metoda poruszająca samochody
        /// </summary>
        /// <param name="gameSpeed"></param>
        public void MoveRandomCars(double gameSpeed)
        {
            for (int i = 0; i < RandomCarsList.Count; i++)
            {
                if (RandomCarsList[i].PosY > -1000)
                {
                    RandomCarsList[i].DriveStraight(gameSpeed);
                    if (RandomCarsList[i].PosY > 800 || (RandomCarsList[i].PosY<-200 && RandomCarsList[i].PosY>-300))
                    {
                        SetRandomCar(i, gameSpeed);
                    }
                }
            }
        }

        /// <summary>
        /// Metoda ustawiająca samochody na pozycjach na ulicy
        /// </summary>
        /// <param name="carIndex"></param>
        /// <param name="gameSpeed"></param>
        public void SetRandomCar(int carIndex,double gameSpeed)
        {
            RandomCarsList[carIndex] = carsFactory.CreateRandomCar();
            int randomPos = random.Next(4);
            if (randomPos == 0)
            {
                RandomCarsList[carIndex].PosX = 75;
                RandomCarsList[carIndex].DrivingDirection = Car.Direction.Bottom;
                RandomCarsList[carIndex].Angle = 180;
            }
            else if (randomPos == 1)
            {
                RandomCarsList[carIndex].PosX = 175;
                RandomCarsList[carIndex].DrivingDirection = Car.Direction.Bottom;
                RandomCarsList[carIndex].Angle = 180;
            }
            else if (randomPos == 2)
            {
                RandomCarsList[carIndex].PosX = 270;
                RandomCarsList[carIndex].DrivingDirection = Car.Direction.Top;
                RandomCarsList[carIndex].Angle = 0;
            }
            else
            {
                RandomCarsList[carIndex].PosX = 370;
                RandomCarsList[carIndex].DrivingDirection = Car.Direction.Top;
                RandomCarsList[carIndex].Angle = 0;
            }
            if (DetectSpawnedCars(carIndex, gameSpeed) == true)
            {
                RandomCarsList[carIndex].PosY = 810;
            }
            else
                RandomCarsList[carIndex].PosY = -140;
        }

        /// <summary>
        /// Metoda wykrywająca czy pojawiający się samochód koliduje z innymi autami
        /// </summary>
        /// <param name="carIndex"></param>
        /// <returns></returns>
        private bool DetectSpawnedCars(int carIndex, double gameSpeed)
        {
            int xBoundry = 70;

            if (gameSpeed > 24)
                xBoundry = 200;
            else if (gameSpeed > 6)
                xBoundry = 70;
            else if (gameSpeed > 3)
                xBoundry = 200;

            for (int i = 0; i < RandomCarsList.Count; i++)
            {
                if (i != carIndex)
                {
                    if (RandomCarsList[carIndex].PosY > -1000)
                    {
                        if (RandomCarsList[carIndex].PosY + 400 > RandomCarsList[i].PosY &&
                          (RandomCarsList[carIndex].PosX + xBoundry > RandomCarsList[i].PosX && RandomCarsList[carIndex].PosX < RandomCarsList[i].PosX + xBoundry))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
