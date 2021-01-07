using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    public class Program
    {

        static void main(string args[])
        {
            Employee emp1 = new Employee()
            {


                ID = 1,
                Name = "srikar",
                Gender = "Male",
                Experience = 3,
                Salary = 8000
            };
            Employee emp2 = new Employee()
            {
                ID = 2,
                Name = "SrikarP",
                Gender = "male",
                Experience = 4,
                Salary = 16000
            };
            Employee emp3 = new Employee()
            {
                ID = 3,
                Name = "Psrikar",
                Gender = "Male",
                Experience = 5,
                Salary = 20000
            };
            List<Employee> listEmployess = new List<Employee>();
            listEmployess.Add(emp1);
            listEmployess.Add(emp2);
            listEmployess.Add(emp3);
            Employee.PromoteEmployee(listEmployess, x => x.Experience > 5);
            Console.ReadKey();
        }
    }
}
