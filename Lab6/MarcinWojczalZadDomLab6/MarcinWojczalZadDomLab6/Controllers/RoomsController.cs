using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarcinWojczalZadDomLab6.Models;
using MarcinWojczalZadDomLab6.Models.Entities;
using MarcinWojczalZadDomLab6.ViewModels;
using AutoMapper;

namespace MarcinWojczalZadDomLab6.Controllers
{
    /// <summary>
    /// Kontroler pokoi
    /// </summary>
    public class RoomsController : Controller
    {
        // zmienna kontekstu bazy danych
        private readonly DataBaseContext _context;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context"></param>
        public RoomsController(DataBaseContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Mapper modelu widoku pokoi (RoomsViewModel)
        /// </summary>
        /// <returns></returns>
        private List<RoomViewModel> GetRooms()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Room, RoomViewModel>()
                .ForMember(dest => dest.RoomType, opt => opt.MapFrom(src => src.RoomType.Type));
            });
            var mapper = config.CreateMapper();

            return mapper.ProjectTo<RoomViewModel>(_context.Rooms).ToList();
        }

        /// <summary>
        /// Metoda pobierająca model widoku pokoi (GET) i uruchamiająca widok pokoi
        /// </summary>
        /// <param name="sortOrder"></param>
        /// <returns></returns>
        public IActionResult Index(string sortOrder)
        {
            ViewData["NumberSortParm"] = String.IsNullOrEmpty(sortOrder) ? "number_desc" : "";
            ViewData["TypeSortParm"] = sortOrder == "type" ? "type_desc" : "type";
            ViewData["SizeSortParm"] = sortOrder == "size" ? "size_desc" : "size";
            ViewData["BalconySortParm"] = sortOrder == "balcony" ? "balcony_desc" : "balcony";
            ViewData["PriceSortParm"] = sortOrder == "price" ? "price_desc" : "price";
            var rooms = from r in GetRooms() select r;
            switch (sortOrder)
            {
                case "type":
                    rooms = rooms.OrderBy(r => r.RoomType);
                    break;
                case "type_desc":
                    rooms = rooms.OrderByDescending(r => r.RoomType);
                    break;
                case "size":
                    rooms = rooms.OrderBy(r => r.Size);
                    break;
                case "size_desc":
                    rooms = rooms.OrderByDescending(r => r.Size);
                    break;
                case "balcony":
                    rooms = rooms.OrderBy(r => r.Balcony);
                    break;
                case "balcony_desc":
                    rooms = rooms.OrderByDescending(r => r.Balcony);
                    break;
                case "price":
                    rooms = rooms.OrderBy(r => r.Price);
                    break;
                case "price_desc":
                    rooms = rooms.OrderByDescending(r => r.Price);
                    break;
                case "number_desc":
                    rooms = rooms.OrderByDescending(r => r.Number);
                    break;
                default:
                    rooms = rooms.OrderBy(r => r.Number);
                    break;
            }
            return View(rooms);
        }

        /// <summary>
        /// Metoda pobierająca pokój o zadanym ID (GET) i uruchamiająca widok szczegółów pokoju
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.Number == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        /// <summary>
        /// Metoda uruchamiająca widok dodawania pokoju (GET)
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Type");
            return View();
        }

        /// <summary>
        /// Metoda dodająca pokój do bazy (POST)
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Number,RoomTypeId,Size,Balcony,Price")] Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Type", room.RoomTypeId);
            return View(room);
        }

        /// <summary>
        /// Metoda uruchamiająca widok edycji pokoju (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Type", room.RoomTypeId);
            return View(room);
        }

        /// <summary>
        /// Metoda aktualizująca pokój w bazie (POST)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Number,RoomTypeId,Size,Balcony,Price")] Room room)
        {
            if (id != room.Number)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.Number))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "Id", "Type", room.RoomTypeId);
            return View(room);
        }

        /// <summary>
        /// Metoda uruchamiająca widok usuwania pokoju (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.Number == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        /// <summary>
        /// Metoda usuwająca pokój z bazy (POST)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Metoda sprawdzająca czy pokój o zadanym ID istnieje (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool RoomExists(int id)
        {
            return _context.Rooms.Any(e => e.Number == id);
        }
    }
}
