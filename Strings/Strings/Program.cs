    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Charlie";
            string quote = "The main said \"Hello\", Charlie. \n Hello on a new line. \n \t Hello on a new line and a new tab";
            string fileName = @"C:\Users\Student";

            bool trueOrFalse = name.Contains("l");
            trueOrFalse = name.EndsWith("Z");

            int length = name.Length;

            name = name.ToUpper();

            name = name.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Charlie");


            Console.WriteLine(sb);
            Console.ReadLine();

            List<string> nbaChamps = new List<string>() { "Raptors", "Warriors", "Spurs","Warriors", "Cavaliers", "Warriors" };
            StringBuilder champChecker = new StringBuilder();
            Console.WriteLine("\n Which of these NBA teams have won multiple championships in the past five years?: Raptors,Cavaliers, Warriors,Spurs?");
            foreach (string team in nbaChamps)
            {
                champChecker.Append(team);
                string champs = champChecker.ToString();
                string duplicate = team + team;
                if (champs.Contains(duplicate))
                {
                    Console.WriteLine(duplicate);               
                        }
            }
            Console.ReadLine();
        }
    }
}
