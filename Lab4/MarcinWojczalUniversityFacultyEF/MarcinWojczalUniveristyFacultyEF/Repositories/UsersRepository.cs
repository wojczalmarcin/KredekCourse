using MarcinWojczalUniversityFacultyEF.Models.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MarcinWojczalUniversityFacultyEF.Repositories
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
            List<User> users = DbContext.Users.ToList();
            foreach(User user in users)
            {
                if (user.Password == password && user.Login == login)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Metoda sprawdzająca połączenie
        /// </summary>
        /// <returns></returns>
        public bool ConnectionExists()
        {
            try
            {
                DbContext.Database.Connection.Open();
                DbContext.Database.Connection.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
    }
}
