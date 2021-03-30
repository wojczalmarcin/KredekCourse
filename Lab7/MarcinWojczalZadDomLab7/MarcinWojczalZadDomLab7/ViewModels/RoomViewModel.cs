using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.ViewModels
{
    /// <summary>
    /// Model widoku pokoju
    /// </summary>
    public class RoomViewModel
    {
        [Display(Name = "Numer pokoju")]
        public int Number { get; set; }

        [Display(Name = "Typ pokoju")]
        public string RoomType { get; set; }

        [Required]
        [Display(Name = "Wielkość [os]")]
        public short Size { get; set; }

        [Required]
        [Display(Name = "Balkon")]
        public bool Balcony { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public int Price { get; set; }
    }
}
