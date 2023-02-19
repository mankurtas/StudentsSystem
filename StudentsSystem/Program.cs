using Microsoft.EntityFrameworkCore;
using StudentsSystem.Data;
using StudentsSystem.Menu;
using StudentsSystem.Models;

//var student = new SeedData();
//var DbContext = new StudentsContext();

var manu = new Menu();
//manu.ListDeps();

//manu.CreateDep();


//manu.InitiateMenu();
manu.ListAllDepStudents();
manu.ListAllDepLectures();
manu.ListAllStudentLectures();

//manu.InitiateMenu();
//manu.ListLectures();
//manu.selectedLecture();
//manu.ListDeps();
//manu.CreateDep();
//manu.ListDeps();

//var students = DbContext.Students.Where(x => x.Department.Name == "Science");

//foreach (var item in students)
//{
//    Console.WriteLine(item.Name);
//}

//var studentInga = DbContext.Students.Single(x=> x.PersonalCode == "49512186678");
//var studenLinas = DbContext.Students.Where(x => x.StudentId.ToString() == "d042edf5-6103-4499-917f-385d396081ca").Include(x=> x.Lectures).First();
//var studentInga = DbContext.Students.Single(x => x.PersonalCode == "49512186678");

//var studentInga = DbContext.Students.Single(x => x.PersonalCode == "49512186678");
//var studenLinas = DbContext.Students.Single(x => x.StudentId.ToString() == "d042edf5-6103-4499-917f-385d396081ca");

//studentInga.Department = DbContext.Departments.Single(x => x.Name == "Science");
//DbContext.SaveChanges();


//Console.WriteLine(studentInga.Department.Name);





//.Include(x => x.Lectures).First()
//Console.WriteLine(studenLinas.Lectures.Count());

//foreach (var item in studenLinas.Lectures)
//{
//    Console.WriteLine(item.Name);  
//}

//studenLinas.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "C++"));
//studenLinas.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "C#"));
//studentInga.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "Robotic"));
//studentInga.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "JavaScript"));
//DbContext.SaveChanges();




//DbContext.Lectures.FirstOrDefault(x => x.Name == "C#"),
//DbContext.Lectures.FirstOrDefault(x => x.Name == "Robotic"),
//DbContext.Lectures.FirstOrDefault(x => x.Name == "JavaScript")

//var Dep = DbContext.Departments.FirstOrDefault(x=> x.Name == "Computer Science");

//Dep.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "C++"));
//Dep.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "C#"));
//Dep.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "Robotic"));
//Dep.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "JavaScript"));
//Dep.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "CSS"));
//DbContext.SaveChanges();

//var studetnt = new Student("Gedas", "Medas", "g.m@gmail.com", "39512186671");
//var studetnt2 = new Student("Ieva", "Kila", "i.k@gmail.com", "49512686671");
//var studetnt3 = new Student("Jonas", "Ponas", "j.p@gmail.com", "38512686671");

//studetnt.Department = DbContext.Departments.FirstOrDefault(x => x.Name == "Computer Science");
//studetnt2.Department = DbContext.Departments.FirstOrDefault(x => x.Name == "Science");
//studetnt3.Department = DbContext.Departments.FirstOrDefault(x => x.Name == "Science");

//DbContext.Students.Add(studetnt);
//DbContext.Students.Add(studetnt2);
//DbContext.Students.Add(studetnt3);
//DbContext.SaveChanges();

//var student = DbContext.Students.First();

//student.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "C++"));
//DbContext.SaveChanges();

//foreach (var item in student.Lectures)
//{
//    Console.WriteLine(item.Name);
//}

//var studetnt = new Student("Linas", "Mikaitis", "l.m@gmail.com", "39512186678");
//studetnt.Department = DbContext.Departments.FirstOrDefault(x => x.Name == "Computer Science");
//DbContext.Students.Add(studetnt);
//DbContext.SaveChanges();

//var student = DbContext.Students.FirstOrDefault(x => x.PersonalCode == "39512186678");

//student.Lectures.Add(DbContext.Lectures.FirstOrDefault(x => x.Name == "C++"));
//DbContext.SaveChanges();

//foreach (var item in DbContext.Students)
//{
//    Console.WriteLine("Student-----");
//    Console.WriteLine(item.Name);
//    Console.WriteLine(item.Lectures.Count());
//    //foreach (var lectures in item.Lectures)
//    //{
//    //    Console.WriteLine(lectures.Name);
//    //}
//}

