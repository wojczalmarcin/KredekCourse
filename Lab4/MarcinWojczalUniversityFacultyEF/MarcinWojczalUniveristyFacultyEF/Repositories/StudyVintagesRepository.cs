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
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Students
    /// </summary>
    class StudyVintagesRepository : Repository
    {
        /// <summary>
        /// Funkcja zwracająca indeks, rok oraz dane opiekuna roku z tabel StudyVintages oraz Students
        /// </summary>
        /// <returns></returns>
        public List<StudyVintageViewModel> GetStudyVintages()
        {
            List<StudyVintage> StudyVintages = DbContext.StudyVintages.ToList();
            return Mapper.Map<List<StudyVintage>, List<StudyVintageViewModel>>(StudyVintages);
        }
    }
}
