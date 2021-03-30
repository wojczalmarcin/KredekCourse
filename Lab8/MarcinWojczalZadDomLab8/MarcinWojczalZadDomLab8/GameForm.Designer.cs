
namespace MarcinWojczalZadDomLab8
{
    partial class GameForm
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
            this.gameTickTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxGraphics = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTickTimer
            // 
            this.gameTickTimer.Enabled = true;
            this.gameTickTimer.Interval = 1;
            this.gameTickTimer.Tick += new System.EventHandler(this.gameTickTimer_Tick);
            // 
            // pictureBoxGraphics
            // 
            this.pictureBoxGraphics.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGraphics.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxGraphics.Name = "pictureBoxGraphics";
            this.pictureBoxGraphics.Size = new System.Drawing.Size(512, 800);
            this.pictureBoxGraphics.TabIndex = 0;
            this.pictureBoxGraphics.TabStop = false;
            this.pictureBoxGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGraphics_Paint);
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.ForeColor = System.Drawing.Color.Black;
            this.labelScore.Location = new System.Drawing.Point(-3, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(70, 38);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Wynik:\r\n0";
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(512, 753);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxGraphics);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "Wymijanie samochodów";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTickTimer;
        private System.Windows.Forms.PictureBox pictureBoxGraphics;
        private System.Windows.Forms.Label labelScore;
    }
}

