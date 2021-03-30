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
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli SubjectGroups
    /// </summary>
    class SubjectGroupsRepository : Repository
    {
        /// <summary>
        /// Funkcja zwracająca Id, nazwę, przedmiot, dzień, godzinę, oraz dane prowadzącego daną grupę przedmiotową
        /// z tabel: SubjectGroups, Workers oraz Subjects
        /// </summary>
        /// <returns></returns>
        public List<SubjectGroupViewModel> GetSubjectGroups()
        {
            List<SubjectGroup> subjectGroups = DbContext.SubjectGroups.ToList();
            return Mapper.Map<List<SubjectGroup>, List<SubjectGroupViewModel>>(subjectGroups);
        }
    }
}
