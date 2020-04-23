using System;

namespace MathandClasses
{
    class Program
    {
        static void Main()
    {
        Modifier modifier = new Modifier();
        Console.WriteLine(modifier.execute(3));
        Console.WriteLine(modifier.execute(2.75m, 0));
        Console.WriteLine(modifier.execute("250", "blank", "blank"));             
        Console.ReadLine();
    }
}
}


