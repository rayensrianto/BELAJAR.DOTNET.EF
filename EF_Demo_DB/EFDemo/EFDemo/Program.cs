using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<Department> listDepartments = DBEntities.Departments.ToList();
                Console.WriteLine();
                foreach (Department dept in listDepartments)
                {
                    Console.WriteLine("  Department = {0}, Location = {1}", dept.Name, dept.Location);
                    foreach (Employee emp in dept.Employees)
                    {
                        Console.WriteLine("\t Name = {0}, Email = {1}, Gender = {2}, salary = {3}",
                            emp.Name, emp.Email, emp.Gender, emp.Salary);
                    }

                    Console.WriteLine();
                }

                var employee = DBEntities.Employees.Find(1);
                var employeeType = ObjectContext.GetObjectType(employee.GetType());
                Console.WriteLine("FullName of Employee Master Type :" + employeeType.FullName);

                Console.ReadKey();
            }
        }
    }
}