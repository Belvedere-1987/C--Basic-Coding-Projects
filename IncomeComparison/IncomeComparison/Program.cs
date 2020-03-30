using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate");
        int hourlyRatePerson1 = 22;
        Console.WriteLine(hourlyRatePerson1);
        Console.WriteLine("Hours Worked");
        int hoursWorkedPerson1 = 40;
        Console.WriteLine(hoursWorkedPerson1);
        
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate");
        int hourlyRatePerson2 = 18;
        Console.WriteLine(hourlyRatePerson2);
        Console.WriteLine("Hours Worked");
        int hoursWorkedPerson2 = 50;
        Console.WriteLine(hoursWorkedPerson2);

        Console.WriteLine("Annual Salary of Person 1");
        int annualSalary1 = hourlyRatePerson1 * hoursWorkedPerson1 * 52; 
        Console.WriteLine(annualSalary1);

        Console.WriteLine("Annual Salary of Person 2");
        int annualSalary2 = hourlyRatePerson2 * hoursWorkedPerson2 * 52;
        Console.WriteLine(annualSalary2);

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool wageCompare = annualSalary1 > annualSalary2; 
        Console.WriteLine(wageCompare);
        Console.ReadLine(); 


    }
    }
