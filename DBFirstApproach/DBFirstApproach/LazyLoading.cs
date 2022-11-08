using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class LazyLoading
    {
        public void SampleLazyLoading()
        {
            using(EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                Student student = context.Students.FirstOrDefault(std => std.StudentId == 1);
                Console.WriteLine($"Firstname: {student.FirstName}, Lastname: {student.LastName}");

                StudentAddress studentAddress = student.StudentAddress;
                Console.WriteLine($"AddresLin1 {studentAddress.Address1}, AddresLin2 {studentAddress.Address2}");

                Standard standard = student.Standard;
                Console.WriteLine($"StandardName: {standard.StandardName}, Description: {standard.Description}");

                var courses = student.Courses;
                foreach (var course in courses)
                {
                    Console.WriteLine($"CourseName: {course.CourseName}");
                }
            }
        }
    }
}
