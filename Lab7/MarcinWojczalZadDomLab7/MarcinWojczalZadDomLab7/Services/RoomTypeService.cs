using MarcinWojczalZadDomLab7.Models;
using MarcinWojczalZadDomLab7.Models.Entities;
using MarcinWojczalZadDomLab7.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        // baza danych
        private readonly DataBaseContext _dbContext;
    
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="dbContext"></param>
        public RoomTypeService(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie typy pokoi
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<RoomType>> Get()
        {
            return await _dbContext.RoomTypes.ToListAsync();
        }

        /// <summary>
        /// Metoda usuwająca typ pokoju o zadanym Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<bool> Delete(short id)
        {
            RoomType roomType = await _dbContext.RoomTypes.FindAsync(id);
            _dbContext.RoomTypes.Remove(roomType);
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        /// <summary>
        /// Metoda dodająca typ pokoju
        /// </summary>
        /// <param name="roomTypes"></param>
        /// <returns></returns>
        public async Task<bool> Post(RoomType roomType)
        {
            await _dbContext.RoomTypes.AddAsync(roomType);
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        /// <summary>
        /// Metoda aktualizująca typ pokoju o zadanym Id
        /// </summary>
        /// <param name="roomType"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Put(RoomType roomType, short id)
        {
            RoomType typeToUpdate = await _dbContext.RoomTypes.FindAsync(id);
            if (typeToUpdate == null)
                return false;
            typeToUpdate.Type = roomType.Type;
            typeToUpdate.Description = roomType.Description;

            return (await _dbContext.SaveChangesAsync()) > 0;
        }
    }
}
