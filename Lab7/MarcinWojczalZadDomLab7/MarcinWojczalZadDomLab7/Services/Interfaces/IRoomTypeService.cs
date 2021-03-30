using MarcinWojczalZadDomLab7.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Services.Interfaces
{
    /// <summary>
    /// Interfejs serwisu dla typów pokoi
    /// </summary>
    public interface IRoomTypeService
    {
        /// <summary>
        /// Zwraca wszystkie typy pokoi
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<RoomType>> Get();

        /// <summary>
        /// Dodaje typ pokoju
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        Task<bool> Post(RoomType roomType);

        /// <summary>
        /// Edytuje typ pokoju o zadanym Id
        /// </summary>
        /// <param name="roomType"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<bool> Put(RoomType roomType, short Id);

        /// <summary>
        /// Usuwa typ pokoju o zadanym Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<bool> Delete(short Id);
    }
}
