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
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli FieldsOfStudy
    /// </summary>
    class FieldsOfStudiesRepository : Repository
    {
        /// <summary>
        /// Funkcja zwracająca Id kierunku, jego nazwę, oraz dane opiekuna z tabel FieldsOfStudy oraz Workers
        /// </summary>
        /// <returns></returns>
        public List<FieldOfStudyViewModel> GetFieldsOfStudies()
        {
            List<FieldOfStudy> fieldsOfStudies = DbContext.FieldsOfStudies.ToList();
            return Mapper.Map<List<FieldOfStudy>, List<FieldOfStudyViewModel>>(fieldsOfStudies);
        }
    }
}
