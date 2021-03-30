using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;


namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli SubjectGroups
    /// </summary>
    class SubjectGroupsRepository : Repository, IBasicRepositoryFunctions
    {
        /// <summary>
        /// Funkcja zwracająca Id, nazwę, przedmiot, dzień, godzinę, oraz dane prowadzącego daną grupę przedmiotową
        /// z tabel: SubjectGroups, Workers oraz Subjects
        /// </summary>
        /// <returns></returns>
        public DataTable GetRepository()
        {
            string query = "SELECT SubjectGroups.Id,SubjectGroups.Name as 'Nazwa', Subjects.Name as 'Przedmiot', DayOfWeek as 'Dzień', Hour as 'Godzina',"+
                           "Workers.Degree as 'Prowadzący:', Workers.FirstName as 'Imię', Workers.LastName as 'Nazwisko' " +
                            "FROM SubjectGroups "+
                            "JOIN Workers ON Workers.Id = SubjectGroups.WorkerId "+
                            "JOIN Subjects ON Subjects.Id = SubjectGroups.SubjectId; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; throw new NotImplementedException();
        }
    }
}
