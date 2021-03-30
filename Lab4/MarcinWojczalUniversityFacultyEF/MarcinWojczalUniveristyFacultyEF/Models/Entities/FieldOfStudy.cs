using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models.Entities
{
    public class FieldOfStudy
    {
        [Key]
        public int Id { get; set; }

        public int? PatronWorkerId { get; set; }
        [ForeignKey("PatronWorkerId")]
        public virtual Worker Worker { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
