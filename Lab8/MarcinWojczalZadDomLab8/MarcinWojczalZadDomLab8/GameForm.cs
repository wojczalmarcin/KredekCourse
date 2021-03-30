using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinWojczalZadDomLab8
{
    public partial class GameForm : Form
    {
        //Aktualna prędkość gracza/gry
        private double gameSpeed = 2;
        //Maksymalna prędkość gracza/samochodu
        private double maxGameSpeed = 25;
        //Pozycja ulicy na osi Y
        private double streetPosY = 0;
        //Instancja losowych samochodów
        private RandomCars randomCars;
        //iterator timera
        private int timer = 0;
        //wykrycie kolizji
        private bool collision = false;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            randomCars = new RandomCars();
        }

        /// <summary>
        /// Metoda ładująca Form'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Metoda obsługująca timer (1 tick gry)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTickTimer_Tick(object sender, EventArgs e)
        {
            // Pojawianie się pojazdów
            if (timer == 10)
                randomCars.SetRandomCar(0,gameSpeed);
            if (timer == 200)
                randomCars.SetRandomCar(1, gameSpeed);
            if (timer == 500)
                randomCars.SetRandomCar(2, gameSpeed);
            if (timer == 1500)
                randomCars.SetRandomCar(3, gameSpeed);
            if (timer == 3000)
                randomCars.SetRandomCar(4, gameSpeed);

            PlayerSingleton.GetInstance().SteerCar();
            MoveStreet();
            randomCars.MoveRandomCars(gameSpeed);

            if (gameSpeed<maxGameSpeed)
                gameSpeed += 0.005 + PlayerSingleton.GetInstance().PlayersCar.Speed*0.001;
            labelScore.Text = "Wynik:\n" + (int)((gameSpeed-2)*10);
            DetectCollision();
            pictureBoxGraphics.Refresh();
            if (collision)
            {
                gameTickTimer.Stop();
                MessageBox.Show("Porażka!\nTwój wynik: " + (int)((gameSpeed - 2) * 10));
                collision = false;
                this.Close();
            }
            timer++;
            if (timer > 4000)
                timer = 0;
        }

        /// <summary>
        /// Metoda poruszająca ulicę
        /// </summary>
        private void MoveStreet()
        {
            streetPosY += gameSpeed;
            if (streetPosY >= 1024)
                streetPosY = 0;
        }

        /// <summary>
        /// Metoda rysująca grafikę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxGraphics_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.street,0, (int)streetPosY, Properties.Resources.street.Width, Properties.Resources.street.Height);
            e.Graphics.DrawImage(Properties.Resources.street, 0, (int)streetPosY-1024, Properties.Resources.street.Width, Properties.Resources.street.Height);
            PlayerSingleton.GetInstance().PlayersCar.Draw(e);
            randomCars.Draw(e);
        }

        /// <summary>
        /// Metoda obsługująca naciskanie przycisków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            PlayerSingleton.GetInstance().KeyDown(e);
        }

        /// <summary>
        /// Metoda obsługująca puszcanie przycisków 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            PlayerSingleton.GetInstance().KeyUp(e);
        }

        /// <summary>
        /// Funkcja wykrywająca kolizje samochodu gracza z losowymi samochodami
        /// </summary>
        public void DetectCollision()
        {
            var playersCar = PlayerSingleton.GetInstance().PlayersCar;
            foreach (Car car in randomCars.RandomCarsList)
            {
                if ((playersCar.PosX + 50 > car.PosX && playersCar.PosX < car.PosX + 50)
                   && (playersCar.PosY < car.PosY + 140 && playersCar.PosY > car.PosY - 140))
                {
                    collision = true;
                }
            }
        }
    }
}
