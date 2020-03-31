using System;

namespace PackageAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is your packages weight in lbs?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via package express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of your package?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via package express. Have a good day.");
                }
                else if (packageWidth + packageHeight + packageLength <= 50)
                {
                    Decimal quote = (Convert.ToDecimal(packageWidth * packageWeight * packageHeight * packageLength)/ 100.00M);
                    String finalQuote = quote.ToString("0.00");
                    Console.WriteLine("Your estimated quote for shipping your package is $" + finalQuote + ". Have a great day!");
                }
                Console.ReadLine();

            }
        }
    }
}
