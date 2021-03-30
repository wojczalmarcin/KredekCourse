using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli ResidencePlaces
    /// </summary>
    class ResidencePlacesRepository : Repository, IResidencePlacesRepository, IBasicRepositoryFunctions
    {
        /// <summary>
        /// Funkcja dodająca nowy rekord miejsca zamieszkania
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        public void AddResidencePlace(string country, string city, string postCode, string street, int number)
        {
            Connection.Open();

            string insertStudentsQuery = "INSERT INTO ResidencePlaces VALUES ('"+country+"','"+city+"','"+postCode+"','"+street+"'," + number + "); ";
            SqlCommand commandInsertStudent = new SqlCommand(insertStudentsQuery, Connection);
            commandInsertStudent.ExecuteNonQuery();

            Connection.Close();
        }
        /// <summary>
        /// Funkcja sprawdzająca czy rekord może być usunięty z bazy danych
        /// </summary>
        /// <param name="residencePlaceId"></param>
        /// <returns></returns>
        public bool CanBeDeleted(int residencePlaceId)
        {
            string query = "SELECT ResidencePlaceId FROM Students WHERE ResidencePlaceId = " + residencePlaceId 
                + " UNION SELECT ResidencePlaceId FROM Workers WHERE ResidencePlaceId = " + residencePlaceId + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table == null || table.Rows.Count == 0)
                return true;
            return false;

        }

        /// <summary>
        /// Funkcja usuwająca rekord miejsca zamieszkania o zadanym Id
        /// </summary>
        /// <param name="residencePlaceId"></param>
        public void DeleteResidencePlace(int residencePlaceId)
        {
            string queryDeleteStudent = "DELETE FROM ResidencePlaces WHERE Id=" + residencePlaceId + ";";

            Connection.Open();

            SqlCommand commandDeleteStudent = new SqlCommand(queryDeleteStudent, Connection);
            commandDeleteStudent.ExecuteNonQuery();

            Connection.Close();
        }
        /// <summary>
        /// Funkcja zwracająca wszystkie rekordy tabeli ResidencePlaces
        /// </summary>
        /// <returns></returns>
        public DataTable GetRepository()
        {
            string query = "SELECT Id, Country as 'Kraj', City as 'Miasto', PostCode as 'Kod pocztowy', Street as 'Ulica', Number as 'Numer' FROM ResidencePlaces;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /// <summary>
        /// Funkcja zwracająca tabelę z rekordem o określonym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetRepositoryById(int id)
        {
            string query = "SELECT* FROM ResidencePlaces WHERE Id = " + id + ";" ;
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Funkcja aktualizująca rekord miejsca zamieszkania
        /// </summary>
        /// <param name="residencePlaceId"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        public void UpdateResidencePlace(int residencePlaceId, string country, string city, string postCode, string street, int number)
        {
            Connection.Open();

            string insertStudentsQuery = "UPDATE ResidencePlaces SET Country ='" + country +
                "',City='" + city + "',PostCode='" + postCode + "',Street='" + street +
                "',number=" + number + "WHERE Id=" + residencePlaceId + ";";
            SqlCommand commandInsertStudent = new SqlCommand(insertStudentsQuery, Connection);
            commandInsertStudent.ExecuteNonQuery();

            Connection.Close();
        }
    }
}
