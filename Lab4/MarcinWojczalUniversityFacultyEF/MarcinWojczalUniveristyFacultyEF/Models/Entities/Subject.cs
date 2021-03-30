using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models.Entities
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int FieldOfStudyId { get; set; }
        [ForeignKey("FieldOfStudyId")]
        public virtual FieldOfStudy FieldOfStudy { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public short Term { get; set; }

        [Required]
        public short ECTS { get; set; }

        public virtual ICollection<SubjectGroup> SubjectGroups { get; set; }
    }
}
