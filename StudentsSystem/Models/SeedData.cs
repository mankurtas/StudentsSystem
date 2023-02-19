using StudentsSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Models
{
    public class SeedData
    {
        public SeedData()
        {
            var context = new StudentsContext();
            context.Lectures.AddRange(
                new Lecture("Math"),
                new Lecture("Phisics"),
                new Lecture("English"),
                new Lecture("C++"),
                new Lecture("C#"),
                new Lecture("Chemistry"),
                new Lecture("Robotic"),
                new Lecture("Spanish"),
                new Lecture("German"),
                new Lecture("JavaScript"),
                new Lecture("CSS")
                );
            context.Departments.AddRange(
                new Department("Science"),
                new Department("Computer Science"),
                new Department("Languages")
                );
            context.SaveChanges();
        }
    }
}
