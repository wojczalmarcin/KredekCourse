using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceColony
{
    public partial class FormPlanet : Form
    {
        // licznik dni
        private int dayCounter = 0;
        // aktualne podatki, które zostaną zaakceptowane w kolejnym tygodniu
        private double currentTaxes = 0.01;
        // instancaja planety
        private Planet Planet = new Planet(1000,240,0,5,1500);
        // zmienna obsługująca format zapisu procentowego
        NumberFormatInfo numberFormatInfo = new CultureInfo("en-US", false).NumberFormat;
        public FormPlanet()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcja odpowiadająca za obsługę czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGame_Tick(object sender, EventArgs e)
        {
            Planet.Taxes = currentTaxes;
            Planet.PlanetTick();
            dayCounter += 1;
            FillLabels();
            Random random = new Random();
            if(random.Next(60)<=1){
                var formEvents = new FormEvents(Planet);
                formEvents.Show();
            }
        }
        /// <summary>
        /// Funkcja wypełniająca etykiety
        /// </summary>
        private void FillLabels()
        {
            labelTime.Text = "Miesiąc: " + dayCounter;
            labelPop.Text = "Populacja: " + FormatNumber(Planet.Population) + "\n" + Planet.PopulationIncome + "\\Miesiąc";
            labelGold.Text = "Złoto: " + FormatNumber(Planet.Gold) + "\n" + Planet.GoldIncome + "\\Miesiąc";
            labelCrystals.Text = "Kryształy: " + FormatNumber(Planet.Crystals) + "\n" + Planet.CrystalsIncome + "\\Miesiąc";
            labelTitan.Text = "Tytan: " + FormatNumber(Planet.Titan) + "\n" + Planet.TitanIncome + "\\Miesiąc";
            labelFood.Text = "Jedzenie: " + FormatNumber(Planet.Food) + "\n" + Planet.FoodIncome + "\\Miesiąc";
            labelPopularity.Text = "Zadowolenie: " + Planet.Popularity.ToString("P", numberFormatInfo);
            labelTaxes.Text = "Podatki: " + Planet.Taxes.ToString("P", numberFormatInfo);
            labelProtection.Text = "Osłona: " + Planet.PlanetProtection.ToString("P", numberFormatInfo);

        }
        /// <summary>
        /// Funkcja formatująca liczbę na string w tysiącach lub milionach
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private string FormatNumber(int number)
        {
            if (number < 1000)
                return number.ToString();
            else if (number < 1000000)
                return (number / 1000).ToString() + "tys";
            else
                return (number / 1000000).ToString() + "mln";
        }
        /// <summary>
        /// Suwak podatków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarTaxes_Scroll(object sender, EventArgs e)
        {
            if (trackBarTaxes.Value == 0)
                currentTaxes = 0.01;
            else
                currentTaxes = 0.1 * trackBarTaxes.Value;
            labelTaxes.Text = "Podatki: " + currentTaxes.ToString("P", numberFormatInfo);
        }
        /// <summary>
        /// Łatowanie okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPlanet_Load(object sender, EventArgs e)
        {
            numberFormatInfo.PercentDecimalDigits = 0;
            Planet.PlanetTick();
            Planet.Taxes = currentTaxes;
            FillLabels();
            trackBarTaxes.Value = 0;
        }
        /// <summary>
        /// Przycisk tworzący okno budynków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildings_Click(object sender, EventArgs e)
        {

            var formBuildings = new FormBuildings(Planet);
            formBuildings.Show();
        }

    }
}
