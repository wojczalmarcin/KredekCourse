using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models.Entities
{
    public class SubjectGroup
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        [Required]
        public int WorkerId { get; set; }
        [ForeignKey("WorkerId")]
        public virtual Worker Worker { get; set; }

        [Required]
        [MaxLength(20)]
        public string DayOfWeek { get; set; }

        [Required]
        [MaxLength(6)]
        public string Hour { get; set; }

        [Required]
        public int StudentsNumber { get; set; }
        
        [Required]
        public int MaxStudentsNumber { get; set; }
       
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
