using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab8
{
    /// <summary>
    /// Klasa reprezentująca listę obrazków samochodów ze sprite sheet 
    /// </summary>
    class CarsImages
    {
        /// <summary>
        /// Lista obrazków samochodó
        /// </summary>
        public Image [] CarsImagesArray { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public CarsImages()
        {
            CarsImagesArray = new Image[12];
            var img = Properties.Resources.cars;
            for (int i = 0; i < 12; i++)
            {
                CarsImagesArray[i] = new Bitmap(70, 145);
                var graphics = Graphics.FromImage(CarsImagesArray[i]);
                int srcY;
                if (i < 4)
                    srcY = 0;
                else if (i < 8)
                    srcY = 145;
                else
                    srcY = 290;
                graphics.DrawImage(img, new Rectangle(0, 0, 70, 145), new Rectangle((i % 4) * 70, srcY, 70, 145), GraphicsUnit.Pixel);
                graphics.Dispose();
            }
        }
    }
}
