using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinWojczalUniversityFaculty.Forms
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

            DataTable dataTable = formAdmin.residencePlacesRepository.GetRepositoryById(formAdmin.AddressId);
            textBoxCountry.Text = dataTable.Rows[0][1].ToString();
            textBoxCity.Text = dataTable.Rows[0][2].ToString();
            textBoxPostCode.Text = dataTable.Rows[0][3].ToString();
            textBoxStreet.Text = dataTable.Rows[0][4].ToString();
            textBoxNumber.Text = dataTable.Rows[0][5].ToString();
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
                    formAdmin.residencePlacesRepository.UpdateResidencePlace(formAdmin.AddressId,country, city, postCode, street, number);
                }
                catch (Exception)
                {

                    MessageBox.Show("Niepoprawne dane");
                }
                formAdmin.RefreshDataGridView();
            }
        }
    }
}
