using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            base.SayName();
            Console.WriteLine("This is being printed from the Employee Class");
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");

        }

        public static bool operator == (Employee first, Employee second)
        {
        bool status = false;
            if (first.Id == second.Id)
            {
                status = true;
            }
            return status;
        }

        public static bool operator != (Employee first, Employee second)
        {
            bool status = false; 
            if (first.Id != second.Id)
            {
                status = true;
            }
            return status;
        }
    }
}
