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
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Subjects
    /// </summary>
    class SubjectsRepository : Repository
    {
        /// <summary>
        /// Funkcja zwracająca Id, nazwę kierunku, nazwę , semestr, oraz liczbę ECTS danego przedmiotu
        /// z tabel Subjects oraz FieldsOfStudy
        /// </summary>
        /// <returns></returns>
        public List<SubjectViewModel> GetSubjects()
        {
            List<Subject> subjects = DbContext.Subjects.ToList();
            return Mapper.Map<List<Subject>, List<SubjectViewModel>>(subjects);
        }
    }
}
