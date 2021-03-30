using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcinWojczalZadDomLab6.Models.Entities
{
    /// <summary>
    /// Klasa reprezentująca rezerwację w tabeli Reservations
    /// </summary>
    public class Reservation
    {
        public enum EStatus
        {
            [Display(Name = "Nieopłacony")]
            UNPAID,
            [Display(Name = "Opłacony")]
            PAID
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data rozpoczęcia")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data końca")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Numer pokoju")]
        public int RoomNumber { get; set; }

        [Display(Name = "Numer pokoju")]
        [ForeignKey("RoomNumber")]
        public virtual Room Room { get; set; }

        [Required]
        [Display(Name = "Id klienta")]
        public int CustomerId { get; set; }

        [Display(Name = "Klient")]
        [ForeignKey("CustomerId")]
        public virtual User User { get; set; }

        [Required]
        public EStatus Status { get; set; }
    }
}
