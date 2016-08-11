using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Student")]
    public class StudentModel
    {
        [Key]
        public int StudentID { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        [StringLength(10)]
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        [StringLength(int.MaxValue)]
        public string About { get; set; }
        public bool isDeleted { get; set; } = false;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}