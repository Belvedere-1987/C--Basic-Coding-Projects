using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current day of the week?");
            string userDay = Console.ReadLine();
            try
            {
                Days day = (Days)Enum.Parse(typeof(Days), userDay);
                if (day == Days.Friday || day == Days.Saturday || day == Days.Sunday)
                {
                    Console.WriteLine("it's the weekend!");
                }
                else
                {
                    Console.WriteLine("It's the weekday.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please write a day of the week. You wrote: " + userDay + "\nYou received the following message: " + ex.Message);
            }
            Console.ReadLine(); 
           
        }
    }
}
