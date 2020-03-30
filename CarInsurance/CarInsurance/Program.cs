using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();
        int ageNum = Convert.ToInt16(age);

        Console.WriteLine("Have you ever had a DUI? Please respond with true or false");
        string dui = Console.ReadLine();
        bool duiAnswer = Convert.ToBoolean(dui);

        Console.WriteLine("How many speeding tickets do you have?");
        string tickets = Console.ReadLine();
        int ticketsAnswer = Convert.ToInt16(tickets);

        Console.WriteLine("Qualified?");
        Console.WriteLine( ageNum > 15 && ticketsAnswer <= 3 && !duiAnswer);
        Console.ReadLine(); 

    }
    }

