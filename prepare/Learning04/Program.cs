using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ass = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(ass.GetSummary());
        Console.WriteLine();

        MathAssignment mathAss = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAss.GetSummary());
        Console.WriteLine(mathAss.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writeAss = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writeAss.GetSummary());
        Console.WriteLine(writeAss.GetWritingInformation());
    }
}