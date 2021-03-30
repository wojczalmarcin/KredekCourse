using MarcinWojczalUniveristyFacultyEF.ViewModels;
using MarcinWojczalUniversityFacultyEF.Models.Entities;
using MarcinWojczalUniversityFacultyEF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Workplaces
    /// </summary>
    class WorkplacesRepository : Repository
    {
        /// <summary>
        /// Funkcja zwracająca wszystkie rekordy tabeli Workplaces
        /// </summary>
        /// <returns></returns>
        public List<WorkplaceViewModel> GetWorkplaces()
        {
            List<Workplace> workplaces = DbContext.Workplaces.ToList();
            return Mapper.Map<List<Workplace>, List<WorkplaceViewModel>>(workplaces);
        }
    }
}
