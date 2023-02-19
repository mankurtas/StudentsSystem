using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
   
    public class Student
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PersonalCode { get; set; }
        [ForeignKey("Department")]
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Lecture> Lectures { get; set; }

        public Student(string name, string surname, string email, string personalCode)
        {
            StudentId = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Email = email;
            PersonalCode = personalCode;
            Lectures= new List<Lecture>();
        }
    }
}
