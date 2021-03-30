using MarcinWojczalZadDomLab6.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarcinWojczalZadDomLab6.Models
{
    /// <summary>
    /// Kontekst bazy danych
    /// </summary>
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        //Tabele bazy danych
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
