using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Naming naming = new Naming();
            naming.update(12, 50);
            naming.update(num2: 36, num1: 30);
            Console.ReadLine(); 
        }
    }
}
