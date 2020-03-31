    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Charlie";
            string quote = "The main said \"Hello\", Charlie. \n Hello on a new line. \n \t Hello on a new line and a new tab";
            string fileName = @"C:\Users\Student";

            bool trueOrFalse = name.Contains("l");
            trueOrFalse = name.EndsWith("Z");

            int length = name.Length;

            name = name.ToUpper();

            name = name.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Charlie");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
