using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class CobaDbContext
    {
        public CobaDbContext()
        {
            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<Student> listStudents = DBEntities.Students.ToList();
                Console.WriteLine();

                foreach (Student student in listStudents)
                {
                    Console.WriteLine($" Name = {student.FirstName} {student.LastName}, Email = {student.StudentAddress?.Email}, Mobile = {student.StudentAddress?.Mobile}");
                }

            }

            //add new entity
            using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                var student = new Student
                {
                    FirstName = "Naruto",
                    LastName = "Uzumaki",
                    StandardId = 1
                };

                context.Students.Add(student);
                context.SaveChanges();

                List<Student> listStudents = context.Students.ToList();
                foreach (Student std in listStudents)
                {
                    Console.WriteLine($"StudentID: {std.StudentId} Name = {std.FirstName} {std.LastName}");
                }
            }

            //update entity
            using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                var student = context.Students.FirstOrDefault(x => x.StudentId == 5);

                if (student != null)
                {
                    student.FirstName = "Darmaji";
                    student.LastName = "Patrio";
                    context.SaveChanges();
                }

                List<Student> listStudents = context.Students.ToList();
                foreach (Student std in listStudents)
                {
                    Console.WriteLine($"StudentID: {std.StudentId} Name = {std.FirstName} {std.LastName}");
                }
            }

            //delete entity
            using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                var student = context.Students.FirstOrDefault(x => x.StudentId == 5);

                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }

                List<Student> listStudents = context.Students.ToList();
                foreach (Student std in listStudents)
                {
                    Console.WriteLine($"StudentID: {std.StudentId} Name = {std.FirstName} {std.LastName}");
                }
            }

            //coba delete entity lebih dari satu
            using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                List<Student> students = context.Students.ToList();

                if (students != null)
                {
                    context.Students.RemoveRange(students.Where(x => x.StudentId > 5));
                    context.SaveChanges();
                }

                List<Student> listStudents = context.Students.ToList();
                foreach (Student std in listStudents)
                {
                    Console.WriteLine($"StudentID: {std.StudentId} Name = {std.FirstName} {std.LastName}");
                }
            }
        }
    }
}
