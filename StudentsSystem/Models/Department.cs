using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
    
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Lecture> Lectures { get; set; }

        public Department(string name)
        {   
            DepartmentId = Guid.NewGuid();
            Name = name;
            Students = new List<Student>();
            Lectures= new List<Lecture>();
        }
    }
}
