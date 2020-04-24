using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
    static void Main(string[] args)
        {
            Output output = new Output();
            Console.WriteLine("Give me a number to divide in half");
            int num1 = Convert.ToInt32(Console.ReadLine());
            output.Seperate(num1);
            Console.WriteLine("Here is the same result using output parameters ");
            output.Half(out int answer);
            Console.WriteLine(answer);
            Console.WriteLine("Here is the same result using an overloaded method, What is the new number you would like to divide by 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            output.Seperate(num2, 2);
            Declaration.declare(); 
            Console.ReadLine();
        }
        
    }
}
