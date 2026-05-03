using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string named = PromptUserName();
        int cube = SquareNumber(PromptUserNumber());
        int birth;
        PromtUserBirthYear(out birth);
        DisplayResult(named, cube, birth);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromtUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int x)
    {
        return x * x;
    }

    static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
}