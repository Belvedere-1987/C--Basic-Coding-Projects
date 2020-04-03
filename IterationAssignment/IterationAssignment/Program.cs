using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] nameArray = { "Randy", "Brandy", "Sandy", "Kandi" };
        Console.WriteLine("Pick a Last Name to give a family a name and press enter");
        string lastName = Console.ReadLine();
        List<string> infinityLoop = new List<string>() { "to infinity and beyond" };
        int[] numArray = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < nameArray.Length; i++)
        {
            nameArray[i] = (nameArray[i] + " " + lastName);
        }
        for (int j = 0; j < nameArray.Length; j++)
        {
            Console.WriteLine(nameArray[j]);
        }
        Console.ReadLine();

        // infinite loop step 2
        //for (int i=1; i > 0; i++)
        //{
        //    infinityLoopArray.Add("to infinity and beyond");
        //    Console.WriteLine(infinityLoopArray[i]);
        //}

        // infinite loop fixed step 3
        for (int i = 1; i > 0; i++)
        {
            infinityLoop.Add("to infinity and beyond");
            Console.WriteLine(infinityLoop[i]);
            if (i > 10)
            {
                break;
            }
        }

        // < loop operator step 4
        Console.WriteLine("\nHere are the same names all upper case");
        for (int i = 0; i < nameArray.Length; i++)
        {
            string upperName = nameArray[i].ToUpper();
            Console.WriteLine(upperName);
        }

        // <= loop operator step 5

        Console.WriteLine("\nHere are the parents in the family");
        for (int i = 0; i <= 1; i++)
        {
            Console.WriteLine(nameArray[i]);
        }

        // Step 6, 7, and 8

        List<string> colorList = new List<string>() { "black", "green", "blue", "red", "white", "yellow" };
        Console.WriteLine("\nWhat is your favorite primary color?(Please write in lower case)");
        string colorPick = Console.ReadLine();
        Console.WriteLine("\nHere is how I would rate the color");
        for (int i = 0; i < colorList.Count; i++)
        {
            if (colorPick == colorList[i])
            {
                Console.WriteLine(i);
                break; //Step 8 here....
            }
            else if (!colorList.Contains(colorPick)) //Step 7
            {
                Console.WriteLine("I'm sorry, I don't have that color ranked, maybe it's not a primary color?");
                break;
            }
        }

        // Step 9, 10 

        List<string> superBowlChamps = new List<string>() { "Chiefs", "Patriots", "Eagles", "Patriots", "Broncos" };
        Console.WriteLine("\nPick a NFL team to see how many years it has been since thy won a championship: Patriots, Eagles, Broncos, or Chiefs?");
        string teamPick = Console.ReadLine();
        for (int i = 0; i < superBowlChamps.Count; i++)
        {
            if (teamPick == superBowlChamps[i])
            {
                Console.WriteLine(i);
            }
            else if (!superBowlChamps.Contains(teamPick)) //Step 10
            {
                Console.WriteLine("I'm sorry, that team has not won a super bowl in the past five years");
                break;
            }
        }
        // Step 11
        List<string> nbaChamps = new List<string>() { "Raptors", "Warriors", "Warriors", "Cavaliers", "Warriors" };
        List<string> blankChamps = new List<string>() { };
        Console.WriteLine("\n What have the past five NBA championships looked like?);
        foreach (string team in nbaChamps)
        {
            
            if (!blankChamps.Contains(team))
                {
                blankChamps.Add(team);
                Console.WriteLine("The " + team + " have won a championship, and is on the championship list at least once");
            }
            else if (blankChamps.Contains(team))
            {
                Console.WriteLine("The " + team + " have have won multiple championships, and is on the championship list multiple times");
            }
          
        } Console.ReadLine(); 
    }  
}
       