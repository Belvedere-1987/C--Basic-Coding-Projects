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
      //      Console.WriteLine(timeNow.AddHours(timeMultiplier));
            DateTime otherDate = timeNow.AddHours(timeMultiplier);
            DateTime DOB = new DateTime(2001, 5, 16);

            Console.WriteLine(DOB);
            Console.WriteLine(timeNow);
            int age = 0; 
            age = timeNow.Year - DOB.Year;
            if (timeNow.Month < DOB.Month)
            { age = age - 1; }
            else if (timeNow.Month == DOB.Month||timeNow.Day < DOB.Day)
            { age = age - 1; }
            if (age <= 25)
            { Console.WriteLine(25); }
            Console.WriteLine(age);
            Console.ReadLine(); 


        }
    }
}
