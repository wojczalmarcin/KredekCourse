using MarcinWojczalZadDomLab7.Models.Entities;
using MarcinWojczalZadDomLab7.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : Controller
    {
        // zmienna interfejsu serwisu typów pokoi
        private IRoomTypeService _roomTypeService;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="roomService"></param>
        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        /// <summary>
        /// Zwraca wszystkie typy pokoi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _roomTypeService.Get());
        }

        /// <summary>
        /// Dodaje nowy typ pokoju
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoomType roomType)
        {
            return Ok(await _roomTypeService.Post(roomType));
        }

        /// <summary>
        /// Edutuje typ pokoju 
        /// </summary>
        /// <param name="roomType"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put([FromBody] RoomType roomType, [FromRoute] short id)
        {
            if (id != roomType.Id)
                return Conflict("Podane Id typów pokoi są różne");
            else
            {
                if (await _roomTypeService.Put(roomType, id))
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Usuwa typ pokoju o zadanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] short id)
        {
            if (await _roomTypeService.Delete(id))
                return NoContent();
            else
                return NotFound();
        }
    }
}
