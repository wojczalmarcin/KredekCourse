using MarcinWojczalZadDomLab6.Models.Entities;
using System.ComponentModel.DataAnnotations;
using static MarcinWojczalZadDomLab6.Models.Entities.User;

namespace MarcinWojczalZadDomLab6.ViewModels
{
    /// <summary>
    /// Model widoku klienta
    /// </summary>
    public class CustomerViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Adres")]
        public virtual Address Address { get; set; }

        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }

        [Display(Name = "e-mail")]
        public string EMail { get; set; }

        [Display(Name = "Rola")]
        public ERole? Role { get; set; } = ERole.CUSTOMER;
    }
}
