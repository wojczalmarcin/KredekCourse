
namespace MarcinWojczalUniversityFacultyEF
{
    partial class FormAdmin
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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.radioButtonStudents = new System.Windows.Forms.RadioButton();
            this.checkBoxYear1 = new System.Windows.Forms.CheckBox();
            this.checkBoxYear2 = new System.Windows.Forms.CheckBox();
            this.checkBoxYear3 = new System.Windows.Forms.CheckBox();
            this.checkBoxIT = new System.Windows.Forms.CheckBox();
            this.checkBoxAIR = new System.Windows.Forms.CheckBox();
            this.checkBoxElectronics = new System.Windows.Forms.CheckBox();
            this.checkBoxCN = new System.Windows.Forms.CheckBox();
            this.labelFilters = new System.Windows.Forms.Label();
            this.radioButtonFieldsOfStudy = new System.Windows.Forms.RadioButton();
            this.radioButtonVintages = new System.Windows.Forms.RadioButton();
            this.radioButtonSubjects = new System.Windows.Forms.RadioButton();
            this.radioButtonSubjectGroups = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkplaces = new System.Windows.Forms.RadioButton();
            this.radioButtonAddresses = new System.Windows.Forms.RadioButton();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelPesel = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.textBoxDeficit = new System.Windows.Forms.TextBox();
            this.labelDeficit = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFieldOfStudyName = new System.Windows.Forms.TextBox();
            this.labelFieldOfStudyName = new System.Windows.Forms.Label();
            this.textBoxVintageYear = new System.Windows.Forms.TextBox();
            this.labelVintageYear = new System.Windows.Forms.Label();
            this.buttonUpdateStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonAddAddress = new System.Windows.Forms.Button();
            this.buttonDeleteAddress = new System.Windows.Forms.Button();
            this.buttonEditAddress = new System.Windows.Forms.Button();
            this.labelOperationConst = new System.Windows.Forms.Label();
            this.labelOperationStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(851, 444);
            this.dataGridViewAdmin.TabIndex = 0;
            this.dataGridViewAdmin.SelectionChanged += new System.EventHandler(this.dataGridViewAdmin_SelectionChanged);
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.Location = new System.Drawing.Point(880, 85);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(100, 21);
            this.radioButtonWorkers.TabIndex = 3;
            this.radioButtonWorkers.TabStop = true;
            this.radioButtonWorkers.Text = "Pracownicy";
            this.radioButtonWorkers.UseVisualStyleBackColor = true;
            this.radioButtonWorkers.CheckedChanged += new System.EventHandler(this.radioButtonWorkers_CheckedChanged);
            // 
            // radioButtonStudents
            // 
            this.radioButtonStudents.AutoSize = true;
            this.radioButtonStudents.Location = new System.Drawing.Point(880, 48);
            this.radioButtonStudents.Name = "radioButtonStudents";
            this.radioButtonStudents.Size = new System.Drawing.Size(84, 21);
            this.radioButtonStudents.TabIndex = 4;
            this.radioButtonStudents.TabStop = true;
            this.radioButtonStudents.Text = "Studenci";
            this.radioButtonStudents.UseVisualStyleBackColor = true;
            this.radioButtonStudents.CheckedChanged += new System.EventHandler(this.radioButtonStudents_CheckedChanged);
            // 
            // checkBoxYear1
            // 
            this.checkBoxYear1.AutoSize = true;
            this.checkBoxYear1.Location = new System.Drawing.Point(1139, 87);
            this.checkBoxYear1.Name = "checkBoxYear1";
            this.checkBoxYear1.Size = new System.Drawing.Size(67, 21);
            this.checkBoxYear1.TabIndex = 5;
            this.checkBoxYear1.Text = "Rok 1";
            this.checkBoxYear1.UseVisualStyleBackColor = true;
            this.checkBoxYear1.CheckedChanged += new System.EventHandler(this.checkBoxYear1_CheckedChanged);
            // 
            // checkBoxYear2
            // 
            this.checkBoxYear2.AutoSize = true;
            this.checkBoxYear2.Location = new System.Drawing.Point(1139, 127);
            this.checkBoxYear2.Name = "checkBoxYear2";
            this.checkBoxYear2.Size = new System.Drawing.Size(67, 21);
            this.checkBoxYear2.TabIndex = 6;
            this.checkBoxYear2.Text = "Rok 2";
            this.checkBoxYear2.UseVisualStyleBackColor = true;
            this.checkBoxYear2.CheckedChanged += new System.EventHandler(this.checkBoxYear2_CheckedChanged);
            // 
            // checkBoxYear3
            // 
            this.checkBoxYear3.AutoSize = true;
            this.checkBoxYear3.Location = new System.Drawing.Point(1139, 168);
            this.checkBoxYear3.Name = "checkBoxYear3";
            this.checkBoxYear3.Size = new System.Drawing.Size(67, 21);
            this.checkBoxYear3.TabIndex = 7;
            this.checkBoxYear3.Text = "Rok 3";
            this.checkBoxYear3.UseVisualStyleBackColor = true;
            this.checkBoxYear3.CheckedChanged += new System.EventHandler(this.checkBoxYear3_CheckedChanged);
            // 
            // checkBoxIT
            // 
            this.checkBoxIT.AutoSize = true;
            this.checkBoxIT.Location = new System.Drawing.Point(1017, 86);
            this.checkBoxIT.Name = "checkBoxIT";
            this.checkBoxIT.Size = new System.Drawing.Size(103, 21);
            this.checkBoxIT.TabIndex = 8;
            this.checkBoxIT.Text = "Informatyka";
            this.checkBoxIT.UseVisualStyleBackColor = true;
            this.checkBoxIT.CheckedChanged += new System.EventHandler(this.checkBoxIT_CheckedChanged);
            // 
            // checkBoxAIR
            // 
            this.checkBoxAIR.AutoSize = true;
            this.checkBoxAIR.Location = new System.Drawing.Point(1017, 126);
            this.checkBoxAIR.Name = "checkBoxAIR";
            this.checkBoxAIR.Size = new System.Drawing.Size(52, 21);
            this.checkBoxAIR.TabIndex = 9;
            this.checkBoxAIR.Text = "AIR";
            this.checkBoxAIR.UseVisualStyleBackColor = true;
            this.checkBoxAIR.CheckedChanged += new System.EventHandler(this.checkBoxAIR_CheckedChanged);
            // 
            // checkBoxElectronics
            // 
            this.checkBoxElectronics.AutoSize = true;
            this.checkBoxElectronics.Location = new System.Drawing.Point(1017, 168);
            this.checkBoxElectronics.Name = "checkBoxElectronics";
            this.checkBoxElectronics.Size = new System.Drawing.Size(100, 21);
            this.checkBoxElectronics.TabIndex = 10;
            this.checkBoxElectronics.Text = "Elektronika";
            this.checkBoxElectronics.UseVisualStyleBackColor = true;
            this.checkBoxElectronics.CheckedChanged += new System.EventHandler(this.checkBoxElectronics_CheckedChanged);
            // 
            // checkBoxCN
            // 
            this.checkBoxCN.AutoSize = true;
            this.checkBoxCN.Location = new System.Drawing.Point(1017, 206);
            this.checkBoxCN.Name = "checkBoxCN";
            this.checkBoxCN.Size = new System.Drawing.Size(114, 38);
            this.checkBoxCN.TabIndex = 11;
            this.checkBoxCN.Text = "Sieci\r\nkomputerowe";
            this.checkBoxCN.UseVisualStyleBackColor = true;
            this.checkBoxCN.CheckedChanged += new System.EventHandler(this.checkBoxCN_CheckedChanged);
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilters.Location = new System.Drawing.Point(1012, 48);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(75, 29);
            this.labelFilters.TabIndex = 12;
            this.labelFilters.Text = "Filtry:";
            // 
            // radioButtonFieldsOfStudy
            // 
            this.radioButtonFieldsOfStudy.AutoSize = true;
            this.radioButtonFieldsOfStudy.Location = new System.Drawing.Point(880, 126);
            this.radioButtonFieldsOfStudy.Name = "radioButtonFieldsOfStudy";
            this.radioButtonFieldsOfStudy.Size = new System.Drawing.Size(80, 21);
            this.radioButtonFieldsOfStudy.TabIndex = 13;
            this.radioButtonFieldsOfStudy.TabStop = true;
            this.radioButtonFieldsOfStudy.Text = "Kierunki";
            this.radioButtonFieldsOfStudy.UseVisualStyleBackColor = true;
            this.radioButtonFieldsOfStudy.CheckedChanged += new System.EventHandler(this.radioButtonFieldsOfStudy_CheckedChanged);
            // 
            // radioButtonVintages
            // 
            this.radioButtonVintages.AutoSize = true;
            this.radioButtonVintages.Location = new System.Drawing.Point(880, 167);
            this.radioButtonVintages.Name = "radioButtonVintages";
            this.radioButtonVintages.Size = new System.Drawing.Size(82, 21);
            this.radioButtonVintages.TabIndex = 14;
            this.radioButtonVintages.TabStop = true;
            this.radioButtonVintages.Text = "Roczniki";
            this.radioButtonVintages.UseVisualStyleBackColor = true;
            this.radioButtonVintages.CheckedChanged += new System.EventHandler(this.radioButtonVintages_CheckedChanged);
            // 
            // radioButtonSubjects
            // 
            this.radioButtonSubjects.AutoSize = true;
            this.radioButtonSubjects.Location = new System.Drawing.Point(880, 206);
            this.radioButtonSubjects.Name = "radioButtonSubjects";
            this.radioButtonSubjects.Size = new System.Drawing.Size(99, 21);
            this.radioButtonSubjects.TabIndex = 15;
            this.radioButtonSubjects.TabStop = true;
            this.radioButtonSubjects.Text = "Przedmioty";
            this.radioButtonSubjects.UseVisualStyleBackColor = true;
            this.radioButtonSubjects.CheckedChanged += new System.EventHandler(this.radioButtonSubjects_CheckedChanged);
            // 
            // radioButtonSubjectGroups
            // 
            this.radioButtonSubjectGroups.AutoSize = true;
            this.radioButtonSubjectGroups.Location = new System.Drawing.Point(880, 247);
            this.radioButtonSubjectGroups.Name = "radioButtonSubjectGroups";
            this.radioButtonSubjectGroups.Size = new System.Drawing.Size(133, 21);
            this.radioButtonSubjectGroups.TabIndex = 16;
            this.radioButtonSubjectGroups.TabStop = true;
            this.radioButtonSubjectGroups.Text = "Grupy zajęciowe";
            this.radioButtonSubjectGroups.UseVisualStyleBackColor = true;
            this.radioButtonSubjectGroups.CheckedChanged += new System.EventHandler(this.radioButtonSubjectGroups_CheckedChanged);
            // 
            // radioButtonWorkplaces
            // 
            this.radioButtonWorkplaces.AutoSize = true;
            this.radioButtonWorkplaces.Location = new System.Drawing.Point(880, 289);
            this.radioButtonWorkplaces.Name = "radioButtonWorkplaces";
            this.radioButtonWorkplaces.Size = new System.Drawing.Size(139, 21);
            this.radioButtonWorkplaces.TabIndex = 17;
            this.radioButtonWorkplaces.TabStop = true;
            this.radioButtonWorkplaces.Text = "Stanowiska pracy";
            this.radioButtonWorkplaces.UseVisualStyleBackColor = true;
            this.radioButtonWorkplaces.CheckedChanged += new System.EventHandler(this.radioButtonWorkplaces_CheckedChanged);
            // 
            // radioButtonAddresses
            // 
            this.radioButtonAddresses.AutoSize = true;
            this.radioButtonAddresses.Location = new System.Drawing.Point(880, 329);
            this.radioButtonAddresses.Name = "radioButtonAddresses";
            this.radioButtonAddresses.Size = new System.Drawing.Size(73, 21);
            this.radioButtonAddresses.TabIndex = 18;
            this.radioButtonAddresses.TabStop = true;
            this.radioButtonAddresses.Text = "Adresy";
            this.radioButtonAddresses.UseVisualStyleBackColor = true;
            this.radioButtonAddresses.CheckedChanged += new System.EventHandler(this.radioButtonAddresses_CheckedChanged);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBirthDate.Location = new System.Drawing.Point(12, 508);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(157, 23);
            this.labelBirthDate.TabIndex = 19;
            this.labelBirthDate.Text = "Data urodzenia";
            // 
            // labelPesel
            // 
            this.labelPesel.BackColor = System.Drawing.Color.Transparent;
            this.labelPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPesel.Location = new System.Drawing.Point(175, 508);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(136, 23);
            this.labelPesel.TabIndex = 20;
            this.labelPesel.Text = "Pesel";
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddress.Location = new System.Drawing.Point(346, 508);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(136, 23);
            this.labelAddress.TabIndex = 21;
            this.labelAddress.Text = "Id Adresu";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(520, 508);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(136, 23);
            this.labelPhoneNumber.TabIndex = 22;
            this.labelPhoneNumber.Text = "Nr telefonu";
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.Location = new System.Drawing.Point(14, 542);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.Size = new System.Drawing.Size(133, 22);
            this.textBoxBirthDate.TabIndex = 23;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(179, 542);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(133, 22);
            this.textBoxPesel.TabIndex = 24;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(350, 542);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(133, 22);
            this.textBoxAddress.TabIndex = 25;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(523, 542);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(133, 22);
            this.textBoxPhoneNumber.TabIndex = 26;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(701, 542);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(133, 22);
            this.textBoxEMail.TabIndex = 28;
            // 
            // labelEMail
            // 
            this.labelEMail.BackColor = System.Drawing.Color.Transparent;
            this.labelEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEMail.Location = new System.Drawing.Point(698, 508);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(136, 23);
            this.labelEMail.TabIndex = 27;
            this.labelEMail.Text = "E-mail";
            // 
            // textBoxDeficit
            // 
            this.textBoxDeficit.Location = new System.Drawing.Point(869, 609);
            this.textBoxDeficit.Name = "textBoxDeficit";
            this.textBoxDeficit.Size = new System.Drawing.Size(133, 22);
            this.textBoxDeficit.TabIndex = 30;
            // 
            // labelDeficit
            // 
            this.labelDeficit.BackColor = System.Drawing.Color.Transparent;
            this.labelDeficit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDeficit.Location = new System.Drawing.Point(866, 575);
            this.labelDeficit.Name = "labelDeficit";
            this.labelDeficit.Size = new System.Drawing.Size(136, 23);
            this.labelDeficit.TabIndex = 29;
            this.labelDeficit.Text = "Deficyt ECTS";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(14, 609);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(133, 22);
            this.textBoxIndex.TabIndex = 32;
            // 
            // labelIndex
            // 
            this.labelIndex.BackColor = System.Drawing.Color.Transparent;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIndex.Location = new System.Drawing.Point(12, 575);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(136, 23);
            this.labelIndex.TabIndex = 31;
            this.labelIndex.Text = "Nr albumu";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(178, 609);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(133, 22);
            this.textBoxFirstName.TabIndex = 34;
            // 
            // labelFirstName
            // 
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(176, 575);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(136, 23);
            this.labelFirstName.TabIndex = 33;
            this.labelFirstName.Text = "Imię";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(348, 609);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(133, 22);
            this.textBoxLastName.TabIndex = 36;
            // 
            // labelLastName
            // 
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(346, 575);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(136, 23);
            this.labelLastName.TabIndex = 35;
            this.labelLastName.Text = "Nazwisko";
            // 
            // textBoxFieldOfStudyName
            // 
            this.textBoxFieldOfStudyName.Location = new System.Drawing.Point(522, 609);
            this.textBoxFieldOfStudyName.Name = "textBoxFieldOfStudyName";
            this.textBoxFieldOfStudyName.Size = new System.Drawing.Size(133, 22);
            this.textBoxFieldOfStudyName.TabIndex = 38;
            // 
            // labelFieldOfStudyName
            // 
            this.labelFieldOfStudyName.BackColor = System.Drawing.Color.Transparent;
            this.labelFieldOfStudyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFieldOfStudyName.Location = new System.Drawing.Point(520, 575);
            this.labelFieldOfStudyName.Name = "labelFieldOfStudyName";
            this.labelFieldOfStudyName.Size = new System.Drawing.Size(136, 23);
            this.labelFieldOfStudyName.TabIndex = 37;
            this.labelFieldOfStudyName.Text = "Nazwa kierunku";
            // 
            // textBoxVintageYear
            // 
            this.textBoxVintageYear.Location = new System.Drawing.Point(700, 609);
            this.textBoxVintageYear.Name = "textBoxVintageYear";
            this.textBoxVintageYear.Size = new System.Drawing.Size(133, 22);
            this.textBoxVintageYear.TabIndex = 40;
            // 
            // labelVintageYear
            // 
            this.labelVintageYear.BackColor = System.Drawing.Color.Transparent;
            this.labelVintageYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVintageYear.Location = new System.Drawing.Point(698, 575);
            this.labelVintageYear.Name = "labelVintageYear";
            this.labelVintageYear.Size = new System.Drawing.Size(136, 23);
            this.labelVintageYear.TabIndex = 39;
            this.labelVintageYear.Text = "Rok rozpoczęcia";
            // 
            // buttonUpdateStudent
            // 
            this.buttonUpdateStudent.Location = new System.Drawing.Point(867, 533);
            this.buttonUpdateStudent.Name = "buttonUpdateStudent";
            this.buttonUpdateStudent.Size = new System.Drawing.Size(135, 31);
            this.buttonUpdateStudent.TabIndex = 41;
            this.buttonUpdateStudent.Text = "Modyfikuj";
            this.buttonUpdateStudent.UseVisualStyleBackColor = true;
            this.buttonUpdateStudent.Click += new System.EventHandler(this.buttonUpdateStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(1060, 533);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(135, 31);
            this.buttonAddStudent.TabIndex = 42;
            this.buttonAddStudent.Text = "Dodaj";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(1060, 600);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(135, 31);
            this.buttonDeleteStudent.TabIndex = 43;
            this.buttonDeleteStudent.Text = "Usuń";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonAddAddress
            // 
            this.buttonAddAddress.Location = new System.Drawing.Point(880, 367);
            this.buttonAddAddress.Name = "buttonAddAddress";
            this.buttonAddAddress.Size = new System.Drawing.Size(139, 27);
            this.buttonAddAddress.TabIndex = 44;
            this.buttonAddAddress.Text = "Nowy adres";
            this.buttonAddAddress.UseVisualStyleBackColor = true;
            this.buttonAddAddress.Click += new System.EventHandler(this.buttonAddAddress_Click);
            // 
            // buttonDeleteAddress
            // 
            this.buttonDeleteAddress.Location = new System.Drawing.Point(881, 400);
            this.buttonDeleteAddress.Name = "buttonDeleteAddress";
            this.buttonDeleteAddress.Size = new System.Drawing.Size(139, 27);
            this.buttonDeleteAddress.TabIndex = 45;
            this.buttonDeleteAddress.Text = "Usuń adres";
            this.buttonDeleteAddress.UseVisualStyleBackColor = true;
            this.buttonDeleteAddress.Click += new System.EventHandler(this.buttonDeleteAddress_Click);
            // 
            // buttonEditAddress
            // 
            this.buttonEditAddress.Location = new System.Drawing.Point(881, 433);
            this.buttonEditAddress.Name = "buttonEditAddress";
            this.buttonEditAddress.Size = new System.Drawing.Size(139, 27);
            this.buttonEditAddress.TabIndex = 46;
            this.buttonEditAddress.Text = "Edytuj adres";
            this.buttonEditAddress.UseVisualStyleBackColor = true;
            this.buttonEditAddress.Click += new System.EventHandler(this.buttonEditAddress_Click);
            // 
            // labelOperationConst
            // 
            this.labelOperationConst.AutoSize = true;
            this.labelOperationConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOperationConst.Location = new System.Drawing.Point(13, 16);
            this.labelOperationConst.Name = "labelOperationConst";
            this.labelOperationConst.Size = new System.Drawing.Size(272, 20);
            this.labelOperationConst.TabIndex = 47;
            this.labelOperationConst.Text = "Status ostatnio wykonanej operacji:";
            // 
            // labelOperationStatus
            // 
            this.labelOperationStatus.AutoSize = true;
            this.labelOperationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOperationStatus.Location = new System.Drawing.Point(327, 16);
            this.labelOperationStatus.Name = "labelOperationStatus";
            this.labelOperationStatus.Size = new System.Drawing.Size(294, 20);
            this.labelOperationStatus.TabIndex = 48;
            this.labelOperationStatus.Text = "NIE WYKYNANO ŻADNEJ OPERACJI";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 643);
            this.Controls.Add(this.labelOperationStatus);
            this.Controls.Add(this.labelOperationConst);
            this.Controls.Add(this.buttonEditAddress);
            this.Controls.Add(this.buttonDeleteAddress);
            this.Controls.Add(this.buttonAddAddress);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonUpdateStudent);
            this.Controls.Add(this.textBoxVintageYear);
            this.Controls.Add(this.labelVintageYear);
            this.Controls.Add(this.textBoxFieldOfStudyName);
            this.Controls.Add(this.labelFieldOfStudyName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.textBoxDeficit);
            this.Controls.Add(this.labelDeficit);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.textBoxBirthDate);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPesel);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.radioButtonAddresses);
            this.Controls.Add(this.radioButtonWorkplaces);
            this.Controls.Add(this.radioButtonSubjectGroups);
            this.Controls.Add(this.radioButtonSubjects);
            this.Controls.Add(this.radioButtonVintages);
            this.Controls.Add(this.radioButtonFieldsOfStudy);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.checkBoxCN);
            this.Controls.Add(this.checkBoxElectronics);
            this.Controls.Add(this.checkBoxAIR);
            this.Controls.Add(this.checkBoxIT);
            this.Controls.Add(this.checkBoxYear3);
            this.Controls.Add(this.checkBoxYear2);
            this.Controls.Add(this.checkBoxYear1);
            this.Controls.Add(this.radioButtonStudents);
            this.Controls.Add(this.radioButtonWorkers);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Name = "FormAdmin";
            this.Text = "Wydział na uczelni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.RadioButton radioButtonStudents;
        private System.Windows.Forms.CheckBox checkBoxYear1;
        private System.Windows.Forms.CheckBox checkBoxYear2;
        private System.Windows.Forms.CheckBox checkBoxYear3;
        private System.Windows.Forms.CheckBox checkBoxIT;
        private System.Windows.Forms.CheckBox checkBoxAIR;
        private System.Windows.Forms.CheckBox checkBoxElectronics;
        private System.Windows.Forms.CheckBox checkBoxCN;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.RadioButton radioButtonFieldsOfStudy;
        private System.Windows.Forms.RadioButton radioButtonVintages;
        private System.Windows.Forms.RadioButton radioButtonSubjects;
        private System.Windows.Forms.RadioButton radioButtonSubjectGroups;
        private System.Windows.Forms.RadioButton radioButtonWorkplaces;
        private System.Windows.Forms.RadioButton radioButtonAddresses;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.TextBox textBoxDeficit;
        private System.Windows.Forms.Label labelDeficit;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFieldOfStudyName;
        private System.Windows.Forms.Label labelFieldOfStudyName;
        private System.Windows.Forms.TextBox textBoxVintageYear;
        private System.Windows.Forms.Label labelVintageYear;
        private System.Windows.Forms.Button buttonUpdateStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonAddAddress;
        private System.Windows.Forms.Button buttonDeleteAddress;
        private System.Windows.Forms.Button buttonEditAddress;
        private System.Windows.Forms.Label labelOperationConst;
        private System.Windows.Forms.Label labelOperationStatus;
    }
}

