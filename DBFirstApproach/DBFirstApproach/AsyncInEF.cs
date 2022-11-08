using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class AsyncInEF
    {
        public static async Task<Student> GetStudentById(int StudentId)
        {
            Student student = null;

            using (var context = new EF_Demo_DBEntities())
            {
                Console.WriteLine("GetStudentById Method Started...");
                student = await (context.Students.FirstOrDefaultAsync(s => s.StudentId == StudentId));
                Console.WriteLine("GetStudentById Method Completed...");
            }

            return student;
        }
    }
}
