using MarcinWojczalUniversityFacultyEF.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli ResidencePlaces
    /// </summary>
    interface IAddressesRepository
    {
        /// <summary>
        /// Abstrakcyjna funkcja dodająca miejsce zamieszkania
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        bool AddAddress(string country, string city, string postCode,string street,int number);

        /// <summary>
        /// Abstrakcyjna funkcja aktualizująca rekord miejsca zamieszkania
        /// </summary>
        /// <param name="addressId"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        bool UpdateAddress(int addressId, string country, string city, string postCode, string street, int number);

        /// <summary>
        ///  Abstrakcyjna funkcja usuwająca rekord o podanym Id
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        bool DeleteAddress(int addressId);

        /// <summary>
        /// Abstrakcyjna funkcja odpowiedzialna za walidację usuwania
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        int CanBeDeleted(int addressId);

        /// <summary>
        /// Abstrakcyjna metoda do pobierania określonych odpowiednim zapytaniem rekordów z tabeli z określonym ID
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        Address GetAddressById(int addressId);
    }
}
