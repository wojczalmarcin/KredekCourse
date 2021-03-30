using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models.Entities
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Sindex { get; set; }

        [Required]
        public int FieldOfStudyId { get; set; }
        [ForeignKey("FieldOfStudyId")]
        public virtual FieldOfStudy FieldOfStudy { get; set; }

        [Required]
        public int StudyVintageIndex { get; set; }
        [ForeignKey("StudyVintageIndex")]
        public virtual StudyVintage StudyVintage { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(11)]
        public string Pesel { get; set; }

        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        [Required]
        public short ECTSDeficit { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string EMail { get; set; }
    }
}
