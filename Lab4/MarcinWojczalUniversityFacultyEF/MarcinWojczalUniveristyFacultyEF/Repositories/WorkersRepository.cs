using MarcinWojczalUniveristyFacultyEF.ViewModels;
using MarcinWojczalUniversityFacultyEF.Models.Entities;
using MarcinWojczalUniversityFacultyEF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Workers
    /// </summary>
    class WorkersRepository :Repository, IWorkersRepository
    {
        /// <summary>
        /// Funkcja zwracająca Id, stopień naukowy, imię, nazwisko, stanowisko oraz wynagrodzenie pracownika
        /// z tabel: Worker oraz Workplace
        /// </summary>
        /// <returns></returns>
        public List<WorkerViewModel> GetWorkers()
        {
            List<Worker> workers = DbContext.Workers.ToList();
            return Mapper.Map<List<Worker>, List<WorkerViewModel>>(workers);
        }

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
        /// <param name="addressId"></param>
        public void UpdateWorker(string firstName, string lastName, DateTime birthDate, int workPlaceId, string degree, int salary, int phoneNumber, string eMail, int addressId)
        {
            throw new NotImplementedException();
        }
    }
}
