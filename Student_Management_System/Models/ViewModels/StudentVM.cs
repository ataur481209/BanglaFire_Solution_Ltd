using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Student_Management_System.Models.ViewModels
{
    public class StudentVM
    {
        public StudentVM()
        {
            this.Sections = new List<Section>();
        }
        [Key]
        public int StudentId { get; set; }
        [Required, StringLength(50), Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Required, Display(Name = "Date of Birth"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(20)]
        public string Class { get; set; }

        [Required]
        [StringLength(50)]
        public string Section { get; set; }
        public List<Section> Sections { get; }
    }
}