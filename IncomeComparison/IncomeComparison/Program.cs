using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        string hourlyRatePerson1 = Console.ReadLine();
        int hourlyRateNumPerson1 = Convert.ToInt16(hourlyRatePerson1);
        Console.WriteLine("Hours Worked?");
        string hoursWorkedPerson1 = Console.ReadLine();
        int hoursWorkedNumPerson1 = Convert.ToInt16(hoursWorkedPerson1);
                
        
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        string hourlyRatePerson2 = Console.ReadLine();
        int hourlyRateNumPerson2 = Convert.ToInt16(hourlyRatePerson2);
        Console.WriteLine("Hours Worked?");
        string hoursWorkedPerson2 = Console.ReadLine();
        int hoursWorkedNumPerson2 = Convert.ToInt16(hoursWorkedPerson2);
        
        Console.WriteLine("Annual Salary of Person 1");
        int annualSalary1 = hourlyRateNumPerson1 * hoursWorkedNumPerson1 * 52; 
        Console.WriteLine(annualSalary1);

        Console.WriteLine("Annual Salary of Person 2");
        int annualSalary2 = hourlyRateNumPerson2 * hoursWorkedNumPerson2 * 52;
        Console.WriteLine(annualSalary2);

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool wageCompare = annualSalary1 > annualSalary2; 
        Console.WriteLine(wageCompare);
        Console.ReadLine(); 


    }
    }
