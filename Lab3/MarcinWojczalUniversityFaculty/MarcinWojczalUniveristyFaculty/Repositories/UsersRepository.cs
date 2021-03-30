using System.Data.SqlClient;

namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    ///  Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Users
    /// </summary>
    class UsersRepository :Repository
    {
        /// <summary>
        /// Funkcja sprawdzająca poprawność logowania
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsLoginCorrect(string login, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Login='" + login + "' AND Password='" + password + "';";

            Connection.Open();

            SqlCommand comm = new SqlCommand(query, Connection);
            int foundUsers = (int)comm.ExecuteScalar();

            Connection.Close();

            if (foundUsers >= 1)
                return true;
            return false;
        }
    }
}
