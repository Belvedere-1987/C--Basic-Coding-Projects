using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            Console.WriteLine("It's time to do some math! Give me two numbers to add together. \nIf no second number is included, the number will be added by 0");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int optionalInput2;
            int finalInput;
            if(int.TryParse(Console.ReadLine(), out optionalInput2))
            {
                finalInput = arithmetic.combine(input1, optionalInput2);
            }
            else
            {
                finalInput = arithmetic.combine(input1);
            }

            Console.WriteLine(finalInput);
            Console.ReadLine(); 
                  }
    }
    }
