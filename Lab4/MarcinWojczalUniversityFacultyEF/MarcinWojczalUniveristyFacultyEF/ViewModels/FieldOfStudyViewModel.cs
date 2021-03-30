using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli FieldOfStudies
    /// </summary>
    class FieldOfStudyViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Opiekun:")]
        public string PatronsDegree { get; set; }
        [DisplayName("Imię")]
        public string PatronsFirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string PatronsLastName { get; set; }
    }
}
