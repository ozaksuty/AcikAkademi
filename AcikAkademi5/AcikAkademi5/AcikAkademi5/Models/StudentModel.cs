using System;

namespace AcikAkademi5.Models
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string About { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
