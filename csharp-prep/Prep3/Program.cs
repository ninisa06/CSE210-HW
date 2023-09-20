using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int numberGuess = -1;

        while (number != numberGuess)
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());
            
            if (number > numberGuess)
            {
                Console.WriteLine("Higher");
            }

            else if (number < numberGuess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Correct!");
            }
        }
        
    }
}