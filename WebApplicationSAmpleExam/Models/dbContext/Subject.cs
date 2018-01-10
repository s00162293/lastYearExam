using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationSAmpleExam.Models.dbContext
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public virtual ICollection<Lecturer> lecturers { get; set; }

        public virtual ICollection<Student> students { get; set; }
    }
}