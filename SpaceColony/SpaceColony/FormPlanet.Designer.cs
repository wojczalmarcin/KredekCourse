
namespace SpaceColony
{
    partial class FormPlanet
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
            this.labelPop = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelCrystals = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTitan = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.trackBarTaxes = new System.Windows.Forms.TrackBar();
            this.labelTaxes = new System.Windows.Forms.Label();
            this.labelPopularity = new System.Windows.Forms.Label();
            this.buttonBuildings = new System.Windows.Forms.Button();
            this.labelProtection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTaxes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPop
            // 
            this.labelPop.AllowDrop = true;
            this.labelPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPop.Location = new System.Drawing.Point(19, 3);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(175, 41);
            this.labelPop.TabIndex = 0;
            this.labelPop.Text = "Populacja: 0\r\n0\\Miesiąc";
            this.labelPop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGold
            // 
            this.labelGold.AllowDrop = true;
            this.labelGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGold.Location = new System.Drawing.Point(211, 3);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(175, 41);
            this.labelGold.TabIndex = 1;
            this.labelGold.Text = " Złoto: 0\r\n0/Miesiąc";
            this.labelGold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCrystals
            // 
            this.labelCrystals.AllowDrop = true;
            this.labelCrystals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCrystals.Location = new System.Drawing.Point(402, 3);
            this.labelCrystals.Name = "labelCrystals";
            this.labelCrystals.Size = new System.Drawing.Size(175, 41);
            this.labelCrystals.TabIndex = 2;
            this.labelCrystals.Text = "Kryształy: 0\r\n0\\Miesiąc";
            this.labelCrystals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 2000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AllowDrop = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(987, 3);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(184, 26);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Miesiąc: 0";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitan
            // 
            this.labelTitan.AllowDrop = true;
            this.labelTitan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitan.Location = new System.Drawing.Point(593, 3);
            this.labelTitan.Name = "labelTitan";
            this.labelTitan.Size = new System.Drawing.Size(175, 41);
            this.labelTitan.TabIndex = 4;
            this.labelTitan.Text = "Tytan: 0\r\n0\\Miesiąc";
            this.labelTitan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFood
            // 
            this.labelFood.AllowDrop = true;
            this.labelFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFood.Location = new System.Drawing.Point(784, 3);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(175, 41);
            this.labelFood.TabIndex = 5;
            this.labelFood.Text = "Jedzenie: 0\r\n0\\Miesiąc";
            this.labelFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBarTaxes
            // 
            this.trackBarTaxes.AutoSize = false;
            this.trackBarTaxes.Location = new System.Drawing.Point(1016, 145);
            this.trackBarTaxes.Name = "trackBarTaxes";
            this.trackBarTaxes.Size = new System.Drawing.Size(155, 36);
            this.trackBarTaxes.TabIndex = 7;
            this.trackBarTaxes.Scroll += new System.EventHandler(this.trackBarTaxes_Scroll);
            // 
            // labelTaxes
            // 
            this.labelTaxes.AllowDrop = true;
            this.labelTaxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTaxes.Location = new System.Drawing.Point(1016, 116);
            this.labelTaxes.Name = "labelTaxes";
            this.labelTaxes.Size = new System.Drawing.Size(155, 26);
            this.labelTaxes.TabIndex = 8;
            this.labelTaxes.Text = "Podatki: 0%";
            this.labelTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPopularity
            // 
            this.labelPopularity.AllowDrop = true;
            this.labelPopularity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPopularity.Location = new System.Drawing.Point(988, 38);
            this.labelPopularity.Name = "labelPopularity";
            this.labelPopularity.Size = new System.Drawing.Size(183, 26);
            this.labelPopularity.TabIndex = 9;
            this.labelPopularity.Text = "Zadowolenie: 0%";
            this.labelPopularity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBuildings
            // 
            this.buttonBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuildings.Location = new System.Drawing.Point(1015, 519);
            this.buttonBuildings.Name = "buttonBuildings";
            this.buttonBuildings.Size = new System.Drawing.Size(155, 62);
            this.buttonBuildings.TabIndex = 10;
            this.buttonBuildings.Text = "Budynki";
            this.buttonBuildings.UseVisualStyleBackColor = true;
            this.buttonBuildings.Click += new System.EventHandler(this.buttonBuildings_Click);
            // 
            // labelProtection
            // 
            this.labelProtection.AllowDrop = true;
            this.labelProtection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProtection.Location = new System.Drawing.Point(987, 77);
            this.labelProtection.Name = "labelProtection";
            this.labelProtection.Size = new System.Drawing.Size(183, 26);
            this.labelProtection.TabIndex = 11;
            this.labelProtection.Text = "Osłona: 0%";
            this.labelProtection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceColony.Properties.Resources.Planet;
            this.ClientSize = new System.Drawing.Size(1182, 593);
            this.Controls.Add(this.labelProtection);
            this.Controls.Add(this.buttonBuildings);
            this.Controls.Add(this.labelPopularity);
            this.Controls.Add(this.labelTaxes);
            this.Controls.Add(this.trackBarTaxes);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelTitan);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCrystals);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelPop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPlanet";
            this.Text = "Twoja planeta";
            this.Load += new System.EventHandler(this.FormPlanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTaxes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPop;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelCrystals;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTitan;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.TrackBar trackBarTaxes;
        private System.Windows.Forms.Label labelTaxes;
        private System.Windows.Forms.Label labelPopularity;
        private System.Windows.Forms.Button buttonBuildings;
        private System.Windows.Forms.Label labelProtection;
    }
}

