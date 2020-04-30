using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int math = 4;
            Console.WriteLine("2 + 2 = " + math);
            Console.WriteLine("2 + 3 = " + math);
            var Wrong = "something is wrong";
            Console.WriteLine(Wrong);
            Combine adder = new Combine();
            Console.WriteLine(adder); 
            Console.ReadLine(); 
        }
    }
}
