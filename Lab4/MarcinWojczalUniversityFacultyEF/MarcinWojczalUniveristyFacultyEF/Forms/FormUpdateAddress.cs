using MarcinWojczalUniversityFacultyEF.Models.Entities;
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
    partial class FormUpdateAddress : Form
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
        public FormUpdateAddress(FormAdmin formAdmin)
        {
            this.formAdmin = formAdmin;
            InitializeComponent();  
        }
        /// <summary>
        /// Funkcja ładująca Form'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUpdateAddress_Load(object sender, EventArgs e)
        {
            textBoxId.Text = formAdmin.AddressId.ToString();

            Address address = formAdmin.residencePlacesRepository.GetAddressById(formAdmin.AddressId);
            textBoxCountry.Text = address.Country;
            textBoxCity.Text = address.City;
            textBoxPostCode.Text = address.PostCode;
            textBoxStreet.Text = address.Street;
            textBoxNumber.Text = address.Number.ToString();
        }
        /// <summary>
        /// Przycisk aktualizujący dane adresu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
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
            if (country == null || country == "" || city == "" || city == null || postCode == "" || postCode == null || number == null)
            {
                MessageBox.Show("Niepoprawne dane");
            }
            else
            {
                try
                {
                    if(formAdmin.residencePlacesRepository.UpdateAddress(formAdmin.AddressId,country, city, postCode, street, number))
                        formAdmin.setOperationStatusLabel("ZAKTUALIZOWANO ADRES");
                    else
                        formAdmin.setOperationStatusLabel("BŁĄD PRZY AKTUALIZOWANIU NOWEGO ADRESU");
                }
                catch (Exception)
                {
                    formAdmin.setOperationStatusLabel("BŁĄD PRZY AKTUALIZOWANIU ADRESU");
                    MessageBox.Show("Niepoprawne dane");
                }
                formAdmin.RefreshDataGridView();
            }
        }
    }
}
