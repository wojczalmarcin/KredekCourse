using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models.Entities
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        
        [Required]
        public int WorkPlaceId { get; set; }
        [ForeignKey("WorkPlaceId")]
        public virtual Workplace Workplace { get; set; }

        [MaxLength(50)]
        public string Degree { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string EMail { get; set; }

        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        public virtual ICollection<SubjectGroup> SubjectGroups { get; set; }
    }
}
