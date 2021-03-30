using MarcinWojczalUniveristyFacultyEF.ViewModels;
using MarcinWojczalUniversityFacultyEF.Models.Entities;
using MarcinWojczalUniversityFacultyEF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MarcinWojczalUniversityFacultyEF.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli ResidencePlaces
    /// </summary>
    class AddressesRepository : Repository, IAddressesRepository
    {
        /// <summary>
        /// Funkcja zwracająca wszystkie rekordy tabeli ResidencePlaces
        /// </summary>
        /// <returns></returns>
        public List<AddressViewModel> GetAddresses()
        {
            List<Address> addresses = DbContext.Addresses.ToList();
            return Mapper.Map<List<Address>, List<AddressViewModel>>(addresses);
        }
        /// <summary>
        /// Funkcja dodająca nowy rekord miejsca zamieszkania
        /// </summary>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool AddAddress(string country, string city, string postCode, string street, int number)
        {
            Address addressToAdd = new Address()
            {
                Country = country,
                City = city,
                PostCode = postCode,
                Street = street,
                Number = number
            };
            DbContext.Addresses.Add(addressToAdd);
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Funkcja sprawdzająca czy rekord może być usunięty z bazy danych
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public int CanBeDeleted(int addressId)
        {
            foreach (Student student in DbContext.Students.ToList())
            {
                if (student.AddressId == addressId)
                    return student.Sindex;
            }
            foreach (Worker worker in DbContext.Workers.ToList())
            {
                if (worker.AddressId == addressId)
                    return worker.Id;
            }
            return 0;
        }

        /// <summary>
        /// Funkcja usuwająca rekord miejsca zamieszkania o zadanym Id
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public bool DeleteAddress(int addressId)
        {
            Address address = DbContext.Addresses.SingleOrDefault(a => a.Id == addressId);
            DbContext.Addresses.Remove(address);
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Funkcja aktualizująca rekord miejsca zamieszkania
        /// </summary>
        /// <param name="addressId"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="street"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool UpdateAddress(int addressId, string country, string city, string postCode, string street, int number)
        {
            Address address = DbContext.Addresses.SingleOrDefault(a => a.Id == addressId);
            address.Country = country;
            address.City = city;
            address.PostCode = postCode;
            address.Street = street;
            address.Number = number;

            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Funkcja zwracająca adres o zadanym Id
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address GetAddressById(int addressId)
        {
            return DbContext.Addresses.SingleOrDefault(a => a.Id == addressId);
        }
    }
}
