using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
    
    public class Lecture
    {
        public Guid LectureId { get; set; }
        
        public string Name { get; set; }

        public List<Department> Departments { get; set; }
        public List<Student> Students { get; set; }

        public Lecture(string name)
        {
            LectureId = Guid.NewGuid();
            Name = name;
            Departments= new List<Department>();
            Students= new List<Student>();
        }
    }
}
