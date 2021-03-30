using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcinWojczalZadDomLab6.Models.Entities
{
    /// <summary>
    /// Klasa reprezentująca użytkownika w tabeli Users
    /// </summary>
    public class User
    {
        public enum ERole
        {
            EMPLOYEE, 
            CUSTOMER, 
            ADMIN
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Id adresu")]
        public int? AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "e-mail")]
        public string EMail { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Rola")]
        public ERole? Role { get; set; }
    }
}
