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
    /// Klasa samochód
    /// </summary>
    public class Car
    {
        //Pozycja na osi X
        public double PosX { get; set; }
        //Pozycja na osi Y
        public double PosY { get; set; }
        //Współczynnik prędkości/przyspieszenia
        public int Speed { get; }
        //Model samochodu pobranego ze sprite sheet
        private Image CarModel;
        //Prędkość skrętu
        public int TurningRate { get; }
        //Kąt obrazka modelu
        public float Angle { get; set; } = 0;

        //Kierunek jazdy
        public Direction DrivingDirection { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="carModel"></param>
        /// <param name="turningRate"></param>
        public Car(int speed, int turningRate, Image carModel)
        {
            Speed = speed;
            TurningRate = turningRate;
            CarModel = carModel;
        }

        /// <summary>
        /// Pusty kontruktor
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// Metoda poruszająca samochód prosto
        /// </summary>
        public void DriveStraight(double gameSpeed)
        {
            PosY += gameSpeed + 2 * (int)DrivingDirection;
        }
        /// <summary>
        /// Metoda rysująca samochód
        /// </summary>
        /// <param name="e"></param>
        public void Draw(PaintEventArgs e)
        {
            var image = RotateImage(CarModel, Angle);
            e.Graphics.DrawImage(image, (int)PosX, (int)PosY, image.Width, image.Height);
        }

        /// <summary>
        /// Metoda obracająca obrazek
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rotationAngle"></param>
        /// <returns></returns>
        private static Image RotateImage(Image img, float rotationAngle)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            return bmp;
        }

        /// <summary>
        /// Enum kieunków jazdy
        /// </summary>
        public enum Direction
        {
            Top = -1,
            Bottom = 1
        }
    }
}
