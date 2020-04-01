using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        string[] stringArray = { "Black Sabbath", "Iron Maiden", "Metallica", "Slayer", "Death" };

        Console.WriteLine("Please pick a number between 0 and 4 to see the history of Metal Music");
        int bandPick = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(stringArray[bandPick]);
        Console.ReadLine();

        int[] numArray = { 0, 2, 4, 8, 16, 32, 64, 128, 256 };
        Console.WriteLine("Please pick a number between 0 and 8 to see two to the power of that number");
        int numberPick = Convert.ToInt16(Console.ReadLine());
        if (numberPick > 8)
        {
            Console.WriteLine("I'm sorry you picked a number greater than 8, you must select a number between 0 and 8. Please press enter to close this app");
            Console.ReadLine();
            Environment.Exit(0); 

        }
        else if (numberPick < 0)
        {
            Console.WriteLine("I'm sorry you picked a number less than 0, please select a number between 0 and 8. Please press enter to close this app");             
            Console.ReadLine();
            Environment.Exit(0);
        }
        else
        Console.WriteLine(numArray[numberPick]);
        Console.ReadLine();

        List<string> stringList = new List<string> { "Chuck Berry", "Elvis Presley", "The Beatles", "Jimi Hendrix", "Led Zeppelin", "Van Halen", "Nirvana", "Foo Fighters" };
        Console.WriteLine("Please pick a number between 0 and 7 to see the history of Rock Music");
        int artistPick = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(stringList[artistPick]);
        Console.ReadLine(); 
    }
}
