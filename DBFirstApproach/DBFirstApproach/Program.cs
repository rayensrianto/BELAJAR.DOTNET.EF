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
            
            CobaDbSet runCobaDbSet = new CobaDbSet();
            runCobaDbSet.AddMethod();
            runCobaDbSet.AddRangeMethod();
            runCobaDbSet.ShowData();

            Console.ReadKey();

        }
    }
}
