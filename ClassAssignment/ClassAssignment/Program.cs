using System;
using System.Collections.Generic;


namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would number would you like to multiply, divide, and add by 2");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.multi(input));
            Console.WriteLine(Math.divi(input));
            Console.WriteLine(Math.addi(input)); 
            Console.ReadLine(); 
        }
        public int input { get; set; }
     }
           
        
}

