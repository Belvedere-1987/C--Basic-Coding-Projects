using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    public class Output
    {
        public void Seperate(int num)
        {
            int answer = num / 2;
            Console.WriteLine(answer);
        }
        public void Half(out int x)
        {
            Console.WriteLine("What is the new number you would like to divide by 2?");
            x = Convert.ToInt16(Console.ReadLine()) / 2;
        }
        public void Seperate(int num1, int num2)
        {
            int sepAnswer = num1 / num2;
            Console.WriteLine(sepAnswer);
        }

    }

    public static class Declaration
    {
        public static void declare()
        {
            Console.WriteLine("I declare that this method is static!");
        }
    }


}
