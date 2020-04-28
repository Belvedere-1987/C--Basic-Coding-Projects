using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            Employee<int> employee2 = new Employee<int>(); 

            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.Id = 5777;
            employee1.SayName();

            employee1.things.Add("Coffee Mug");
            employee1.things.Add("Notebook");
            employee1.things.Add("stapler");

            employee2.things.Add(3);
            employee2.things.Add(5);
            employee2.things.Add(8);

            for(int i = 0; i < employee1.things.Count(); i++)
            {
                Console.WriteLine(employee1.things[i]);
                if (i ==2)
                {  foreach(int thing in employee2.things)
                    {
                        Console.WriteLine(thing);
                    }
                }
            }
        Console.ReadLine();

        }
    }
}
