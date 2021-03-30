using AutoMapper;
using MarcinWojczalZadDomLab7.Models;
using MarcinWojczalZadDomLab7.Models.Entities;
using MarcinWojczalZadDomLab7.Services.Interfaces;
using MarcinWojczalZadDomLab7.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Services
{
    public class RoomService : IRoomService
    {
        // baza danych
        private readonly DataBaseContext _dbContext;
        // mapper
        private readonly IMapper _autoMapper;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="autoMapper"></param>
        public RoomService(DataBaseContext dbContext, IMapper autoMapper)
        {
            _dbContext = dbContext;
            _autoMapper = autoMapper;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie pokoje za pomocą widoku RoomViewModel
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<RoomViewModel>> Get()
        {
            var rooms = await _dbContext.Rooms.Include(t => t.RoomType).ToListAsync();
            return _autoMapper.Map<IEnumerable<RoomViewModel>>(rooms);
        }

        /// <summary>
        /// Metoda usuwająca pokój o zadanym numerze
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public async Task<bool> Delete(int number)
        {
            Room room = await _dbContext.Rooms.FindAsync(number);
            _dbContext.Rooms.Remove(room);
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        /// <summary>
        /// Metoda dodająca pokój
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public async Task<bool> Post(Room room)
        {
            await _dbContext.Rooms.AddAsync(room);
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        /// <summary>
        /// Metoda aktualizująca pokój o zadanym numerze
        /// </summary>
        /// <param name="room"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public async Task<bool> Put(Room room, int number)
        {
            Room roomToUpdate = await _dbContext.Rooms.FindAsync(number);
            if (roomToUpdate == null)
                return false;
            roomToUpdate.RoomTypeId = room.RoomTypeId;
            roomToUpdate.Size = room.Size;
            roomToUpdate.Balcony = room.Balcony;
            roomToUpdate.Price = room.Price;

            return (await _dbContext.SaveChangesAsync()) > 0;
        }
    }
}
