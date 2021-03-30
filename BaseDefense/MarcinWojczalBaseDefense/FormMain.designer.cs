
namespace MarcinWojczalBaseDefense
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUnitList = new System.Windows.Forms.DataGridView();
            this.buttonInfantryList = new System.Windows.Forms.Button();
            this.buttonTankList = new System.Windows.Forms.Button();
            this.buttonPlaneList = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonShop = new System.Windows.Forms.Button();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelFirePower = new System.Windows.Forms.Label();
            this.labelStatistic = new System.Windows.Forms.Label();
            this.buttonShowBattle = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMission = new System.Windows.Forms.Label();
            this.buttonRepair = new System.Windows.Forms.Button();
            this.labelRepairCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnitList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUnitList
            // 
            this.dataGridViewUnitList.AllowUserToAddRows = false;
            this.dataGridViewUnitList.AllowUserToDeleteRows = false;
            this.dataGridViewUnitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnitList.Location = new System.Drawing.Point(568, 11);
            this.dataGridViewUnitList.Name = "dataGridViewUnitList";
            this.dataGridViewUnitList.ReadOnly = true;
            this.dataGridViewUnitList.RowHeadersWidth = 51;
            this.dataGridViewUnitList.RowTemplate.Height = 24;
            this.dataGridViewUnitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnitList.Size = new System.Drawing.Size(606, 355);
            this.dataGridViewUnitList.TabIndex = 0;
            this.dataGridViewUnitList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnitList_CellContentClick);
            this.dataGridViewUnitList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUnitList_CellFormatting);
            // 
            // buttonInfantryList
            // 
            this.buttonInfantryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonInfantryList.Location = new System.Drawing.Point(395, 11);
            this.buttonInfantryList.Name = "buttonInfantryList";
            this.buttonInfantryList.Size = new System.Drawing.Size(148, 52);
            this.buttonInfantryList.TabIndex = 2;
            this.buttonInfantryList.Text = "Piechota";
            this.buttonInfantryList.UseVisualStyleBackColor = true;
            this.buttonInfantryList.Click += new System.EventHandler(this.buttonInfantryList_Click);
            // 
            // buttonTankList
            // 
            this.buttonTankList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTankList.Location = new System.Drawing.Point(395, 88);
            this.buttonTankList.Name = "buttonTankList";
            this.buttonTankList.Size = new System.Drawing.Size(148, 52);
            this.buttonTankList.TabIndex = 3;
            this.buttonTankList.Text = "Czołgi";
            this.buttonTankList.UseVisualStyleBackColor = true;
            this.buttonTankList.Click += new System.EventHandler(this.buttonTankList_Click);
            // 
            // buttonPlaneList
            // 
            this.buttonPlaneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlaneList.Location = new System.Drawing.Point(395, 165);
            this.buttonPlaneList.Name = "buttonPlaneList";
            this.buttonPlaneList.Size = new System.Drawing.Size(148, 52);
            this.buttonPlaneList.TabIndex = 4;
            this.buttonPlaneList.Text = "Samoloty";
            this.buttonPlaneList.UseVisualStyleBackColor = true;
            this.buttonPlaneList.Click += new System.EventHandler(this.buttonPlaneList_Click);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 2000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(1032, 526);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(142, 32);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Dzień: 0";
            // 
            // buttonShop
            // 
            this.buttonShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShop.Location = new System.Drawing.Point(12, 12);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(345, 205);
            this.buttonShop.TabIndex = 6;
            this.buttonShop.Text = "Sklep";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // labelGold
            // 
            this.labelGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGold.Location = new System.Drawing.Point(12, 241);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(345, 39);
            this.labelGold.TabIndex = 7;
            this.labelGold.Text = "Złoto: 0";
            // 
            // labelFirePower
            // 
            this.labelFirePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirePower.Location = new System.Drawing.Point(772, 392);
            this.labelFirePower.Name = "labelFirePower";
            this.labelFirePower.Size = new System.Drawing.Size(159, 91);
            this.labelFirePower.TabIndex = 8;
            this.labelFirePower.Text = "Obrażenia:\r\nLekkie: 0\r\nCiężkie: 0\r\nPowietrzne: 0";
            // 
            // labelStatistic
            // 
            this.labelStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatistic.Location = new System.Drawing.Point(926, 392);
            this.labelStatistic.Name = "labelStatistic";
            this.labelStatistic.Size = new System.Drawing.Size(246, 91);
            this.labelStatistic.TabIndex = 9;
            this.labelStatistic.Text = "\r\nPenetracja pancerza: 0\r\nPancerz: 0\r\nManewrowość: 0";
            // 
            // buttonShowBattle
            // 
            this.buttonShowBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShowBattle.Location = new System.Drawing.Point(395, 229);
            this.buttonShowBattle.Name = "buttonShowBattle";
            this.buttonShowBattle.Size = new System.Drawing.Size(148, 52);
            this.buttonShowBattle.TabIndex = 10;
            this.buttonShowBattle.Text = "Podgląd bitwy";
            this.buttonShowBattle.UseVisualStyleBackColor = true;
            this.buttonShowBattle.Click += new System.EventHandler(this.buttonShowBattle_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.ForeColor = System.Drawing.Color.DarkRed;
            this.labelScore.Location = new System.Drawing.Point(256, 143);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(740, 189);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Porażka!";
            // 
            // labelMission
            // 
            this.labelMission.AutoSize = true;
            this.labelMission.BackColor = System.Drawing.Color.Transparent;
            this.labelMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMission.Location = new System.Drawing.Point(12, 290);
            this.labelMission.Name = "labelMission";
            this.labelMission.Size = new System.Drawing.Size(208, 58);
            this.labelMission.TabIndex = 12;
            this.labelMission.Text = "Misja:\r\nPrzetrwaj 300 dni";
            // 
            // buttonRepair
            // 
            this.buttonRepair.Enabled = false;
            this.buttonRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRepair.Location = new System.Drawing.Point(568, 392);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(198, 32);
            this.buttonRepair.TabIndex = 13;
            this.buttonRepair.Text = "Napraw";
            this.buttonRepair.UseVisualStyleBackColor = true;
            this.buttonRepair.Click += new System.EventHandler(this.buttonRepair_Click);
            // 
            // labelRepairCost
            // 
            this.labelRepairCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRepairCost.Location = new System.Drawing.Point(568, 427);
            this.labelRepairCost.Name = "labelRepairCost";
            this.labelRepairCost.Size = new System.Drawing.Size(198, 23);
            this.labelRepairCost.TabIndex = 14;
            this.labelRepairCost.Text = "Koszt naprawy: 0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MarcinWojczalBaseDefense.Properties.Resources._base;
            this.ClientSize = new System.Drawing.Size(1178, 567);
            this.Controls.Add(this.labelRepairCost);
            this.Controls.Add(this.buttonRepair);
            this.Controls.Add(this.labelMission);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonShowBattle);
            this.Controls.Add(this.labelStatistic);
            this.Controls.Add(this.labelFirePower);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonPlaneList);
            this.Controls.Add(this.buttonTankList);
            this.Controls.Add(this.buttonInfantryList);
            this.Controls.Add(this.dataGridViewUnitList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Obrona wioski";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnitList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUnitList;
        private System.Windows.Forms.Button buttonInfantryList;
        private System.Windows.Forms.Button buttonTankList;
        private System.Windows.Forms.Button buttonPlaneList;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelFirePower;
        private System.Windows.Forms.Label labelStatistic;
        private System.Windows.Forms.Button buttonShowBattle;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMission;
        private System.Windows.Forms.Button buttonRepair;
        private System.Windows.Forms.Label labelRepairCost;
    }
}

