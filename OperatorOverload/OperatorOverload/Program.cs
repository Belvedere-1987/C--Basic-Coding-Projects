using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee(); 
            
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.Id = 5777;
            employee1.SayName();

            employee2.FirstName = "Example";
            employee2.LastName = "Employee";
            employee2.Id = 5777;
            employee2.SayName();

            employee3.FirstName = "Charles";
            employee3.LastName = "Johnson";
            employee3.Id = 1922;
            employee3.SayName(); 

            string answer1 = Convert.ToString(employee1 == employee2);
            string answer2 = Convert.ToString(employee2 == employee3);

            Console.WriteLine("Are employees 1 and 2 the same?");
            Console.WriteLine(answer1);

            Console.WriteLine("Are employees 2 and e the same?");
            Console.WriteLine(answer2);

            Console.ReadLine();
        }
    }
}
