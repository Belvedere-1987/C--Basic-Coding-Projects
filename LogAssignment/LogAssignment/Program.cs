using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number? ");
           string answer = Console.ReadLine();
            using (StreamWriter log = new StreamWriter(@"C:\Users\Student\Documents\GitHub\C--Basic-Coding-Projects\LogAssignment.txt", true))
            {
                log.WriteLine(answer); 
            }
            using (StreamReader response = new StreamReader(@"C:\Users\Student\Documents\GitHub\C--Basic-Coding-Projects\LogAssignment.txt"))
            {
                string line;
                while ((line = response.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        } 
    }
}
