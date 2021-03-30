using MarcinWojczalUniversityFacultyEF.Forms;
using MarcinWojczalUniversityFacultyEF.Models.Entities;
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

namespace MarcinWojczalUniversityFacultyEF
{
    /// <summary>
    /// Okno główne programu
    /// </summary>
    partial class FormAdmin : Form
    {
        // Obiekt do przetwarzania danych związanych z tabelą Workers
        private readonly WorkersRepository workersRepository;

        // Obiekt do przetwarzania danych związanych z tabelą Students
        private readonly StudentsRepository studentsRepository;

        // Obiekt do przetwarzania danych związanych z tabelą FieldsOfStudy
        private readonly FieldsOfStudiesRepository fieldsOfStudyRepository;

        // Obiekt do przetwarzania danych związanych z tabelą ResidencePlaces
        public AddressesRepository residencePlacesRepository { get; set; }

        // Obiekt do przetwarzania danych związanych z tabelą StudyVintages
        private readonly StudyVintagesRepository studyVintagesRepository;

        // Obiekt do przetwarzania danych związanych z tabelą SubjectGroups
        private readonly SubjectGroupsRepository subjectGroupsRepository;

        // Obiekt do przetwarzania danych związanych z tabelą Subjects
        private readonly SubjectsRepository subjectsRepository;

        // Obiekt do przetwarzania danych związanych z tabelą Workplaces
        private readonly WorkplacesRepository workplacesRepository;

        // Zmienne będące atrybutami rekordu z tabeli Students
        int index, studyVintageYear, residencePlaceId ;
        string firstName, lastName, pesel, eMail, fieldOfStudyName, phoneNumber;
        short deficit;
        DateTime birthDate;

