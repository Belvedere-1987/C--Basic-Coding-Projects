using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAssignment
{
    class Combine
    {

        public Combine(): this(2,2)
        {
            Console.WriteLine("this should be right now");
        }
        public Combine(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine(answer);
            
        }
    }
}
