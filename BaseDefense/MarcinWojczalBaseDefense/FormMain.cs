using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MarcinWojczalBaseDefense
{
    partial class FormMain : Form
    {
        // Armia należąca do gracza
        public Army PlayerArmy { get; set; } = new Army();
        // Armia przeciwnika
        public Army EnemyArmy { get; set; }
        // Fabryka jednostek
        UnitFactory unitFactory = new UnitFactory();
        // Licznik czasu
        double timeCounter = 0;
        // Instancja losowości
        Random random = new Random();
        // Złoto należące do gracza
        public int Gold { get; set; }
        // Zmienna określająca czy bitwa trwa
        public bool IsBattle { get; set; } = false;

        // Zmienna odliczająca przerwę między losowaniem bitwy
        private int battleBreakCount = 10;

        // lista wyświetlana w dataGridView
        public BindingSource ListSource { get; set; } = new BindingSource();
        // typ listy który jest aktualnie wyświetlany
        private int listType = 0;
        // zmienna przechowująca koszt naprawy jednostki
        private int repairCost = 0;
        //zaznaczona jednostka
        Unit currentUnit;


        /// <summary>
        /// Konstruktor głównego okna aplikacji
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            Gold = 100;
            labelGold.Text = "Złoto: " + Gold;
            buttonShowBattle.Enabled = false;
            //temp
            for (int i = 0; i < 5; i++)
            {
                PlayerArmy.TankList.Add(unitFactory.CreateTank.RandomTank());
                PlayerArmy.PlaneList.Add(unitFactory.CreatePlane.RandomPlane());
            }
            for (int i = 0; i < 10; i++)
            {
                PlayerArmy.InfantryList.Add(unitFactory.CreateInfantry.RandomInfantry());
            }
            PlayerArmy.Sort();
            labelScore.Visible = false;
        }
        /// <summary>
        /// Przycisk odpowiedzialny za wyświetlenie listy jednostek piechoty gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfantryList_Click(object sender, EventArgs e)
        {
            ListSource.DataSource = PlayerArmy.InfantryList;
            dataGridViewUnitList.DataSource = ListSource;
            listType = 0;
        }
        /// <summary>
        /// Przycisk odpowiedzialny za wyświetlenie listy czołgów gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTankList_Click(object sender, EventArgs e)
        {
            ListSource.DataSource = PlayerArmy.TankList;
            dataGridViewUnitList.DataSource = ListSource;
            listType = 1;
            try
            {
                dataGridViewUnitList.Columns["Armor"].HeaderText = "Pancerz";
            }
            catch
            {

            }
        }
        /// <summary>
        /// Przycisk odpowiedzialny za wyświetlenie listy samolotów gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlaneList_Click(object sender, EventArgs e)
        {
            ListSource.DataSource = PlayerArmy.PlaneList;
            dataGridViewUnitList.DataSource = ListSource;
            listType = 2;
            try
            {
                dataGridViewUnitList.Columns["Maneuverability"].HeaderText = "Manewrowość";
            }
            catch
            {

            }
        }
        /// <summary>
        /// Funkcja ładująca Form'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            labelTime.BackColor = System.Drawing.Color.Transparent;
            labelGold.BackColor = System.Drawing.Color.Transparent;
            ListSource.DataSource = PlayerArmy.InfantryList;
            dataGridViewUnitList.DataSource = ListSource;
            InitDataGridView();
        }
        /// <summary>
        /// Funkcja inicjująca tabelę jednostek
        /// </summary>
        private void InitDataGridView()
        {
            dataGridViewUnitList.Columns["TotalCost"].Visible = false;
            dataGridViewUnitList.Columns["FirePowerLight"].Visible = false;
            dataGridViewUnitList.Columns["FirePowerHeavy"].Visible = false;
            dataGridViewUnitList.Columns["FirePowerAir"].Visible = false;
            dataGridViewUnitList.Columns["ArmorPenetration"].Visible = false;
            dataGridViewUnitList.Columns["BaseHealth"].Visible = false;
            dataGridViewUnitList.Columns["Name"].HeaderText = "Nazwa";
            dataGridViewUnitList.Columns["Health"].HeaderText = "Punkty Życia";
            dataGridViewUnitList.Columns["Target"].HeaderText = "Cel";
        }
        /// <summary>
        /// Funkcja formatująca tabelę jednostek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUnitList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewUnitList.Columns[e.ColumnIndex].Name == "Target")
            {
                ETarget enumValue = (ETarget)e.Value;
                if (enumValue == ETarget.Infantry)
                    e.Value = "Piechota";
                else if (enumValue == ETarget.Tank)
                    e.Value = "Czołg";
                else if (enumValue == ETarget.Plane)
                    e.Value = "Samolot";
            }
        }
        /// <summary>
        /// Funkcja obsługująca kliknięcie komórki tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUnitList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(listType == 0)
            {
                var selectedUnit = dataGridViewUnitList.SelectedRows[0].DataBoundItem as Infantry;
                labelFirePower.Text = "Obrażenia:\nLekkie: " + selectedUnit.FirePowerLight +
                    "\nCiężkie: " + selectedUnit.FirePowerHeavy +
                    "\nPowietrzne : " + selectedUnit.FirePowerAir;
                labelStatistic.Text = "\nPenetracja pancerza: " + selectedUnit.ArmorPenetration +
                    "\nPancerz: 0\nManewrowość: 0";
                repairCost = (int)(selectedUnit.TotalCost / 100.0 * (selectedUnit.BaseHealth - selectedUnit.Health));
                labelRepairCost.Text = "Koszt naprawy: " + repairCost;
                if (Gold >= repairCost && repairCost != 0 && !IsBattle)
                    buttonRepair.Enabled = true;
                else
                    buttonRepair.Enabled = false;
                currentUnit = selectedUnit;
            }
            else if(listType == 1)
            {
                var selectedUnit = dataGridViewUnitList.SelectedRows[0].DataBoundItem as Tank;
                labelFirePower.Text = "Obrażenia:\nLekkie: " + selectedUnit.FirePowerLight +
                    "\nCiężkie: " + selectedUnit.FirePowerHeavy +
                    "\nPowietrzne : " + selectedUnit.FirePowerAir;
                labelStatistic.Text = "\nPenetracja pancerza: " + selectedUnit.ArmorPenetration +
                    "\nPancerz: " + selectedUnit.Armor + "\nManewrowość: 0";
                repairCost = (int)(selectedUnit.TotalCost / 200.0 * (selectedUnit.BaseHealth - selectedUnit.Health));
                labelRepairCost.Text = "Koszt naprawy: " + repairCost;
                if (Gold >= repairCost && repairCost != 0 && !IsBattle)
                    buttonRepair.Enabled = true;
                else
                    buttonRepair.Enabled = false;
                currentUnit = selectedUnit;
            }
            else
            {
                var selectedUnit = dataGridViewUnitList.SelectedRows[0].DataBoundItem as Plane;
                labelFirePower.Text = "Obrażenia:\nLekkie: " + selectedUnit.FirePowerLight +
                    "\nCiężkie: " + selectedUnit.FirePowerHeavy +
                    "\nPowietrzne : " + selectedUnit.FirePowerAir;
                labelStatistic.Text = "\nPenetracja pancerza: " + selectedUnit.ArmorPenetration +
                    "\nPancerz: 0" + "\nManewrowość: " + selectedUnit.Maneuverability;
                repairCost = (int)(selectedUnit.TotalCost / 250.0 * (selectedUnit.BaseHealth - selectedUnit.Health));
                labelRepairCost.Text = "Koszt naprawy: " + repairCost;
                if (Gold >= repairCost && repairCost != 0 && !IsBattle)
                    buttonRepair.Enabled = true;
                else
                    buttonRepair.Enabled = false;
                currentUnit = selectedUnit;
            }
        }
        /// <summary>
        /// Funkcja obsługująca zdarzenia trwające co interwał czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            timeCounter++;
            labelTime.Text = "Dzień: " + timeCounter;
            Gold += 5;
            if (Gold >= repairCost && repairCost != 0 && !IsBattle)
                buttonRepair.Enabled = true;
            else
                buttonRepair.Enabled = false;
            if (IsBattle)
            {
                buttonShop.Enabled = false;
                PlayerArmy.Attack(EnemyArmy,random);
                EnemyArmy.Attack(PlayerArmy,random);
                buttonShowBattle.Enabled = true;
                EnemyArmy.RefreshUnitList();
                PlayerArmy.RefreshUnitList();
                ListSource.ResetBindings(false);
            }
            else
            {
                buttonShop.Enabled = true;
                buttonShowBattle.Enabled = false;
                if (battleBreakCount > 0)
                    battleBreakCount--;
            }
            if (random.Next(2) == 1 && !IsBattle && battleBreakCount==0)
            {
                EnemyArmy = new Army(timeCounter/9);
                FormBattle formBattle = new FormBattle(this);
                formBattle.Show();
                IsBattle = true;
                battleBreakCount = 25;
                Gold += EnemyArmy.GetTotalArmyCost()/3;
            }
            if(EnemyArmy != null)
            {
                if (!EnemyArmy.UnitList.Any()) 
                    IsBattle = false;

                if (!PlayerArmy.UnitList.Any())
                {
                    MessageBox.Show("PORAŻKA");
                    EndGame();

                }
                   
            }
            labelGold.Text = "Złoto: " + Gold;
            if (timeCounter == 300)
            {
                labelScore.Text = "Wygrana!";
                labelScore.ForeColor = Color.Khaki;
                labelScore.Visible = true;
                EndGame();
            }
        }
        /// <summary>
        /// Funkcja obsługująca zdarzenie na koniec rozgrywki
        /// </summary>
        private void EndGame()
        {
            timerMain.Stop();
            buttonShop.Enabled = false;
            buttonInfantryList.Enabled = false;
            buttonTankList.Enabled = false;
            buttonPlaneList.Enabled = false;
            buttonShowBattle.Enabled = false;
            buttonInfantryList.Visible = false;
            buttonTankList.Visible = false;
            buttonPlaneList.Visible = false;
            buttonShowBattle.Visible = false;
            dataGridViewUnitList.Visible = false;
            labelStatistic.Visible = false;
            labelFirePower.Visible = false;
            buttonShop.Visible = false;
            labelMission.Visible = false;
            labelGold.Visible = false;
            labelRepairCost.Visible = false;
            buttonRepair.Visible = false;
            buttonRepair.Enabled = false;
            labelScore.Visible = true;
        }
        /// <summary>
        /// Przycisk wyświetlający sklep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShop_Click(object sender, EventArgs e)
        {
            FormShop formShop = new FormShop(PlayerArmy, this);
            formShop.Show();
        }
        /// <summary>
        /// Przycisk wyśiwetlający szczegóły bitwy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowBattle_Click(object sender, EventArgs e)
        {
            FormBattle formBattle = new FormBattle(this);
            formBattle.Show();
        }
        /// <summary>
        /// Przycisk naprawiający jednostkę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRepair_Click(object sender, EventArgs e)
        {
            currentUnit.Health = currentUnit.BaseHealth;
            buttonRepair.Enabled = false;
            labelRepairCost.Text = "Koszt naprawy: 0";
            ListSource.ResetBindings(false);
            repairCost = 0;

        }
    }
}
