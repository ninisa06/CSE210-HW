using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradeAnswer = Console.ReadLine();
        int percentGrade = int.Parse(gradeAnswer);

        string letter = "";

        if (percentGrade >= 90)
            {
                letter = "A";
            }
        else if (percentGrade >= 80)
            {
                letter = "B";
            }
        else if (percentGrade >= 70)
            {
                letter = "C";
            }
        else if (percentGrade >= 60)
            {
                letter = "D";
            }
        else if (percentGrade < 60)
            {
                letter = "F";
            }

        Console.WriteLine ($"Your grade is: {letter}");

        if (percentGrade >= 70)
            {
                Console.WriteLine("You passed. Congratulations!");
            }
        else 
            {
                Console.WriteLine("Keep studying, you'll do better next time.");
            }

    }
}