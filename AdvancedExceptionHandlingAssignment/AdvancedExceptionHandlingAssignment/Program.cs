using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age? ");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge == 0)
                {
                    throw new ZeroException(); 
                }
                if (userAge < 0)
                {
                    throw new NegException();
                }

                DateTime currentYear = DateTime.Now;
                int userBirth = currentYear.Year - userAge;
                Console.WriteLine(userBirth);
            }
            catch(ZeroException)
            {
                Console.WriteLine("You put a zero, next time please enter a positive whole integer instead. ");
                Console.ReadLine();
                return; 
            }
            catch (NegException)
            {
                Console.WriteLine("You put a negative number,next time please enter a whole positive integer instead. ");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong! Please enter a postive whole integer next time");
                Console.ReadLine();
                return; 
            }
            Console.ReadLine(); 
        }
    }
}
