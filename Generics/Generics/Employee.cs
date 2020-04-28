using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> : Person
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
        public List<T> things{ get; set; } = new List<T>();
                       
    }
}
