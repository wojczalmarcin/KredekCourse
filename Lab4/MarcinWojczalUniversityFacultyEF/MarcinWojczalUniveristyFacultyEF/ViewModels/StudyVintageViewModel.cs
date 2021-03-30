using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli StudyVintages
    /// </summary>
    class StudyVintageViewModel
    {
        [DisplayName("Początek indeksu")]
        public int VIndex { get; set; }
        [DisplayName("Rok rozpoczęcia")]
        public int Year { get; set; }
        [DisplayName("Imię opiekuna")]
        public string PatronsFirstName { get; set; }
        [DisplayName("Nazwisko opiekuna")]
        public string PatronsLastName { get; set; }

    }
}
