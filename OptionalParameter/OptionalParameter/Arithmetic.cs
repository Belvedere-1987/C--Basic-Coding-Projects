using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    public class Arithmetic
    {
        public int combine(int input1, int input2 = 0)
        {
            int answer = input1 + input2;
            return answer;
        }
    }
}
