using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab6.Models.Entities
{
    /// <summary>
    /// Klasa reprezentująca typ pokoju w tabeli RoomTypes
    /// </summary>
    public class RoomType
    {
        [Key]
        public short Id { get; set; }

        [Required]
        [Display(Name = "Typ pokoju")]
        [MaxLength(50)]
        public string Type { get; set; }
        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
