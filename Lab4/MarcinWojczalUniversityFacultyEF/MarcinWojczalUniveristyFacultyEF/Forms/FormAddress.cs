using MarcinWojczalUniversityFacultyEF.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinWojczalUniversityFacultyEF.Forms
{
    /// <summary>
    /// Form odpowiedzialny za dodanie adresu
    /// </summary>
     partial class FormAddress : Form
     {
        // Zmienna głównego okna
        private FormAdmin formAdmin;
        // Zmienne będące atrybutami adresu
        string country;
        string city;
        string postCode;
        string street;
        int number;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="formAdmin"></param>
        public FormAddress(FormAdmin formAdmin)
        {
            this.formAdmin = formAdmin;
            InitializeComponent();
        }
        private void FormAddress_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Przycisk dodający nowe miejsce zamieszkania do tabeli ResidencePlaces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        { 
            try
            {
                country = textBoxCountry.Text;
                city = textBoxCity.Text;
                postCode = textBoxPostCode.Text;
                street = textBoxStreet.Text;
                number = int.Parse(textBoxNumber.Text);
            }
            catch
            {

            }
            if(country == null || country =="" || city =="" || city==null || postCode =="" || postCode == null || number == null)
            {
                MessageBox.Show("Niepoprawne dane");
            }
            else
            {
                try
                {
                    if (formAdmin.residencePlacesRepository.AddAddress(country, city, postCode, street, number))
                        formAdmin.setOperationStatusLabel("DODANO NOWY ADRES");
                    else
                        formAdmin.setOperationStatusLabel("BŁĄD PRZY DODAWANIU NOWEGO ADRESU");
                }
                catch (Exception)
                {
                    formAdmin.setOperationStatusLabel("BŁĄD PRZY DODAWANIU NOWEGO ADRESU");
                    MessageBox.Show("Niepoprawne dane");
                }
                formAdmin.RefreshDataGridView();
            }
           
        }

    }
}
