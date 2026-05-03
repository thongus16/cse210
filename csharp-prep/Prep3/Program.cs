using System;

class Program
{
    static void Main(string[] args)
    {
        bool isDone = false;
        do
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(0, 101);
            int guessAmount = 0;
            bool isCorrect = false;
            do
            {
                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                guessAmount++;
                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                } else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                } else
                {
                    Console.WriteLine($"You guessed it! It took you {guessAmount} guesses.");
                    isCorrect = true;
                }
            } while (!isCorrect);
            Console.Write("Would you like to play again? ");
            string replay = Console.ReadLine();
            if (replay.Equals("no"))
            {
                isDone = true;
            }
        } while (!isDone);
    }
}