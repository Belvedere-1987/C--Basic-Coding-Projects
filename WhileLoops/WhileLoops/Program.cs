using System;

    class Program
    {
    static void Main()
    {
        Console.WriteLine("What is the best day of the week?");
        string dayAnswer = Console.ReadLine();
        bool correctDay = dayAnswer == "Saturday";
        do
        {
            switch (dayAnswer)
            {
                case "Monday":
                    Console.WriteLine("What is wrong with you?");
                    Console.WriteLine("Try Again!");
                    dayAnswer = Console.ReadLine();
                    break;

                case "Friday":
                    Console.WriteLine("So close, but not quite right");
                    Console.WriteLine("Try Again!");
                    dayAnswer = Console.ReadLine();
                    break;

                case "Sunday":
                    Console.WriteLine("This is a good day, but too close to Monday");
                    Console.WriteLine("Try Again!");
                    dayAnswer = Console.ReadLine();
                    break;

                case "Saturday":
                    Console.WriteLine("Yeah! You got it!");
                    correctDay = true;
                    break;

                default:
                    Console.WriteLine("Why did you pick that day? Not the right answer :)");
                    Console.WriteLine("Try Again!");
                    dayAnswer = Console.ReadLine();
                    break;

            }

        }
        while (!correctDay);
        Console.WriteLine("What is the best year?");
        string yearAnswer = Console.ReadLine();
        bool rightYear = yearAnswer == "1987";

        while(!rightYear)
        {
            switch(yearAnswer)
            {
                case "2020":
                    Console.WriteLine("Uhhh......wrong answer!");
                    Console.WriteLine("Guess Again!");
                    yearAnswer = Console.ReadLine();
                    break;

                case "1990":
                    Console.WriteLine("Good guess! but no");
                    Console.WriteLine("Guess Again!");
                    yearAnswer = Console.ReadLine();
                    break;

                case "1987":
                    Console.WriteLine("You are right! Radical!");
                    Console.WriteLine("Thanks for playing!");
                    rightYear = true;
                    Console.ReadLine(); 
                    break;

                default:
                    Console.WriteLine("Not quite right. Please try again!");
                    yearAnswer = Console.ReadLine();
                    break; 
            }
        }


        }
    }

