using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   DateTime timeNow = DateTime.Now; 
            Console.WriteLine(timeNow);
            Console.WriteLine("Type a number!");
            int timeMultiplier = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(timeNow.AddHours(timeMultiplier)); 
                        
            Console.ReadLine(); 

        }
    }
}
