
namespace MarcinWojczalUniversityFaculty.Forms
{
    partial class FormUpdateAddress
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.labePostCode = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(22, 265);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(359, 34);
            this.buttonUpdate.TabIndex = 53;
            this.buttonUpdate.Text = "Aktualizuj";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(196, 228);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(185, 22);
            this.textBoxNumber.TabIndex = 52;
            // 
            // labelNumber
            // 
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.Location = new System.Drawing.Point(18, 228);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(157, 23);
            this.labelNumber.TabIndex = 51;
            this.labelNumber.Text = "Numer";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(196, 186);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(185, 22);
            this.textBoxStreet.TabIndex = 50;
            // 
            // labelStreet
            // 
            this.labelStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStreet.Location = new System.Drawing.Point(18, 186);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(157, 23);
            this.labelStreet.TabIndex = 49;
            this.labelStreet.Text = "Ulica";
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Location = new System.Drawing.Point(196, 141);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(185, 22);
            this.textBoxPostCode.TabIndex = 48;
            // 
            // labePostCode
            // 
            this.labePostCode.BackColor = System.Drawing.Color.Transparent;
            this.labePostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labePostCode.Location = new System.Drawing.Point(18, 141);
            this.labePostCode.Name = "labePostCode";
            this.labePostCode.Size = new System.Drawing.Size(157, 23);
            this.labePostCode.TabIndex = 47;
            this.labePostCode.Text = "Kod pocztowy";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(196, 99);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(185, 22);
            this.textBoxCity.TabIndex = 46;
            // 
            // labelCity
            // 
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.Location = new System.Drawing.Point(18, 99);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(157, 23);
            this.labelCity.TabIndex = 45;
            this.labelCity.Text = "Miasto";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(196, 54);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(185, 22);
            this.textBoxCountry.TabIndex = 44;
            // 
            // labelCountry
            // 
            this.labelCountry.BackColor = System.Drawing.Color.Transparent;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountry.Location = new System.Drawing.Point(18, 54);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(157, 23);
            this.labelCountry.TabIndex = 43;
            this.labelCountry.Text = "Kraj";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(196, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(185, 22);
            this.textBoxId.TabIndex = 55;
            // 
            // labelId
            // 
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(18, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(157, 23);
            this.labelId.TabIndex = 54;
            this.labelId.Text = "Id";
            // 
            // FormUpdateAddress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(393, 311);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.textBoxPostCode);
            this.Controls.Add(this.labePostCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Name = "FormUpdateAddress";
            this.Text = "Aktualizacja adresu";
            this.Load += new System.EventHandler(this.FormUpdateAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.Label labePostCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}