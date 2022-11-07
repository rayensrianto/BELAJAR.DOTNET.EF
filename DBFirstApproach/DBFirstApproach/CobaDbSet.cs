using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class CobaDbSet
    {
        EF_Demo_DBEntities context = new EF_Demo_DBEntities();

        public void AddMethod()
        {
            var student = new Student
            {
                FirstName = "Ryan",
                LastName = "Rianto",
                StandardId = 1
            };

            context.Students.Add(student);
            context.SaveChanges();
        }

        public void AddRangeMethod()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student() {FirstName = "Steven", LastName = "Gerrard", StandardId = 1},
                new Student() {FirstName = "Lionel", LastName = "Messi", StandardId = 2},
                new Student() {FirstName = "Steven", LastName = "Gerrard", StandardId = 3},
            };

            context.Students.AddRange(listStudents);
            context.SaveChanges();
        }

        public void ShowData()
        {
            List<Student> listStudents = context.Students.ToList();
            Console.WriteLine();

            foreach (Student student in listStudents)
            {
                Console.WriteLine($" Name = {student.FirstName} {student.LastName}, Email = {student.StudentAddress?.Email}, Mobile = {student.StudentAddress?.Mobile}");
            }
        }

    }
}
