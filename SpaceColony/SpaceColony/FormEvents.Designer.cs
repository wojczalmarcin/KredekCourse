
namespace SpaceColony
{
    partial class FormEvents
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
            this.labelEventStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEventStatus
            // 
            this.labelEventStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelEventStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEventStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEventStatus.Location = new System.Drawing.Point(12, 79);
            this.labelEventStatus.Name = "labelEventStatus";
            this.labelEventStatus.Size = new System.Drawing.Size(759, 285);
            this.labelEventStatus.TabIndex = 0;
            this.labelEventStatus.Text = "labelEventStatus";
            this.labelEventStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceColony.Properties.Resources.wind;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEventStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEvents";
            this.Text = "Wydarzenie";
            this.Load += new System.EventHandler(this.FormEvents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEventStatus;
    }
}