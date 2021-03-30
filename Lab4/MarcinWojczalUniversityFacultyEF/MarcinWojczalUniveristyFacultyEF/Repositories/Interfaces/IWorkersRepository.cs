using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Workers
    /// </summary>
    interface IWorkersRepository
    {
        /// <summary>
        /// Abstrakcyjna funkcja dodająca pracownika
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
        void AddWorker(string firstName, string lastName, DateTime birthDate, int workPlaceId, string degree, int salary,int phoneNumber,string eMail,int residencePlaceId);

        /// <summary>
        /// Abstrakcyjna funkcja usuwająca rekord pracownika o podanym Id
        /// </summary>
        /// <param name="workerId"></param>
        void DeleteWorker(int workerId);

        /// <summary>
        /// Abstrakcyjna funkcja aktualizująca rekord pracownika
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
        void UpdateWorker(string firstName, string lastName, DateTime birthDate, int workPlaceId, string degree, int salary, int phoneNumber, string eMail, int addressId);
    }
}
