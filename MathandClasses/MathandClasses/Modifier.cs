using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandClasses
{
    public class Modifier
    {
        public int execute(int input)
        {
            int hundoAns = input + 100;
            return hundoAns;
        }
        public int execute(decimal input2, decimal blank = 0)
        {
            int roundUp = Convert.ToInt32(input2 + 3);
            return roundUp;
        }
        public int execute(string input3, string placeholder1 = "blank", string placeholder2 = "blank")
        {
            int number = Convert.ToInt32(input3) / 2;
            return number;
        }
    }
}