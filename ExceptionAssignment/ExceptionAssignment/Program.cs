using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            List<int> intList = new List<int> { 2, 4, 50, 29 };
            Console.WriteLine("Please write a whole number to divide a list of numbers by that number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < intList.Count; i++)
            {
                int Answer = intList[i] / number;
                Console.WriteLine(Answer);
            }
        }
        catch (FormatException error1)
        {
            Console.WriteLine("You recieved the following error message: " + error1 +" \nPlease type a number next time, thank you!");
        }
        catch(DivideByZeroException error2)
        {
            Console.WriteLine("You received the following error message: " + error2 + " \nPlease use a different number than zero next time, zero cannot be used a divider");
        }
        finally
        {
            Console.WriteLine("\n\nThank you for running my program! Have a good day");
        }
        Console.ReadLine(); 
    }
    
}

