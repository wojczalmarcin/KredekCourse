using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;


namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Students
    /// </summary>
    class StudyVintagesRepository : Repository, IBasicRepositoryFunctions
    {
        /// <summary>
        /// Funkcja zwracająca indeks, rok oraz dane opiekuna roku z tabel StudyVintages oraz Students
        /// </summary>
        /// <returns></returns>
        public DataTable GetRepository()
        {
            string query = "SELECT VIndex as 'Indeks', Year as 'Rok rozpoczęcia', Students.FirstName as 'Imię opiekuna', Students.LastName as 'Nazwisko opiekuna' "+
                " FROM StudyVintages JOIN Students ON StudyVintages.YearPatronSIndex = Students.SIndex;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; throw new NotImplementedException();
        }
    }
}
