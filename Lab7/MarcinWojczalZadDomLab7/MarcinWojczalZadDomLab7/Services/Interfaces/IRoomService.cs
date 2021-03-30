using MarcinWojczalZadDomLab7.Models.Entities;
using MarcinWojczalZadDomLab7.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Services.Interfaces
{
    /// <summary>
    /// Interfejs serwisu dla pokoi
    /// </summary>
    public interface IRoomService
    {
        /// <summary>
        /// Zwraca wszystkie pokoje
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<RoomViewModel>> Get();

        /// <summary>
        /// Dodaje pokój
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        Task<bool> Post(Room room);

        /// <summary>
        /// Edytuje pokój o zadanym numerze
        /// </summary>
        /// <param name="room"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        Task<bool> Put(Room room, int number);

        /// <summary>
        /// Usuwa pokój o zadanym numerze
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        Task<bool> Delete(int number);
    }
}
