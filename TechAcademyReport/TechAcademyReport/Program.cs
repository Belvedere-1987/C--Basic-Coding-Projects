using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            string helpAnswer = Console.ReadLine();
            bool helpBln = Convert.ToBoolean(helpAnswer);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursWorked = Console.ReadLine();
            int hoursWorkedNum = Convert.ToInt32(hoursWorked);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
