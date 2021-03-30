using System.Data.SqlClient;

namespace MarcinWojczalUniversityFaculty.Repositories
{
    public abstract class Repository
    {
        protected readonly SqlConnection Connection;

        protected Repository()
        {
            //Inicjalizacja połączenia z bazą danych
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}
