using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFaculty.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli ResidencePlaces
    /// </summary>
    interface IResidencePlacesRepository
    {
        /// <summary>
        /// Abstrakcyjna funkcja dodająca miejsce zamieszkania
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        void AddResidencePlace(string country, string city, string postCode,string street,int number);

        /// <summary>
        /// Abstrakcyjna funkcja aktualizująca rekord miejsca zamieszkania
        /// </summary>
        /// <param name="residencePlaceId"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        void UpdateResidencePlace(int residencePlaceId,string country, string city, string postCode, string street, int number);

        /// <summary>
        /// Abstrakcyjna funkcja usuwająca rekord o podanym Id
        /// </summary>
        /// <param name="residencePlaceId"></param>
        void DeleteResidencePlace(int residencePlaceId);

        /// <summary>
        /// Abstrakcyjna funkcja odpowiedzialna za walidację usuwania
        /// </summary>
        /// <param name="residencePlaceId"></param>
        /// <returns></returns>
        bool CanBeDeleted(int residencePlaceId);

        /// <summary>
        /// Abstrakcyjna metoda do pobierania określonych odpowiednim zapytaniem rekordów z tabeli z określonym ID
        /// </summary>
        /// <returns></returns>
        DataTable GetRepositoryById(int id);
    }
}
