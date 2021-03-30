
namespace MarcinWojczalBaseDefense
{
    partial class FormBattle
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
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.dataGridViewEnemy = new System.Windows.Forms.DataGridView();
            this.labelVS = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.AllowUserToAddRows = false;
            this.dataGridViewPlayer.AllowUserToDeleteRows = false;
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(10, 69);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.ReadOnly = true;
            this.dataGridViewPlayer.RowHeadersWidth = 51;
            this.dataGridViewPlayer.RowTemplate.Height = 24;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(502, 473);
            this.dataGridViewPlayer.TabIndex = 0;
            this.dataGridViewPlayer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPlayer_CellFormatting);
            // 
            // dataGridViewEnemy
            // 
            this.dataGridViewEnemy.AllowUserToAddRows = false;
            this.dataGridViewEnemy.AllowUserToDeleteRows = false;
            this.dataGridViewEnemy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnemy.Location = new System.Drawing.Point(645, 69);
            this.dataGridViewEnemy.Name = "dataGridViewEnemy";
            this.dataGridViewEnemy.ReadOnly = true;
            this.dataGridViewEnemy.RowHeadersWidth = 51;
            this.dataGridViewEnemy.RowTemplate.Height = 24;
            this.dataGridViewEnemy.Size = new System.Drawing.Size(504, 473);
            this.dataGridViewEnemy.TabIndex = 1;
            this.dataGridViewEnemy.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEnemy_CellFormatting);
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVS.Location = new System.Drawing.Point(552, 285);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(63, 39);
            this.labelVS.TabIndex = 2;
            this.labelVS.Text = "VS";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayer.Location = new System.Drawing.Point(207, 27);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(107, 39);
            this.labelPlayer.TabIndex = 3;
            this.labelPlayer.Text = "Gracz";
            // 
            // labelEnemy
            // 
            this.labelEnemy.AutoSize = true;
            this.labelEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnemy.Location = new System.Drawing.Point(819, 27);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(181, 39);
            this.labelEnemy.TabIndex = 4;
            this.labelEnemy.Text = "Przeciwnik";
            // 
            // timerBattle
            // 
            this.timerBattle.Enabled = true;
            this.timerBattle.Interval = 1000;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 571);
            this.Controls.Add(this.labelEnemy);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.dataGridViewEnemy);
            this.Controls.Add(this.dataGridViewPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBattle";
            this.Text = "Bitwa";
            this.Load += new System.EventHandler(this.formBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.DataGridView dataGridViewEnemy;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.Timer timerBattle;
    }
}