using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Employee employee6 = new Employee();
            Employee employee7 = new Employee();
            Employee employee8 = new Employee();
            Employee employee9 = new Employee();
            Employee employee10 = new Employee(); 
            List<Employee> staffingList = new List<Employee>() {employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            // Sorry step 1 is so tedious....I'm sure that there is a better way
            employee1.FirstName = "Charles";
            employee1.LastName = "Johnson";
            employee1.Id = 1;
            employee2.FirstName = "John";
            employee2.LastName = "Smith";
            employee2.Id = 2; 
            employee3.FirstName = "Bruce";
            employee3.LastName = "Wayne";
            employee3.Id = 3; 
            employee4.FirstName = "Clark";
            employee4.LastName = "Kent";
            employee4.Id = 4; 
            employee5.FirstName = "Joe";
            employee5.LastName = "Anderson";
            employee6.Id = 5;
            employee6.FirstName = "Joe";
            employee6.LastName = "Brown";
            employee6.Id = 6; 
            employee7.FirstName = "Annie";
            employee7.LastName = "Wright";
            employee7.Id = 7;
            employee8.FirstName = "Elizabeth";
            employee8.LastName = "Browning";
            employee8.Id = 8; 
            employee9.FirstName = "Natalie";
            employee9.LastName = "Lightfoot";
            employee9.Id = 9; 
            employee10.FirstName = "Sara";
            employee10.LastName = "Carrol";
            employee10.Id = 10;

            // step 2
            List<Employee> JoeList = new List<Employee>();
            foreach(Employee joe in staffingList )
            {
                if (joe.FirstName == "Joe")
                {
                    JoeList.Add(joe); 
                }
            }


            Console.WriteLine(JoeList.Count()); // Checking it's  count value to make sure that the Joe's got added. 

            // step 3
            List<Employee> JoeList2 = staffingList.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine(JoeList2.Count()); // Checking it's count value to make sure that the Joe's got added.

            // step 4 
            List<Employee> IdList = staffingList.Where(x => x.Id > 5).ToList();
            Console.WriteLine(IdList.Count()); // Cheking to make sure that the Id's over 5 were added.  
            Console.ReadLine(); 

           

        }
    }
} 