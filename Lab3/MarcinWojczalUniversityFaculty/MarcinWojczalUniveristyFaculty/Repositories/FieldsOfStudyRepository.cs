using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli FieldsOfStudy
    /// </summary>
    class FieldsOfStudyRepository : Repository, IBasicRepositoryFunctions
    {
        /// <summary>
        /// Funkcja zwracająca Id kierunku, jego nazwę, oraz dane opiekuna z tabel FieldsOfStudy oraz Workers
        /// </summary>
        /// <returns></returns>
        public DataTable GetRepository()
        {
            string query = "SELECT FieldsOfStudy.Id as 'Id', Name as 'Nazwa' , "+
                "Workers.Degree as 'Stopień opiekuna',Workers.FirstName as 'Imię opiekuna',"+
                " Workers.LastName as 'Nazwisko opiekuna' FROM FieldsOfStudy JOIN Workers ON "+
                "FieldsOfStudy.PatronWorkerId = Workers.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
