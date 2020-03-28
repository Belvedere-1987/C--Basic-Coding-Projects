using System;

    class Program
    {
        static void Main()
       {
        Console.WriteLine("Please Input a number you would like multiplied by 50 and then press enter");
        string multiFifty = Console.ReadLine();
        double multiFiftyNum = (Convert.ToDouble(multiFifty) * 50);
        Console.WriteLine(multiFiftyNum);
        
        Console.WriteLine("Please Input a number you would like to add 25 to and then press enter");
        string addTwentyFive = Console.ReadLine();
        int addTwentyFiveNum = (Convert.ToInt32(addTwentyFive) + 25);
        Console.WriteLine(addTwentyFiveNum);
        
        Console.WriteLine("Please Input a number you would like to divide by 12.5 to and then press enter");
        string divide = Console.ReadLine();
        double divideNum = Convert.ToInt64(divide)/12.5;
        Console.WriteLine(divideNum);
        
        Console.WriteLine("Please Input a number you would like to check to see if it's greater than 50 and then press enter");
        string greaterThanFifty = Console.ReadLine();
        int greaterThanFiftyNum = Convert.ToInt32(greaterThanFifty);
        bool greaterThanAnswer = greaterThanFiftyNum > 50;
        Console.WriteLine(greaterThanAnswer);        

        Console.WriteLine("Please Input a number to divide by 7 to see it's remainder and then press enter");
        string remainder = Console.ReadLine();
        int remainderNum = Convert.ToInt32(remainder) % 7;
        Console.WriteLine(remainderNum);
        Console.ReadLine();
    }
    }

