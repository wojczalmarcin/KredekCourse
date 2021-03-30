using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarcinWojczalZadDomLab6.Models;
using MarcinWojczalZadDomLab6.Models.Entities;
using AutoMapper;
using MarcinWojczalZadDomLab6.ViewModels;
using static MarcinWojczalZadDomLab6.Models.Entities.User;

namespace MarcinWojczalZadDomLab6.Controllers
{
    /// <summary>
    /// Kontroler widoku klientów
    /// </summary>
    public class CustomersController : Controller
    {
        // zmienna kontekstu bazy danych
        private readonly DataBaseContext _context;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="context"></param>
        public CustomersController(DataBaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Mapper modelu widoku klientów (CustomerViewModel)
        /// </summary>
        /// <returns></returns>
        private List<CustomerViewModel> GetCustomers()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, CustomerViewModel>();
            });
            var mapper = config.CreateMapper();
            var customers = mapper.Map<List<CustomerViewModel>>(_context.Users.Include(a => a.Address).Where(a => a.Role == ERole.CUSTOMER).ToList());
            return customers;
        }

        /// <summary>
        /// Metoda pobierająca klientów (GET) i uruchamiająca widok klientów
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        /// <summary>
        /// Metoda pobierająca klienta o zadanym ID (GET) i uruchamiająca widok szczegółów klienta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer =  GetCustomers().FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
    }
}
