
namespace MarcinWojczalUniversityFaculty.Forms
{
    partial class FormAddress
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
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxPostCode = new System.Windows.Forms.TextBox();
            this.labePostCode = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(190, 9);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(185, 22);
            this.textBoxCountry.TabIndex = 33;
            // 
            // labelCountry
            // 
            this.labelCountry.BackColor = System.Drawing.Color.Transparent;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountry.Location = new System.Drawing.Point(12, 9);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(157, 23);
            this.labelCountry.TabIndex = 32;
            this.labelCountry.Text = "Kraj";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(190, 54);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(185, 22);
            this.textBoxCity.TabIndex = 35;
            // 
            // labelCity
            // 
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.Location = new System.Drawing.Point(12, 54);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(157, 23);
            this.labelCity.TabIndex = 34;
            this.labelCity.Text = "Miasto";
            // 
            // textBoxPostCode
            // 
            this.textBoxPostCode.Location = new System.Drawing.Point(190, 96);
            this.textBoxPostCode.Name = "textBoxPostCode";
            this.textBoxPostCode.Size = new System.Drawing.Size(185, 22);
            this.textBoxPostCode.TabIndex = 37;
            // 
            // labePostCode
            // 
            this.labePostCode.BackColor = System.Drawing.Color.Transparent;
            this.labePostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labePostCode.Location = new System.Drawing.Point(12, 96);
            this.labePostCode.Name = "labePostCode";
            this.labePostCode.Size = new System.Drawing.Size(157, 23);
            this.labePostCode.TabIndex = 36;
            this.labePostCode.Text = "Kod pocztowy";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(190, 141);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(185, 22);
            this.textBoxStreet.TabIndex = 39;
            // 
            // labelStreet
            // 
            this.labelStreet.BackColor = System.Drawing.Color.Transparent;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStreet.Location = new System.Drawing.Point(12, 141);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(157, 23);
            this.labelStreet.TabIndex = 38;
            this.labelStreet.Text = "Ulica";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(190, 183);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(185, 22);
            this.textBoxNumber.TabIndex = 41;
            // 
            // labelNumber
            // 
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.Location = new System.Drawing.Point(12, 183);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(157, 23);
            this.labelNumber.TabIndex = 40;
            this.labelNumber.Text = "Numer";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 220);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(359, 34);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 269);
            this.Controls.Add(this.buttonAdd);
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
            this.Name = "FormAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowy adres";
            this.Load += new System.EventHandler(this.FormAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxPostCode;
        private System.Windows.Forms.Label labePostCode;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonAdd;
    }
}