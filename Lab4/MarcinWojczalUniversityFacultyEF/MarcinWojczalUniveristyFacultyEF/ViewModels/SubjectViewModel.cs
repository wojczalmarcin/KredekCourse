using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli Subjects
    /// </summary>
    class SubjectViewModel
    {
        public int Id { get; set; }
        [DisplayName("Kierunek")]
        public string FieldOfStudyName { get; set; }
        [DisplayName("Nazwa przedmiotu")]
        public string Name { get; set; }
        [DisplayName("Semestr")]
        public short Term { get; set; }
        [DisplayName("ECTS")]
        public short ECTS { get; set; }
    }
}
