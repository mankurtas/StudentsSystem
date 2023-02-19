using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using StudentsSystem.Data;
using StudentsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Menu
{
    public class Menu
    {
        private StudentsContext DbContext { get; set; }
        public Menu() {
            DbContext = new StudentsContext();
        }
        public void InitiateMenu()
        {
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("-----------------------\n");
                Console.WriteLine("1. Create Department");
                Console.WriteLine("2. Create Lecture");
                Console.WriteLine("3. Create Student");
                Console.WriteLine("4. Change Dep For Student");
                Console.WriteLine("0. Exit");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CreateDep();                       

                        break;
                    case "2":
                        CreateLecture();

                        break;
                    case "3":
                        CreateStudet();
                        break;
                    case "4":
                        var stu = GetStudent();
                        AssigneDep(stu);
                        DbContext.SaveChanges();
                        break;
                    case "0":
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Incorret input");
                        break;
                }
            }
        }
        public void CreateDep(){
            Console.WriteLine("Enter Name of Department");
            string depname = Console.ReadLine();
            var dep = new Department(depname);
            AddLectureFromDB(dep);
            DbContext.Departments.Add(dep);
            DbContext.SaveChanges();
        }
        public void CreateLecture()
        {
            Console.WriteLine("Enter Name of Lecture");
            string lecturename = Console.ReadLine();
            var lecture = new Lecture(lecturename);
            DbContext.Lectures.Add(lecture);
            DbContext.SaveChanges();
        }
        public void CreateStudet()
        {
            Console.WriteLine("Enter Name");
            string stuName = Console.ReadLine();
            Console.WriteLine("Enter SurName");
            string stuSurName = Console.ReadLine();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Personal Code");
            string personalCode = Console.ReadLine();
            
            var student = new Student(stuName,stuSurName,email, personalCode);
            AssigneDep(student);
            
            DbContext.Students.Add(student);
            DbContext.SaveChanges();

        }
        public void ListLectures()
        {
            int i = 1;
            var lectures = DbContext.Lectures;
            foreach (var item in lectures)
            {
                Console.WriteLine(i + ". " + item.Name);
                i++;                
            }
        }
       
      
        public void ListDeps()
        {
            int i = 1;
            var deps = DbContext.Departments.Include(x=> x.Lectures);
            foreach (var item in deps)
            {
                Console.WriteLine(i + ". " + item.Name);
                foreach (var lecture in item.Lectures)
                {
                    Console.WriteLine(lecture.Name);
                }
               
                i++;
            }
        }
        public void AddLectureFromDB(Department dep)
        {
            ListLectures();
            Console.WriteLine("Select Lecture from DB to add to DEP or 0 to exit");
            int selection = Convert.ToInt32(Console.ReadLine());
            
            while (selection !=0) {
                
                var lecture = DbContext.Lectures.AsEnumerable().ElementAtOrDefault(selection - 1); 
                dep.Lectures.Add(lecture);
                Console.WriteLine("Added, select one more or 0 to exit");
                selection = Convert.ToInt32(Console.ReadLine());
            }           
            
        }
        public void AssigneDep(Student stu) 
        {
            ListDeps();
            Console.WriteLine("Select Department");
            int selection = Convert.ToInt32(Console.ReadLine());
            var dep = DbContext.Departments.AsEnumerable().ElementAtOrDefault(selection - 1);
            stu.Department = dep;
            stu.Lectures.Clear();
            stu.Lectures.AddRange(dep.Lectures);
        }
        public Student GetStudent()
        {
            int i = 1;
            var students = DbContext.Students.Include(x => x.Department).Include(x=> x.Lectures).ToList();
            foreach (var item in students)
            {
                Console.WriteLine(i +". " + item.Name + " " + item.Surname + " " + "--> Dep " +  item.Department.Name);
                i++;
            }
            Console.WriteLine("Select Student");
            int selection = Convert.ToInt32(Console.ReadLine());

            return students.ElementAtOrDefault(selection - 1);

        }
        public void ListAllDepStudents()
        {
            var dep = DbContext.Departments.Include(x => x.Students);
            foreach (var item in dep)
            {
                Console.WriteLine("----Department-> " + item.Name + "<----");
                Console.WriteLine("----Students----");
                foreach (var stud in item.Students)
                {
                    Console.WriteLine("# " + stud.Name + " " + stud.Surname);
                }
            }
        }
        public void ListAllDepLectures()
        {
            var dep = DbContext.Departments.Include(x => x.Lectures);
            foreach (var item in dep)
            {
                Console.WriteLine("----Department-> " + item.Name + "<----");
                Console.WriteLine("----Lectures----");
                foreach (var lecture in item.Lectures)
                {
                    Console.WriteLine("# " + lecture.Name);
                }
            }
        }
        public void ListAllStudentLectures()
        {
            Console.WriteLine("Enter Student Name");
            string Name = Console.ReadLine();
            var student = DbContext.Students.Include(x => x.Lectures).Where(x=> x.Name == Name).SingleOrDefault();
            Console.WriteLine("----Lectures----");
            foreach (var item in student.Lectures)
            {
                Console.WriteLine("# " + item.Name);
            }
        }
    }
}
