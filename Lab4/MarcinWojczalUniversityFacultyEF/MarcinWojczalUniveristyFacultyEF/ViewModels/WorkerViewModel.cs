using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli Workers
    /// </summary>
    class WorkerViewModel
    {
        public int Id { get; set; }
        [DisplayName("Stopień naukowy")]
        public string Degree { get; set; }
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [DisplayName("Stanowisko")]
        public string WorkplaceName { get; set; }
        [DisplayName("Wynagrodzenie")]
        public int Salary { get; set; }
    }
}
