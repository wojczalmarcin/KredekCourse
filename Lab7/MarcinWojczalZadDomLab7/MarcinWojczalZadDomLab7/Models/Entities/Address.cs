﻿using System.ComponentModel.DataAnnotations;

namespace MarcinWojczalZadDomLab7.Models.Entities
{
    /// <summary>
    /// Klasa reprezentująca adres w tabeli Addresses
    /// </summary>
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Państwo")]
        public string Country { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [MaxLength(15)]
        [Display(Name = "Kod pocztowy")]
        public string PostCode { get; set; }

        [MaxLength(50)]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Numer")]
        public int Number { get; set; }
    }
}
