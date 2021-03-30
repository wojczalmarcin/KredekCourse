using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinWojczalBaseDefense
{
    partial class FormShop : Form
    {
        // Instancja armii gracza
        Army playerArmy;
        // Instancja głównego okna
        FormMain formMain;
        // Fabryka jednostek
        UnitFactory unitFactory = new UnitFactory();

        // Obiekty wszystkich jednostek potrzebne do pobrania ich właściwości
        Infantry lightInfantry,commandos, heavyInfantry,aAInfantry,aTInfantry;
        Tank lightTank, mediumTank, heavyTank, mBTank, tankDestroyer;
        Plane fighter, lightBomber, heavyBomber, multipurpose;
       /// <summary>
       /// Konstrukor
       /// </summary>
       /// <param name="playerArmy"></param>
       /// <param name="formMain"></param>
        public FormShop(Army playerArmy,FormMain formMain)
        {
            InitializeComponent();
            this.playerArmy = playerArmy;
            this.formMain = formMain;
            lightInfantry = unitFactory.CreateInfantry.LightInfantry();
            commandos = unitFactory.CreateInfantry.Commandos();
            heavyInfantry = unitFactory.CreateInfantry.HeavyInfantry();
            aAInfantry = unitFactory.CreateInfantry.AAInfantry();
            aTInfantry = unitFactory.CreateInfantry.ATInfantry();

            lightTank = unitFactory.CreateTank.LightTank();
            mediumTank = unitFactory.CreateTank.MediumTank();
            heavyTank = unitFactory.CreateTank.HeavyTank();
            mBTank = unitFactory.CreateTank.MBTank();
            tankDestroyer = unitFactory.CreateTank.TankDestroyer();

            fighter = unitFactory.CreatePlane.Fighter();
            lightBomber = unitFactory.CreatePlane.LightBomber();
            heavyBomber = unitFactory.CreatePlane.HeavyBomber();
            multipurpose = unitFactory.CreatePlane.MultiPurpose();

           
        }
        /// <summary>
        /// Funkcja ładująca Form'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormShop_Load(object sender, EventArgs e)
        {
            InitButtons();
            ButtonsEnabler();
        }
        /// <summary>
        /// Przycisk dodający jednostkę lekkiej piechoty do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLightInfantry_Click(object sender, EventArgs e)
        {
            formMain.Gold -= lightInfantry.TotalCost;
            playerArmy.InfantryList.Add(unitFactory.CreateInfantry.LightInfantry());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający jednostkę komandosów do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCommandos_Click(object sender, EventArgs e)
        {
            formMain.Gold -= commandos.TotalCost;
            playerArmy.InfantryList.Add(unitFactory.CreateInfantry.Commandos());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający jednostkę ciężkiej piechoty do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHeavyInfantry_Click(object sender, EventArgs e)
        {
            formMain.Gold -= heavyInfantry.TotalCost;
            playerArmy.InfantryList.Add(unitFactory.CreateInfantry.HeavyInfantry());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający jednostkę piechoty przeciwlotniczej do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAAInfantry_Click(object sender, EventArgs e)
        {
            formMain.Gold -= aAInfantry.TotalCost;
            playerArmy.InfantryList.Add(unitFactory.CreateInfantry.AAInfantry());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający jednostkę piechoty przeciwpancernej do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonATInfantry_Click(object sender, EventArgs e)
        {
            formMain.Gold -= aTInfantry.TotalCost;
            playerArmy.InfantryList.Add(unitFactory.CreateInfantry.ATInfantry());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający czołg lekki do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLightTank_Click(object sender, EventArgs e)
        {
            formMain.Gold -= lightTank.TotalCost;
            playerArmy.TankList.Add(unitFactory.CreateTank.LightTank());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający czołg średni do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMediumTank_Click(object sender, EventArgs e)
        {
            formMain.Gold -= mediumTank.TotalCost;
            playerArmy.TankList.Add(unitFactory.CreateTank.MediumTank());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający czołg ciężki do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHeavyTank_Click(object sender, EventArgs e)
        {
            formMain.Gold -= heavyTank.TotalCost;
            playerArmy.TankList.Add(unitFactory.CreateTank.HeavyTank());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający czołg podstawowy do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMBTank_Click(object sender, EventArgs e)
        {
            formMain.Gold -= mBTank.TotalCost;
            playerArmy.TankList.Add(unitFactory.CreateTank.MBTank());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający niszczyciel czołgów do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTankDestroyer_Click(object sender, EventArgs e)
        {
            formMain.Gold -= tankDestroyer.TotalCost;
            playerArmy.TankList.Add(unitFactory.CreateTank.TankDestroyer());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający myśliwiec do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFighter_Click(object sender, EventArgs e)
        {
            formMain.Gold -= fighter.TotalCost;
            playerArmy.PlaneList.Add(unitFactory.CreatePlane.Fighter());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający lekki bombowiec do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLightBomber_Click(object sender, EventArgs e)
        {
            formMain.Gold -= lightBomber.TotalCost;
            playerArmy.PlaneList.Add(unitFactory.CreatePlane.LightBomber());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający ciężki bombowiec do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHeavyBomber_Click(object sender, EventArgs e)
        {
            formMain.Gold -= heavyBomber.TotalCost;
            playerArmy.PlaneList.Add(unitFactory.CreatePlane.HeavyBomber());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Przycisk dodający samolot wielozadaniowy do armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultipurpose_Click(object sender, EventArgs e)
        {
            formMain.Gold -= multipurpose.TotalCost;
            playerArmy.PlaneList.Add(unitFactory.CreatePlane.MultiPurpose());
            ButtonsEnabler();
            formMain.ListSource.ResetBindings(false);
            formMain.PlayerArmy.Sort();
        }
        /// <summary>
        /// Funkcja obsługująca zdarzenia trwające co interwał czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBattle_Tick(object sender, EventArgs e)
        {
            labelGold.Text = "Złoto: " + formMain.Gold;
            if (formMain.IsBattle)
            {
                this.Close();
            }
            ButtonsEnabler();
        }
        /// <summary>
        /// Funkcja decydująca o włączonych przyciskach w zależności od ilości złota
        /// </summary>
        private void ButtonsEnabler()
        {
            if (formMain.Gold < lightInfantry.TotalCost) buttonLightInfantry.Enabled = false;
            else buttonLightInfantry.Enabled = true;
            if (formMain.Gold < heavyInfantry.TotalCost) buttonHeavyInfantry.Enabled = false;
            else buttonHeavyInfantry.Enabled = true;
            if (formMain.Gold < commandos.TotalCost) buttonCommandos.Enabled = false;
            else buttonCommandos.Enabled = true;
            if (formMain.Gold < aAInfantry.TotalCost) buttonAAInfantry.Enabled = false;
            else buttonAAInfantry.Enabled = true;
            if (formMain.Gold < aTInfantry.TotalCost) buttonATInfantry.Enabled = false;
            else buttonATInfantry.Enabled = true;

            if (formMain.Gold < lightTank.TotalCost) buttonLightTank.Enabled = false;
            else buttonLightTank.Enabled = true;
            if (formMain.Gold < heavyTank.TotalCost) buttonHeavyTank.Enabled = false;
            else buttonHeavyTank.Enabled = true;
            if (formMain.Gold < mediumTank.TotalCost) buttonMediumTank.Enabled = false;
            else buttonMediumTank.Enabled = true;
            if (formMain.Gold < mBTank.TotalCost) buttonMBTank.Enabled = false;
            else buttonMBTank.Enabled = true;
            if (formMain.Gold < tankDestroyer.TotalCost) buttonTankDestroyer.Enabled = false;
            else buttonTankDestroyer.Enabled = true;

            if (formMain.Gold < fighter.TotalCost) buttonFighter.Enabled = false;
            else buttonFighter.Enabled = true;
            if (formMain.Gold < lightBomber.TotalCost) buttonLightBomber.Enabled = false;
            else buttonLightBomber.Enabled = true;
            if (formMain.Gold < heavyBomber.TotalCost) buttonHeavyBomber.Enabled = false;
            else buttonHeavyBomber.Enabled = true;
            if (formMain.Gold < multipurpose.TotalCost) buttonMultipurpose.Enabled = false;
            else buttonMultipurpose.Enabled = true;
        }
        /// <summary>
        /// Funkcja inicjująca tekst wszystkich przycisków
        /// </summary>
        private void InitButtons()
        {
            InitButtonTextInfantry(buttonLightInfantry, lightInfantry);
            InitButtonTextInfantry(buttonHeavyInfantry, heavyInfantry);
            InitButtonTextInfantry(buttonCommandos, commandos);
            InitButtonTextInfantry(buttonAAInfantry, aAInfantry);
            InitButtonTextInfantry(buttonATInfantry, aTInfantry);

            InitButtonTextTanks(buttonLightTank, lightTank);
            InitButtonTextTanks(buttonMediumTank, mediumTank);
            InitButtonTextTanks(buttonHeavyTank, heavyTank);
            InitButtonTextTanks(buttonMBTank, mBTank);
            InitButtonTextTanks(buttonTankDestroyer, tankDestroyer);

            InitButtonTextPlanes(buttonFighter, fighter);
            InitButtonTextPlanes(buttonLightBomber, lightBomber);
            InitButtonTextPlanes(buttonHeavyBomber, heavyBomber);
            InitButtonTextPlanes(buttonMultipurpose, multipurpose);
        }
        /// <summary>
        /// Funkcja inicjująca tekst przycisku kupna piechoty
        /// </summary>
        /// <param name="button"></param>
        /// <param name="infantry"></param>
        private void InitButtonTextInfantry(Button button, Infantry infantry)
        {
            button.Text = "Cena: " + infantry.TotalCost +
                "\nZdrowie: " + infantry.Health +
                "\nPenetracja pancerza: " + infantry.ArmorPenetration +
                "\nZadawane obrażenia:\nCele lekkie: " + infantry.FirePowerLight +
                "\nCele ciężkie: " + infantry.FirePowerHeavy +
                "\nCele powietrzne: " + infantry.FirePowerAir;
        }
        /// <summary>
        /// Funkcja inicjująca tekst przycisku kupna czołgu
        /// </summary>
        /// <param name="button"></param>
        /// <param name="tank"></param>
        private void InitButtonTextTanks(Button button, Tank tank)
        {
            button.Text = "Cena: " + tank.TotalCost +
                "\nZdrowie: " + tank.Health +
                "\nPenetracja pancerza: " + tank.ArmorPenetration +
                "\nPancerz: " + tank.Armor + 
                "\nZadawane obrażenia:\nCele lekkie: " + tank.FirePowerLight +
                "\nCele ciężkie: " + tank.FirePowerHeavy +
                "\nCele powietrzne: " + tank.FirePowerAir;
        }
        /// <summary>
        /// Funkcja inicjująca tekst przycisku kupna samolotu
        /// </summary>
        /// <param name="button"></param>
        /// <param name="plane"></param>
        private void InitButtonTextPlanes(Button button, Plane plane)
        {
            button.Text = "Cena: " + plane.TotalCost +
                "\nZdrowie: " + plane.Health +
                "\nPenetracja pancerza: " + plane.ArmorPenetration +
                "\nManewrowość: " + plane.Maneuverability +
                "\nZadawane obrażenia:\nCele lekkie: " + plane.FirePowerLight +
                "\nCele ciężkie: " + plane.FirePowerHeavy +
                "\nCele powietrzne: " + plane.FirePowerAir;
        }
    }
}
