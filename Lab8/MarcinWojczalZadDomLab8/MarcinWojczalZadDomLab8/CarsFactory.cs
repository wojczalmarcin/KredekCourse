using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab8
{
    class CarsFactory
    {
        private CarsImages carsImages = new CarsImages();
        private Random random = new Random();
        public Car CreateWhiteSlow() { return new Car(1, 3, carsImages.CarsImagesArray[0]); }
        public Car CreateWhiteMedium() { return new Car(2, 4, carsImages.CarsImagesArray[1]); }
        public Car CreateWhiteFast() { return new Car(3, 4, carsImages.CarsImagesArray[3]); }
        public Car CreateWhitePickUp() { return new Car(1, 2, carsImages.CarsImagesArray[5]); }
        public Car CreateYellowTaxi() { return new Car(2, 4, carsImages.CarsImagesArray[2]); }
        public Car CreateWhiteTaxi() { return new Car(2, 4, carsImages.CarsImagesArray[4]); }
        public Car CreateBlackFast() { return new Car(4, 5, carsImages.CarsImagesArray[6]); }
        public Car CreateRedPickUp() { return new Car(1, 3, carsImages.CarsImagesArray[7]); }
        public Car CreateAmbulance() { return new Car(3, 3, carsImages.CarsImagesArray[8]); }
        public Car CreatePoliceCarBlue() { return new Car(2, 3, carsImages.CarsImagesArray[9]); }
        public Car CreatePoliceCarBlack() { return new Car(3, 3, carsImages.CarsImagesArray[10]); }
        public Car CreatePoliceCarSecret() { return new Car(4, 5, carsImages.CarsImagesArray[11]); }

        /// <summary>
        /// Metoda tworząca losowy samochód
        /// </summary>
        /// <returns></returns>
        public Car CreateRandomCar() 
        {

            switch (random.Next(12))
            {
                case 0:
                    return CreateWhiteSlow();
                case 1:
                    return CreateWhiteMedium();
                case 2:
                    return CreateWhiteFast();
                case 3:
                    return CreateWhitePickUp();
                case 4:
                    return CreateYellowTaxi();
                case 5:
                    return CreateWhiteTaxi();
                case 6:
                    return CreateBlackFast();
                case 7:
                    return CreateRedPickUp();
                case 8:
                    return CreateAmbulance();
                case 9:
                    return CreatePoliceCarBlue();
                case 10:
                    return CreatePoliceCarBlack();
                default:
                    return CreatePoliceCarSecret();
            }
        }
    }
}
