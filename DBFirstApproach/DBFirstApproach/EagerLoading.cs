using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class EagerLoading
    {
        EF_Demo_DBEntities context;

        public EagerLoading()
        {
            context = new EF_Demo_DBEntities();
        }

        //Eager Loading with Linq Method Syntax
        public void SampleOne()
        {
            var students = context.Students.Include("Standard").ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"Sample One | ID: {student?.StudentId}, Firstname: {student.FirstName}, Lastname: {student.LastName}, StandardName: {student.Standard.StandardName}, Description: {student.Standard.Description}");
            }
        }
    }
}
