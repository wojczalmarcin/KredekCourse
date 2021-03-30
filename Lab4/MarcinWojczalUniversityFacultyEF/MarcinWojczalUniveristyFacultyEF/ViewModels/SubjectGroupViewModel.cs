
using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli SubjectGroups
    /// </summary>
    class SubjectGroupViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Przedmiot")]
        public string SubjectName { get; set; }
        [DisplayName("Dzień")]
        public string DayOfWeek { get; set; }
        [DisplayName("Godzina")]
        public string Hour { get; set; }
        [DisplayName("Prowadzący")]
        public string WorkersDegree { get; set; }
        [DisplayName("Imię")]
        public string WorkersFirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string WorkersLastName { get; set; }        
    }
}
