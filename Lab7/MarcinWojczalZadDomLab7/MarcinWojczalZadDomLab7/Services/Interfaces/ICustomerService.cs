using MarcinWojczalZadDomLab7.Models.Entities;
using MarcinWojczalZadDomLab7.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Services.Interfaces
{
    /// <summary>
    /// Interfejs serwisu dla klientów
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// Zwraca wszystkich klientów za pomocą widoku CustomerViewModel
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<CustomerViewModel>> Get();
    }
}
