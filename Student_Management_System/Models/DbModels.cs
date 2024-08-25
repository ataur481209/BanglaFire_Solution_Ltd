using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student_Management_System.Models
{
    public class Student
    {
        public Student()
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
        //nev
        public ICollection<Section> Sections { get; set; }
    }
    public class Class
    {
        public Class()
        {
            this.Sections = new List<Section>();

        }
        public int ClassId { get; set; }
        [Required, StringLength(20), Display(Name = "Class Name")]
        public string ClassName { get; set; }
        //nev
        public ICollection<Section> Sections { get; set; }
    }
    public class Section
    {
        public int SectionId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        //nev
        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}