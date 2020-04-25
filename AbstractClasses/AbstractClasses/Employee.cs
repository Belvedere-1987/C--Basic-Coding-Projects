using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee : Person
    {
                int Id { get; set; }
        public override void SayName()
        {
            base.SayName();
            Console.WriteLine("This is being printed from the Employee Class");   
        }

    }
}
