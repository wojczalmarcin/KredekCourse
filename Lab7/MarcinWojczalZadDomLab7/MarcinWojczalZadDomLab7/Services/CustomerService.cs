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
using static MarcinWojczalZadDomLab7.Models.Entities.User;

namespace MarcinWojczalZadDomLab7.Services
{
    public class CustomerService : ICustomerService
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
        public CustomerService(DataBaseContext dbContext, IMapper autoMapper)
        {
            _dbContext = dbContext;
            _autoMapper = autoMapper;
        }

        /// <summary>
        ///  Metoda zwracająca wszystkich klientów za pomocą widoku CustomerViewModel
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CustomerViewModel>> Get()
        {
            var customers = await (_dbContext.Users.Include(a => a.Address).Where(a => a.Role == ERole.CUSTOMER).ToListAsync());
            return _autoMapper.Map<IEnumerable<CustomerViewModel>>(customers);
        }
    }
}
