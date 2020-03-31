using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
        string firstName = "Charles";
        string midName = "Robert";
        string lastName = "Johnson";
        string fullName = firstName + " " + midName + " " + lastName;
        Console.WriteLine(fullName);
        
        string upper = fullName.ToUpper();
        Console.WriteLine(upper);
        
        StringBuilder tolkien = new StringBuilder();

        tolkien.Append("\"I wish it need not happen in my time.\"");
        tolkien.Append("said,Frodo.");
        tolkien.Append("\n \"So do I\", said Gandalf,\"and so do all who live to see such times.");
        tolkien.Append("\n But that is not for them to decide.");
        tolkien.Append(" All we have to decide is what to do with the time that is given us\".");

        Console.WriteLine(tolkien);
        Console.ReadLine(); 

        }
    }

