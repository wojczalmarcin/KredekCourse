using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceColony
{
    public partial class FormBuildings : Form
    {
       // zmienna do modyfikacji pól planety
        Planet planet;
        // zmienna obsługująca format zapisu procentowego
        NumberFormatInfo numberFormatInfo = new CultureInfo("en-US", false).NumberFormat;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="planet"></param>
        public FormBuildings(Planet planet)
        {
            this.planet = planet;
            InitializeComponent();
           
        }
        /// <summary>
        /// Przycisk do upgrade'owania kopalni złota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoldMine_Click(object sender, EventArgs e)
        {
            planet.buildingList[0].Upgrade(1,planet);
           
        }
        /// <summary>
        /// Przycisk do upgrade'owania kopalni tytanu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTitanMine_Click(object sender, EventArgs e)
        {
            planet.buildingList[1].Upgrade(1,planet);
        }
        /// <summary>
        /// Przycisk do upgrade'owania kopalni kryształów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrystalMine_Click(object sender, EventArgs e)
        {
            planet.buildingList[2].Upgrade(1,planet);
        }
        /// <summary>
        /// Przycisk do upgrade'owania zrobotyzowanych farm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDronesFarms_Click(object sender, EventArgs e)
        {
            planet.buildingList[3].Upgrade(1,planet);
        }
        /// <summary>
        /// Przycisk do upgrade'owania centrum kultury
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCulturalCenter_Click(object sender, EventArgs e)
        {
            planet.buildingList[4].Upgrade(1,planet);
        }
        /// <summary>
        /// Przycisk do upgrade'owania gildii kupieckiej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMerchantsGuild_Click(object sender, EventArgs e)
        {
            planet.buildingList[5].Upgrade(1,planet);
        }
        /// <summary>
        /// Przycisk do upgrade'owania systemu ostrzegawczego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWarningSystem_Click(object sender, EventArgs e)
        {
            planet.buildingWarningSystem.Upgrade(1, planet);
            planet.buildingWarningSystem.UpgradeProtection(planet);
        }



        /// <summary>
        /// Inicjalizacja tekstów przycisków
        /// </summary>
        private void InitBuildingsButtons()
        {
            InitButton(buttonGoldMine, 0);
            InitButton(buttonTitanMine, 1);
            InitButton(buttonCrystalMine, 2);
            InitButton(buttonDronesFarms, 3);
            InitButton(buttonCulturalCenter, 4);
            InitButton(buttonMerchantsGuild, 5);

            if (!planet.buildingWarningSystem.maxLevel)
            {
                buttonWarningSystem.Text = planet.buildingWarningSystem.Name
                    + "\nPoziom: " + (planet.buildingWarningSystem.BuildingLevel + 1)
                    + "\nZłoto: " + planet.buildingWarningSystem.GoldCost
                    + "\nTytan: " + planet.buildingWarningSystem.TitanCost
                    + "\nKryształy: " + planet.buildingWarningSystem.CrystalCost;
                if (planet.Gold >= planet.buildingWarningSystem.GoldCost
                   && planet.Titan >= planet.buildingWarningSystem.TitanCost
                   && planet.Crystals >= planet.buildingWarningSystem.CrystalCost)
                {
                    buttonWarningSystem.Enabled = true;
                }
                else
                {
                    buttonWarningSystem.Enabled = false;
                }
            }
            else
            {
                buttonWarningSystem.Text = "Osiągnięto już maksymalny poziom!";
            }
            
        }
        /// <summary>
        /// Funkcja służąca do inicjalizacji tekstu pojedynczego przyciksu
        /// </summary>
        /// <param name="button"></param>
        /// <param name="listIndex"></param>
        private void InitButton(Button button,int listIndex)
        {
            if (!planet.buildingList[listIndex].maxLevel)
            {
                button.Text = planet.buildingList[listIndex].Name
                    + "\nPoziom: " + (planet.buildingList[listIndex].BuildingLevel + 1)
                    + "\nZłoto: " + planet.buildingList[listIndex].GoldCost
                    + "\nTytan: " + planet.buildingList[listIndex].TitanCost
                    + "\nKryształy: " + planet.buildingList[listIndex].CrystalCost;
                if (planet.Gold >= planet.buildingList[listIndex].GoldCost
                   && planet.Titan >= planet.buildingList[listIndex].TitanCost
                   && planet.Crystals >= planet.buildingList[listIndex].CrystalCost)
                {
                    button.Enabled = true;
                }
                else
                {
                    button.Enabled = false;
                }
            }
            else
            {
                button.Text = "Osiągnięto już maksymalny poziom!";
            }
        }
        /// <summary>
        /// Inicjalizacja tekstów etykiet budynków
        /// </summary>
        private void InitBuildingsLabels()
        {
            InitLabel(labelGoldMine, 0);
            InitLabel(labelTitanMine, 1);
            InitLabel(labelCrystalMine, 2);
            InitLabel(labelDronesFarms, 3);
            InitLabel(labelCulturalCenter, 4);
            InitLabel(labelMerchantsGuild, 5);

            if (!planet.buildingWarningSystem.maxLevel)
            {
                labelWarningSystem.Text = "Będzie dostarczać:"
                + "\nJedzenie:" + planet.buildingWarningSystem.GetNextFoodIncome()
                + "\nZłoto: " + planet.buildingWarningSystem.GetNextGoldIncome()
                + "\nTytan: " + planet.buildingWarningSystem.GetNextTitanIncome()
                + "\nKryształy: " + planet.buildingWarningSystem.GetNextCrystalIncome()
                + "\nZadowolenie: " + planet.buildingWarningSystem.GetNextPopularity().ToString("P", numberFormatInfo)
                + "\nOsłona: " + planet.buildingWarningSystem.GetNextProtectionLevel().ToString("P", numberFormatInfo);
            }
            else
            {
                labelWarningSystem.Text = "Dostarcza:"
                + "\nJedzenie:" + planet.buildingWarningSystem.FoodIncome
                + "\nZłoto: " + planet.buildingWarningSystem.GoldIncome
                + "\nTytan: " + planet.buildingWarningSystem.TitanIncome
                + "\nKryształy: " + planet.buildingWarningSystem.CrystalsIncome
                + "\nZadowolenie: " + planet.buildingWarningSystem.Popularity.ToString("P", numberFormatInfo)
                + "\nOsłona: " + planet.PlanetProtection.ToString("P", numberFormatInfo);
            }
        }
        /// <summary>
        /// Funkcja służąca do inicjalizacji tekstu pojedynczej etykiety
        /// </summary>
        /// <param name="label"></param>
        /// <param name="listIndex"></param>
        private void InitLabel(Label label, int listIndex)
        {
            if (!planet.buildingList[listIndex].maxLevel)
            {
                label.Text = "Będzie dostarczać:"
                + "\nJedzenie:" + planet.buildingList[listIndex].GetNextFoodIncome()
                + "\nZłoto: " + planet.buildingList[listIndex].GetNextGoldIncome()
                + "\nTytan: " + planet.buildingList[listIndex].GetNextTitanIncome()
                + "\nKryształy: " + planet.buildingList[listIndex].GetNextCrystalIncome()
                + "\nZadowolenie: " + planet.buildingList[listIndex].GetNextPopularity().ToString("P", numberFormatInfo);
            }
            else
            {
                label.Text = "Dostarcza:"
                + "\nJedzenie:" + planet.buildingList[listIndex].FoodIncome
                + "\nZłoto: " + planet.buildingList[listIndex].GoldIncome
                + "\nTytan: " + planet.buildingList[listIndex].TitanIncome
                + "\nKryształy: " + planet.buildingList[listIndex].CrystalsIncome
                + "\nZadowolenie: " + planet.buildingList[listIndex].Popularity.ToString("P", numberFormatInfo);
            }
        }
        /// <summary>
        /// Funkcja ładująca formę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBuildings_Load(object sender, EventArgs e)
        {
            numberFormatInfo.PercentDecimalDigits = 0;
            InitBuildingsButtons();
            InitBuildingsLabels();
            backgroundWorkerBuildings.RunWorkerAsync();
        }
        /// <summary>
        /// BackgroundWorker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerBuildings_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(100);
                backgroundWorkerBuildings.ReportProgress(0);
            }
            
        }
        /// <summary>
        /// BackgroundWorker zmiana progresu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerBuildings_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            InitBuildingsButtons();
            InitBuildingsLabels();
        }
        /// <summary>
        /// BackgroundWorker zakończony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerBuildings_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

    }
}
