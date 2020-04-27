using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
        public class Employee : Person, IQuittable
        {
            int Id { get; set; }
            public override void SayName()
            {
                base.SayName();
                Console.WriteLine("This is being printed from the Employee Class");
            }

            public void Quit()
            {
            Console.WriteLine("I quit!");


            }
        }
}
