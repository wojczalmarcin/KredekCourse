using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli Students
    /// </summary>
    class StudentViewModel
    {
        [DisplayName("Indeks")]
        public int Sindex { get; set; }
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [DisplayName("Kierunek")]
        public string FieldOfStudyName { get; set; }
        [DisplayName("Rok")]
        public int StudyVintageYear { get; set; }

    }
}
