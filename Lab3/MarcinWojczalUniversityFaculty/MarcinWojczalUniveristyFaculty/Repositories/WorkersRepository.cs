using MarcinWojczalUniversityFaculty.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MarcinWojczalUniversityFaculty.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Workers
    /// </summary>
    class WorkersRepository :Repository, IWorkersRepository, IBasicRepositoryFunctions
    {
        /// <summary>
        /// Funkcja dodająca nowego pracownika do tabeli Workers
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="workPlaceId"></param>
        /// <param name="degree"></param>
        /// <param name="salary"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="eMail"></param>
        /// <param name="residencePlaceId"></param>
        public void AddWorker(string firstName, string lastName, DateTime birthDate, int workPlaceId, string degree, int salary, int phoneNumber, string eMail, int residencePlaceId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Funkcja usuwająca pracownika o zadanym Id
        /// </summary>
        /// <param name="workerId"></param>
        public void DeleteWorker(int workerId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Funkcja zwracająca Id, stopień naukowy, imię, nazwisko, stanowisko oraz wynagrodzenie pracownika
        /// z tabel: Worker oraz Workplace
        /// </summary>
        /// <returns></returns>
        public DataTable GetRepository()
        {
            string query = "SELECT Workers.Id, Degree as 'Stopień',LastName as 'Nazwisko',FirstName as 'Imię', Workplaces.Name as 'Stanowisko',Salary as 'Wynagrodzenie' FROM Workers JOIN Workplaces ON Workers.WorkplaceId = Workplaces.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        /// <summary>
        /// Funkcja aktualizująca danego pracownika
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="workPlaceId"></param>
        /// <param name="degree"></param>
        /// <param name="salary"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="eMail"></param>
        /// <param name="residencePlaceId"></param>
        public void UpdateWorker(string firstName, string lastName, DateTime birthDate, int workPlaceId, string degree, int salary, int phoneNumber, string eMail, int residencePlaceId)
        {
            throw new NotImplementedException();
        }
    }
}