        // Zmienna Id z tabeli residencePlaces
        public int AddressId { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public FormAdmin()
        {
            InitializeComponent();
            workersRepository = new WorkersRepository();
            studentsRepository = new StudentsRepository();
            fieldsOfStudyRepository = new FieldsOfStudiesRepository();
            residencePlacesRepository = new AddressesRepository();
            studyVintagesRepository = new StudyVintagesRepository();
            subjectGroupsRepository = new SubjectGroupsRepository();
            subjectsRepository = new SubjectsRepository();
            workplacesRepository = new WorkplacesRepository();
        }
        /// <summary>
        /// Funkcja ładująca Form'a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            radioButtonStudents.Checked = true;
            if (radioButtonStudents.Checked)
                EnableStudentComponents();
            else
                DisableStudentComponents();
            RefreshDataGridView();
        }
        /// <summary>
        /// Funkcja wyłączająca kompontenty związane ze studentem
        /// </summary>
        private void DisableStudentComponents()
        {
            checkBoxAIR.Enabled = false;
            checkBoxIT.Enabled = false;
            checkBoxElectronics.Enabled = false;
            checkBoxCN.Enabled = false;
            checkBoxYear1.Enabled = false;
            checkBoxYear2.Enabled = false;
            checkBoxYear3.Enabled = false;
            labelFilters.Enabled = false;
            
            labelAddress.Enabled = false;
            labelBirthDate.Enabled = false;
            labelDeficit.Enabled = false;
            labelEMail.Enabled = false;
            labelFieldOfStudyName.Enabled = false;
            labelFirstName.Enabled = false;
            labelIndex.Enabled = false;
            labelLastName.Enabled = false;
            labelPesel.Enabled = false;
            labelPhoneNumber.Enabled = false;
            labelVintageYear.Enabled = false;

            textBoxAddress.Enabled = false;
            textBoxBirthDate.Enabled = false;
            textBoxDeficit.Enabled = false;
            textBoxEMail.Enabled = false;
            textBoxFieldOfStudyName.Enabled = false;
            textBoxFirstName.Enabled = false;
            textBoxIndex.Enabled = false;
            textBoxLastName.Enabled = false;
            textBoxPesel.Enabled = false;
            textBoxPhoneNumber.Enabled = false;
            textBoxVintageYear.Enabled = false;

            buttonAddStudent.Enabled = false;
            buttonDeleteStudent.Enabled = false;
            buttonUpdateStudent.Enabled = false;
        }
        /// <summary>
        /// Funkcja włączająca kompontenty związane ze studentem
        /// </summary>
        private void EnableStudentComponents()
        {
            checkBoxAIR.Enabled = true;
            checkBoxIT.Enabled = true;
            checkBoxElectronics.Enabled = true;
            checkBoxCN.Enabled = true;
            checkBoxYear1.Enabled = true;
            checkBoxYear2.Enabled = true;
            checkBoxYear3.Enabled = true;
            labelFilters.Enabled = true;

            labelAddress.Enabled = true;
            labelBirthDate.Enabled = true;
            labelDeficit.Enabled = true;
            labelEMail.Enabled = true;
            labelFieldOfStudyName.Enabled = true;
            labelFirstName.Enabled = true;
            labelIndex.Enabled = true;
            labelLastName.Enabled = true;
            labelPesel.Enabled = true;
            labelPhoneNumber.Enabled = true;
            labelVintageYear.Enabled = true;

            textBoxAddress.Enabled = true;
            textBoxBirthDate.Enabled = true;
            textBoxDeficit.Enabled = true;
            textBoxEMail.Enabled = true;
            textBoxFieldOfStudyName.Enabled = true;
            textBoxFirstName.Enabled = true;
            textBoxIndex.Enabled = true;
            textBoxLastName.Enabled = true;
            textBoxPesel.Enabled = true;
            textBoxPhoneNumber.Enabled = true;
            textBoxVintageYear.Enabled = true;

            buttonAddStudent.Enabled = true;
            buttonDeleteStudent.Enabled = true;
            buttonUpdateStudent.Enabled = true;
        }
        /// <summary>
        /// Funkcja odświerzająca DataGridView
        /// </summary>
        public void RefreshDataGridView()
        {
            if (radioButtonStudents.Checked)
            {
                List<int> fieldOfStudyIds = new List<int>();
                List<int> vintageIndexes = new List<int>();
                if (checkBoxIT.Checked) { fieldOfStudyIds.Add(1); }
                if (checkBoxAIR.Checked) { fieldOfStudyIds.Add(2); }
                if (checkBoxElectronics.Checked) { fieldOfStudyIds.Add(3); }
                if (checkBoxCN.Checked) { fieldOfStudyIds.Add(4); }
                if (checkBoxYear1.Checked) { vintageIndexes.Add(20); }
                if (checkBoxYear2.Checked) { vintageIndexes.Add(19); }
                if (checkBoxYear3.Checked) { vintageIndexes.Add(18); }
                dataGridViewAdmin.DataSource = studentsRepository.GetStudents(fieldOfStudyIds,vintageIndexes);
            }
            else if (radioButtonWorkers.Checked)
            {
                dataGridViewAdmin.DataSource = workersRepository.GetWorkers();
            }
            else if(radioButtonVintages.Checked)
            {
                dataGridViewAdmin.DataSource = studyVintagesRepository.GetStudyVintages();
            }
            else if (radioButtonFieldsOfStudy.Checked)
            {
                dataGridViewAdmin.DataSource = fieldsOfStudyRepository.GetFieldsOfStudies();
            }
            else if (radioButtonSubjects.Checked)
            {
                dataGridViewAdmin.DataSource = subjectsRepository.GetSubjects();
            }
            else if (radioButtonSubjectGroups.Checked)
            {
                dataGridViewAdmin.DataSource = subjectGroupsRepository.GetSubjectGroups();
            }
            else if (radioButtonWorkplaces.Checked)
            {
                dataGridViewAdmin.DataSource = workplacesRepository.GetWorkplaces();
            }
            else if (radioButtonAddresses.Checked)
            {
                dataGridViewAdmin.DataSource = residencePlacesRepository.GetAddresses();
            }
            if (radioButtonAddresses.Checked)
            {
                buttonEditAddress.Enabled = true;
                buttonDeleteAddress.Enabled = true;
            }
            else
            {
                buttonEditAddress.Enabled = false;
                buttonDeleteAddress.Enabled = false;
            }
        }

