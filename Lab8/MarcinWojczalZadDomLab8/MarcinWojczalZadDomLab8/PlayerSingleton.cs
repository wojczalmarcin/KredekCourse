using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinWojczalZadDomLab8
{
    /// <summary>
    /// Klasa gracza (singleton)
    /// </summary>
    class PlayerSingleton
    {
        //Instancja singletonu
        private static PlayerSingleton _instance;

        //Zmienne bitowe określające czy dany przycisk jest naciśnięty
        private bool keyUp = false, keyDown = false, keyLeft = false, keyRight = false;
        private bool keyW = false, keyS = false, keyA = false, keyD = false;

        //Samochód gracza
        public Car PlayersCar { get; set; }

        //Fabryka samochodów
        private CarsFactory carsFactory = new CarsFactory();

        /// <summary>
        /// Konstruktor
        /// </summary>
        private PlayerSingleton() 
        {
            PlayersCar = carsFactory.CreateBlackFast();
            PlayersCar.PosX = 300;
            PlayersCar.PosY = 550;
        }

        /// <summary>
        /// Metoda zwracająca instancję obiektu klasy gracz
        /// </summary>
        /// <returns></returns>
        public static PlayerSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PlayerSingleton();
            }
            return _instance;
        }

        /// <summary>
        /// Metoda obsługująca przyciśnięcie przycisku klawiatury
        /// </summary>
        /// <param name="e"></param>
        public void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                keyA = true;
            if (e.KeyCode == Keys.D)
                keyD = true;
            if (e.KeyCode == Keys.W)
                keyW = true;
            if (e.KeyCode == Keys.S)
                keyS = true;
            if (e.KeyCode == Keys.Left)
                keyLeft = true;
            if (e.KeyCode == Keys.Right)
                keyRight = true;
            if (e.KeyCode == Keys.Up)
                keyUp = true;
            if (e.KeyCode == Keys.Down)
                keyDown = true;
        }

        /// <summary>
        /// Metoda obsługująca zwolnienie przycisku klawiatury
        /// </summary>
        /// <param name="e"></param>
        public void KeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                keyA = false;
            if (e.KeyCode == Keys.D)
                keyD = false;
            if (e.KeyCode == Keys.W)
                keyW = false;
            if (e.KeyCode == Keys.S)
                keyS = false;
            if (e.KeyCode == Keys.Left)
                keyLeft = false;
            if (e.KeyCode == Keys.Right)
                keyRight = false;
            if (e.KeyCode == Keys.Up)
                keyUp = false;
            if (e.KeyCode == Keys.Down)
                keyDown = false;
        }

        /// <summary>
        /// Metoda sterująca samochodem na podstawie naciśniętych klawiszy
        /// </summary>
        public void SteerCar()
        {
            if ((keyA || keyLeft) && PlayersCar.PosX > 60)
            {
                PlayersCar.PosX -= PlayersCar.TurningRate;
                PlayersCar.Angle = -5;
            }
            else
            {
                PlayersCar.Angle = 0;
            }
            if ((keyD || keyRight) && PlayersCar.PosX < 382)
            {
                PlayersCar.PosX += PlayersCar.TurningRate;
                PlayersCar.Angle = 5;
            }
            if ((keyW || keyUp) && PlayersCar.PosY > 0)
            {
                PlayersCar.PosY -= PlayersCar.Speed;
            }
            if ((keyS || keyDown) && PlayersCar.PosY < 800 - 150)
            {
                PlayersCar.PosY += PlayersCar.Speed;
            }

            if ((keyD || keyRight) && (keyA || keyLeft))
            {
                PlayersCar.Angle = 0;
            }
        }
    }
}
