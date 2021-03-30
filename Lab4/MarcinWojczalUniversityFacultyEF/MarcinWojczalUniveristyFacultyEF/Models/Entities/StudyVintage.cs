using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWojczalUniversityFacultyEF.Models.Entities
{
    public class StudyVintage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int VIndex { get; set; }

        public int? YearPatronSIndex { get; set; }
        [ForeignKey("YearPatronSIndex")]
        public virtual Student Student { get; set; }

        [Required]
        public int Year { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
