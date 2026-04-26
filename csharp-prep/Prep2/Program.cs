using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        if (grade >= 90)
        {
            letter = "an A";
        }
        else if (grade >= 80)
        {
            letter = "a B";
        }
        else if (grade >= 70)
        {
            letter = "a C";
        }
        else if (grade >= 60)
        {
            letter = "a D";
        }
        else
        {
            letter = "an F";
        }
        string sign = "";
        if (grade >= 60 && grade < 90 && grade % 10 >= 7)
        {
            sign = "+";
        }
        else if (grade >= 60 && grade % 10 < 3)
        {
            sign = "-";
        }
        Console.WriteLine($"You got {letter}{sign}.");
        if (grade > 70)
        {
            Console.WriteLine("Congratulations, you passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed.");
        }
    }
}