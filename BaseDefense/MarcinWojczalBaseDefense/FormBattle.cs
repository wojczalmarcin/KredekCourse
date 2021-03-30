using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinWojczalBaseDefense
{
    partial class FormBattle : Form
    {
        // obiekt odwołujący się do głównego okna
        private FormMain formMain;
        // źródło tabeli armii gracza
        BindingSource playerArmySource = new BindingSource();
        // źródło tabeli armii przeciwnika
        BindingSource enemyArmySource = new BindingSource();
       /// <summary>
       /// Konstruktor
       /// </summary>
       /// <param name="formMain"></param>
        public FormBattle(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
        /// <summary>
        /// Funkcja ładująca Form'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formBattle_Load(object sender, EventArgs e)
        {
            formMain.PlayerArmy.RefreshUnitList();
            formMain.EnemyArmy.RefreshUnitList();
            playerArmySource.DataSource = formMain.PlayerArmy.UnitList;
            dataGridViewPlayer.DataSource = playerArmySource;
            enemyArmySource.DataSource = formMain.EnemyArmy.UnitList;
            dataGridViewEnemy.DataSource = enemyArmySource;
            InitDataGridView();
        }
        /// <summary>
        /// Funkcja inicjuąca tabele
        /// </summary>
        private void InitDataGridView()
        {
            dataGridViewPlayer.Columns["TotalCost"].Visible = false;
            dataGridViewPlayer.Columns["FirePowerLight"].Visible = false;
            dataGridViewPlayer.Columns["FirePowerHeavy"].Visible = false;
            dataGridViewPlayer.Columns["FirePowerAir"].Visible = false;
            dataGridViewPlayer.Columns["ArmorPenetration"].Visible = false;
            dataGridViewPlayer.Columns["BaseHealth"].Visible = false;
            dataGridViewPlayer.Columns["Name"].HeaderText = "Nazwa";
            dataGridViewPlayer.Columns["Health"].HeaderText = "Punkty Życia";
            dataGridViewPlayer.Columns["Target"].HeaderText = "Cel";

            dataGridViewEnemy.Columns["TotalCost"].Visible = false;
            dataGridViewEnemy.Columns["FirePowerLight"].Visible = false;
            dataGridViewEnemy.Columns["FirePowerHeavy"].Visible = false;
            dataGridViewEnemy.Columns["FirePowerAir"].Visible = false;
            dataGridViewEnemy.Columns["ArmorPenetration"].Visible = false;
            dataGridViewEnemy.Columns["BaseHealth"].Visible = false;
            dataGridViewEnemy.Columns["Name"].HeaderText = "Nazwa";
            dataGridViewEnemy.Columns["Health"].HeaderText = "Punkty Życia";
            dataGridViewEnemy.Columns["Target"].HeaderText = "Cel";
        }

        /// <summary>
        /// Funkcja odpowiedzialna za obsługę zdarzeń w czasie trwania zegara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBattle_Tick(object sender, EventArgs e)
        {
            playerArmySource.ResetBindings(false);
            enemyArmySource.ResetBindings(false);
            playerArmySource.DataSource = formMain.PlayerArmy.UnitList;
            enemyArmySource.DataSource = formMain.EnemyArmy.UnitList;
            if (!formMain.EnemyArmy.UnitList.Any() || !formMain.PlayerArmy.UnitList.Any())
                this.Close();
        }
        /// <summary>
        /// Formatuje tabelę armii gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewPlayer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPlayer.Columns[e.ColumnIndex].Name == "Target")
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
        /// Formatuje tabelę armii przeciwnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEnemy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewEnemy.Columns[e.ColumnIndex].Name == "Target")
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

    }
}
