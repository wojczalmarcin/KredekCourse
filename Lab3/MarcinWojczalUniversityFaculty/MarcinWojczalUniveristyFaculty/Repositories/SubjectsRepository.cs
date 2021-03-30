using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Subjects
    /// </summary>
    class SubjectsRepository : Repository, IBasicRepositoryFunctions
    {
        /// <summary>
        /// Funkcja zwracająca Id, nazwę kierunku, nazwę , semestr, oraz liczbę ECTS danego przedmiotu
        /// z tabel Subjects oraz FieldsOfStudy
        /// </summary>
        /// <returns></returns>
        public DataTable GetRepository()
        {
            string query = "SELECT Subjects.Id, FieldsOfStudy.Name as 'Kierunek', Subjects.Name as 'Przedmiot', Term as 'Semestr', ECTS FROM Subjects JOIN FieldsOfStudy ON FieldsOfStudy.Id = Subjects.FieldOfStudyId;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; throw new NotImplementedException();
        }
    }
}
