using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarcinWojczalZadDomLab6.Models;
using MarcinWojczalZadDomLab6.Models.Entities;

namespace MarcinWojczalZadDomLab6.Controllers
{
    /// <summary>
    /// Kontroler typów pokoi
    /// </summary>
    public class RoomTypesController : Controller
    {
        // zmienna kontekstu bazy danych
        private readonly DataBaseContext _context;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context"></param>
        public RoomTypesController(DataBaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metoda pobierająca typ pokoju (GET) i uruchamiająca widok typów pokoi
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomTypes.ToListAsync());
        }

        /// <summary>
        /// Metoda uruchamiająca widok dodawania typu pokoju (GET)
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Metoda dodająca typ pokoju do bazy (POST)
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Description")] RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomType);
        }

        /// <summary>
        /// Metoda uruchamiająca widok edycji typu pokoju (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
            {
                return NotFound();
            }
            return View(roomType);
        }

        /// <summary>
        /// Metoda aktualizująca typ pokoju w bazie (POST)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roomType"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Id,Type,Description")] RoomType roomType)
        {
            if (id != roomType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomTypeExists(roomType.Id))
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
            return View(roomType);
        }

        /// <summary>
        /// Metoda uruchamiająca widok usuwania typu pokoju (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomType = await _context.RoomTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomType == null)
            {
                return NotFound();
            }

            return View(roomType);
        }

        /// <summary>
        /// Metoda usuwająca typ pokoju z bazy (POST)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Metoda sprawdzająca czy typ pokoju o zadanym ID istnieje (GET)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool RoomTypeExists(short id)
        {
            return _context.RoomTypes.Any(e => e.Id == id);
        }
    }
}
