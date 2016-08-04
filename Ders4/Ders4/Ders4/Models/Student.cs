using SQLite.Net.Attributes;
using System;

namespace Ders4.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}