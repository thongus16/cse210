using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3,4);
        Fraction frac4 = new Fraction(1,3);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetTop());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetTop());
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());

        Fraction testFrac = new Fraction();
        Random rand = new Random();
        for(int i = 0; i < 20; i++)
        {
            testFrac.SetTop(rand.Next(1,10));
            testFrac.SetBottom(rand.Next(1,10));
            Console.WriteLine($"Fraction {i + 1}: string: {testFrac.GetFractionString()} Number: {testFrac.GetDecimalValue()}");
        }
    }
}
