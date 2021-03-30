
using System.ComponentModel;

namespace MarcinWojczalUniveristyFacultyEF.ViewModels
{
    /// <summary>
    /// Klasa reprezentująca widok z tabeli Workplaces
    /// </summary>
    class WorkplaceViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Płaca minimalna")]
        public int BaseSalary { get; set; }

    }
}
