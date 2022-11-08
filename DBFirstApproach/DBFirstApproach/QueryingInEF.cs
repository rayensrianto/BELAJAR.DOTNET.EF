using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class QueryingInEF
    {
        EF_Demo_DBEntities context;

        public QueryingInEF()
        {
            context = new EF_Demo_DBEntities();
        }

        //sample LINQ-to-Entities using METHOD SYNTAX
        public void SampleOne()
        {
            var student = context.Students.FirstOrDefault(x => x.StudentId == 30);
            Console.WriteLine($"FirstName: {student?.FirstName}, LastName: {student?.LastName}");
        }

        //sample SQL Queries
        public void SampleTwo()
        {
            string sqlString = "SELECT VALUE st FROM EF_Demo_DBEntities.Students " +
                                    "AS st WHERE st.StudentId == 1";
            var objctx = (context as IObjectContextAdapter).ObjectContext;
            Student student = objctx.CreateQuery<Student>(sqlString).FirstOrDefault();

            Console.WriteLine($"SAMPLE TWO | ID: {student?.StudentId}, FirstName: {student?.FirstName}, LastName: {student?.LastName}");
        }

    }
}
