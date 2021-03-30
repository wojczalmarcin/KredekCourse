using MarcinWojczalZadDomLab7.Models.Entities;
using MarcinWojczalZadDomLab7.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        // zmienna interfejsu serwisu pokoi
        private IRoomService _roomService;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="roomService"></param>
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        /// <summary>
        /// Zwraca widok pokoi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _roomService.Get());
        }

        /// <summary>
        /// Dodaje nowy pokój
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Room room)
        {
            return Ok(await _roomService.Post(room));
        }

        /// <summary>
        /// Edutuje pokój 
        /// </summary>
        /// <param name="room"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{number}")]
        public async Task<IActionResult> Put([FromBody] Room room, [FromRoute] int number)
        {
            if (number != room.Number)
                return Conflict("Podane numery pokoi są różne");
            else
            {
                if (await _roomService.Put(room, number))
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Usuwa pokój o zadanym numerze
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{number}")]
        public async Task<IActionResult> Delete([FromRoute] int number)
        {
            if (await _roomService.Delete(number))
                return NoContent();
            else
                return NotFound();
        }
    }
}
