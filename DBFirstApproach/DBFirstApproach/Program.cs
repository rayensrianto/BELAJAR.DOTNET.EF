using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            //CobaDbContext runCobaDbContext = new CobaDbContext();

            //CobaDbSet runCobaDbSet = new CobaDbSet();
            //runCobaDbSet.AddMethod();
            //runCobaDbSet.AddRangeMethod();
            //runCobaDbSet.AttachMethod();
            //runCobaDbSet.AddRangeMethod();
            //runCobaDbSet.ShowData();

            //QueryingInEF queryingInEF = new QueryingInEF();
            //queryingInEF.SampleOne();
            //queryingInEF.SampleTwo();

            //EagerLoading eagerLoading = new EagerLoading();
            //eagerLoading.SampleOne();

            //LazyLoading lazyLoading = new LazyLoading();
            //lazyLoading.SampleLazyLoading();

            var query = AsyncInEF.GetStudentById(1);
            Console.WriteLine("Doing some other tasks");
            var student = query.Result;
            Console.WriteLine($"Name: {student?.FirstName} {student?.LastName}");

            Console.ReadKey();

        }
    }
}
