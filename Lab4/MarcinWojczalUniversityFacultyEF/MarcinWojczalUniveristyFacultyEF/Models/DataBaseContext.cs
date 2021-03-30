using MarcinWojczalUniversityFacultyEF.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext() : base("ConnectionString")
        {

        }
        //Tabele bazy danych
        public DbSet<Address> Addresses { get; set; }
        public DbSet<FieldOfStudy> FieldsOfStudies { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudyVintage> StudyVintages { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectGroup> SubjectGroups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudyVintage>()
                .HasOptional<Student>(s => s.Student)
                .WithMany()
                .WillCascadeOnDelete(false);
        }

    }
}
