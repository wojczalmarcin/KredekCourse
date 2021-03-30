using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Workplaces
    /// </summary>
    class WorkplacesRepository : Repository, IBasicRepositoryFunctions
    {
        /// <summary>
        /// Funkcja zwracająca wszystkie rekordy tabeli Workplaces
        /// </summary>
        /// <returns></returns>
        public DataTable GetRepository()
        {
            string query = "SELECT Id, Name as 'Nazwa', BaseSalary as 'Płaca minimalna' FROM Workplaces;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; throw new NotImplementedException();
        }
    }
}