        /// <summary>
        /// zdarzenie obsługujące zaznaczenie wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (radioButtonStudents.Checked)
            {
                int studentIndex;
                int rowsCount = dataGridViewAdmin.SelectedRows.Count;
                if (rowsCount == 0 || rowsCount > 1)
                    return;
                DataGridViewRow row = dataGridViewAdmin.SelectedRows[0];
                studentIndex = int.Parse(row.Cells[0].Value.ToString());
                string date = studentsRepository.GetStudent(studentIndex).BirthDate.ToString();
                date = date.Substring(0, date.Length - 9);
                textBoxBirthDate.Text = date;
                Student currentStudent = studentsRepository.GetStudent(studentIndex);
                textBoxPesel.Text = currentStudent.Pesel;
                textBoxAddress.Text = currentStudent.AddressId.ToString();
                textBoxPhoneNumber.Text = currentStudent.PhoneNumber;
                textBoxEMail.Text = currentStudent.EMail;
                textBoxIndex.Text = currentStudent.Sindex.ToString();
                textBoxFirstName.Text = currentStudent.FirstName;
                textBoxLastName.Text = currentStudent.LastName;
                textBoxFieldOfStudyName.Text = currentStudent.FieldOfStudy.Name;
                textBoxVintageYear.Text = currentStudent.StudyVintage.Year.ToString();
                textBoxDeficit.Text = currentStudent.ECTSDeficit.ToString();
            }else if(radioButtonAddresses.Checked)
            {
                int rowsCount = dataGridViewAdmin.SelectedRows.Count;
                if (rowsCount == 0 || rowsCount > 1)
                    return;
                DataGridViewRow row = dataGridViewAdmin.SelectedRows[0];
                AddressId = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        /// <summary>
        /// Funkcja pobierająca dane z bloków tekstowych
        /// </summary>
        private void GetDataFromTextBoxes()
        {
            try
            {
                index = int.Parse(textBoxIndex.Text);
                fieldOfStudyName = textBoxFieldOfStudyName.Text;
                studyVintageYear = int.Parse(textBoxVintageYear.Text);
                firstName = textBoxFirstName.Text;
                lastName = textBoxLastName.Text;
                birthDate = DateTime.Parse(textBoxBirthDate.Text);
                pesel = textBoxPesel.Text;
                residencePlaceId = int.Parse(textBoxAddress.Text);
                deficit = short.Parse(textBoxDeficit.Text);
                phoneNumber = textBoxPhoneNumber.Text;
                eMail = textBoxEMail.Text;
            }
            catch
            {

            }
          
        }
        /// <summary>
        /// Przycisk aktualizujący dane studenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();
            try
            {
                if (studentsRepository.UpdateStudent(index, fieldOfStudyName, studyVintageYear, firstName, lastName, birthDate, pesel, residencePlaceId, deficit, phoneNumber, eMail))
                {
                    labelOperationStatus.Text = "ZAKTUALIZOWANO STUDENTA O INDEKSIE " + index;
                    RefreshDataGridView();
                }
                else
                    labelOperationStatus.Text = "BŁĄD PRZY AKTUALIZOWANIU STUDENTA O INDEKSIE " + index;

            }
            catch (Exception)
            {
                labelOperationStatus.Text = "BŁĄD PRZY AKTUALIZOWANIU STUDENTA O INDEKSIE " + index;
                MessageBox.Show("Dane są nieprawidłowe");
            }
        }
        /// <summary>
        /// Przycisk dodający studenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();
            try
            {
                if(studentsRepository.AddStudent(index, fieldOfStudyName, studyVintageYear, firstName, lastName, birthDate, pesel, residencePlaceId, deficit,phoneNumber, eMail))
                {
                    labelOperationStatus.Text = "DODANO STUDENTA O INDEKSIE " + index;
                    RefreshDataGridView();
                }     
                else
                    labelOperationStatus.Text = "BŁĄD PRZY DODAWANIU STUDENTA O INDEKSIE " + index;

            }
            catch (Exception)
            {
                labelOperationStatus.Text = "BŁĄD PRZY DODAWANIU STUDENTA O INDEKSIE " + index;
                MessageBox.Show("Nastąpił błąd, prawdopodobnie podany indeks już istnieje");
            }
        }
        /// <summary>
        /// Przycisk usuwający studenta o zadanym indeksie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            GetDataFromTextBoxes();
            try
            {
                if (studentsRepository.DeleteStudent(index))
                    labelOperationStatus.Text = "USUNIĘTO STUDENTA O INDEKSIE " + index;
                else
                    labelOperationStatus.Text = "BŁĄD PRZY USUWANIU STUDENTA O INDEKSIE " + index;
            }
            catch (Exception)
            {
                labelOperationStatus.Text = "BŁĄD PRZY USUWANIU STUDENTA O INDEKSIE " + index;
                MessageBox.Show("Podany indeks nie istnieje");
            }
            RefreshDataGridView();
        }
        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli Workers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli Students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonStudents_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStudents.Checked)
                EnableStudentComponents();
            else
                DisableStudentComponents();
            RefreshDataGridView();
        }
        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli FieldsOfStudy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonFieldsOfStudy_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli StudyVintages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonVintages_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli Subjects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSubjects_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli SubjectGroups
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSubjectGroups_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// Przycisk uruchomiający okno dodawania adresów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            FormAddress formAddress = new FormAddress(this);
            formAddress.Show();
        }
        /// <summary>
        /// Metoda zamykająca cały program po wyjściu z Form'y FormAdmin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// Przycisk uruchamiający okno do edytowania adresu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteAddress_Click(object sender, EventArgs e)
        {
            int personId = residencePlacesRepository.CanBeDeleted(AddressId);
            if (personId == 0)
            {
                if(residencePlacesRepository.DeleteAddress(AddressId))
                {
                    labelOperationStatus.Text = "USUNIĘTO ADRES O ID " + AddressId;
                    MessageBox.Show("Adres został pomyślnie usunięty z bazy");
                    RefreshDataGridView();
                }
                else
                    labelOperationStatus.Text = "BŁĄD PRZY USUWANIU ADRESU O ID " + AddressId;
            }
            else
            {
                labelOperationStatus.Text = "BŁĄD PRZY USUWANIU ADRESU O ID " + AddressId;
                if(personId>170000)
                    MessageBox.Show("Nie można usunąć, ponieważ ten adres jest aktualnie wykorzystywany przez studenta o indeksie " + personId);
                else
                    MessageBox.Show("Nie można usunąć, ponieważ ten adres jest aktualnie wykorzystywany przez pracownika o Id = " + personId);
            }
        }
        /// <summary>
        /// Przycisk usuwający adres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAddress_Click(object sender, EventArgs e)
        {
            FormUpdateAddress formUpdateAddress = new FormUpdateAddress(this);
            formUpdateAddress.Show();
        }

        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli Workplace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonWorkplaces_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// RadioButton odpowiedzialny za wyświetlenie tabeli ResidencePlaces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAddresses_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// CheckBox filtrujący po kierunku Informatyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxIT_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// CheckBox filtrujący po kierunku Automatyka i Robotyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxAIR_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// CheckBox filtrujący po kierunku Elektronika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxElectronics_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// CheckBox filtrujący po kierunku Sieci komputerowe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxCN_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// CheckBox filtrujący po roku studiów 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxYear1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// CheckBox filtrujący po roku studiów 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxYear2_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// CheckBox filtrujący po roku studiów 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxYear3_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
        /// <summary>
        /// Metoda ustawiająca tekst w etykiecie labelOperationStatus
        /// </summary>
        /// <param name="status"></param>
        public void setOperationStatusLabel(string status)
        {
            labelOperationStatus.Text = status;
        }

    }
}
