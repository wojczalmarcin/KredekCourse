using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set;  }
        
        [Required]
        [MaxLength(50)]
        public string Country { get; set; }
        
        [Required]
        [MaxLength(50)]
        
        public string City { get; set; }

        [MaxLength(15)]
        public string PostCode { get; set; }

        [MaxLength(50)]
        public string Street { get; set; }
        
        [Required]
        public int Number { get; set; }
    }
}
