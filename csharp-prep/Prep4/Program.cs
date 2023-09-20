using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string numberEntry = Console.ReadLine();
            userNumber = int.Parse(numberEntry);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
        }

        int sumNumbers = 0;
        foreach (int number in numbers)
        {
            sumNumbers += number;
        }

        int amountOfNumbers = numbers.Count;
        float average = ((float)sumNumbers) / amountOfNumbers;

        int largestNumber = 0;
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {sumNumbers}");      
        Console.WriteLine($"The average is: {average}");  
        Console.WriteLine($"The largest number is: {largestNumber}");

       

    }
}