using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarcinWojczalZadDomLab6.Models;
using MarcinWojczalZadDomLab6.Models.Entities;

namespace MarcinWojczalZadDomLab6.Controllers
{
    /// <summary>
    /// Kontroler strony rezerwacji
    /// </summary>
    public class ReservationsController : Controller
    {
        // zmienna kontekstu bazy danych
        private readonly DataBaseContext _context;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context"></param>
        public ReservationsController(DataBaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metoda pobierająca rezerwacje (GET) i uruchamiająca widok rezerwacji
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var dataBaseContext = _context.Reservations.Include(r => r.Room).Include(r => r.User);
            return View(await dataBaseContext.ToListAsync());
        }

        /// <summary>
        /// Metoda pobierająca rezerwację o zadanym ID (GET) i uruchamiająca widok szczegółów rezerwacji
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Room).ThenInclude(t => t.RoomType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        /// <summary>
        /// Metoda uruchamiająca widok dodawania rezerwacji (GET)
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewData["RoomNumber"] = new SelectList(_context.Rooms, "Number", "Number");
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "EMail");

            var prices = new List<int>();
            foreach(var type in _context.Rooms.ToList())
            {
                prices.Add(type.Price);
            }
            var numbers = new List<int>();
            foreach (var type in _context.Rooms.ToList())
            {
                numbers.Add(type.Number);
            }
            ViewData["Prices"] = prices.ToArray();
            ViewData["Numbers"] = numbers.ToArray();

            return View();
        }

        /// <summary>
        /// Metoda dodająca rezerwację do bazy (POST)
        /// </summary>
        /// <param name="reservation"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,Price,RoomNumber,CustomerId,Status")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomNumber"] = new SelectList(_context.Rooms, "Number", "Number", reservation.RoomNumber);
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "EMail", reservation.CustomerId);
            return View(reservation);
        }

        /// <summary>
        /// Metoda uruchamiająca widok edycji rezerwacji (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["RoomNumber"] = new SelectList(_context.Rooms, "Number", "Number", reservation.RoomNumber);
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "EMail", reservation.CustomerId);
            return View(reservation);
        }

        /// <summary>
        /// Metoda aktualizująca rezerwację w bazie (POST)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reservation"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,EndDate,Price,RoomNumber,CustomerId,Status")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
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
            ViewData["RoomNumber"] = new SelectList(_context.Rooms, "Number", "Number", reservation.RoomNumber);
            ViewData["CustomerId"] = new SelectList(_context.Users, "Id", "EMail", reservation.CustomerId);
            return View(reservation);
        }

        /// <summary>
        /// Metoda uruchamiająca widok usuwania rezerwacji (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Room)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        /// <summary>
        /// Metoda usuwająca rezerwację z bazy (POST)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Metoda sprawdzająca czy rezerwacja o zadanym ID istnieje (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }
}
