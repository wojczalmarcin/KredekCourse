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
    /// Okno logowania
    /// </summary>
    public partial class FormLogin : Form
    {
        // Obiekt do przetwarzania danych związanych z tabelą Users
        private UsersRepository usersRepository;
       /// <summary>
       /// Konstruktor
       /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            usersRepository = new UsersRepository();
        }
        /// <summary>
        /// Przycisk logujący
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
             string login = textBoxLogin.Text;
             string password = textBoxPassword.Text;

             if (usersRepository.IsLoginCorrect(login, password))
             {
                 FormAdmin formAdmin = new FormAdmin();
                 formAdmin.Show();
                 Hide();
             }
             else
             {
                 MessageBox.Show("Niepoprawny login lub hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 textBoxLogin.Text = "";
                 textBoxPassword.Text = "";
             }
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (usersRepository.ConnectionExists())
            {
                buttonLogin.Enabled = true;
            }
            else
            {
                MessageBox.Show("Brak połączenia z bazą danych");
                buttonLogin.Enabled = false;
            }
        }
    }
}
