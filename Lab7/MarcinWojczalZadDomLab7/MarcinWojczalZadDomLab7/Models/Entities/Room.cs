using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcinWojczalZadDomLab7.Models.Entities
{
    /// <summary>
    /// Klasa reprezentująca pokój w tabeli Rooms
    /// </summary>
    public class Room
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        [Display(Name = "Numer pokoju")]
        public int Number { get; set; }

        [Required]
        [Display(Name = "Id typu pokoju")]
        public short RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        [Display(Name = "Typ pokoju")]
        public virtual RoomType RoomType { get; set; }

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