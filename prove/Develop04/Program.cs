using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // prompts for reflection activity
        List<string> reflecPrompts =
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        ];
        // questions for reflection activity
        List<string> reflecQuest = 
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        // prompts for listing activity
        List<string> listPrompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];

        // create activities
        Breathing breath = new();
        Reflection refec = new(reflecPrompts, reflecQuest);
        Listing listin = new(listPrompts);

        // loop until user quits
        bool isDone = false;
        while (!isDone)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflection activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                // start breathing activity
                breath.Begin();
            } else if (response == 2)
            {
                // start reflection activity
                refec.Begin();
            } else if (response == 3)
            {
                // start listing activity
                listin.Begin();
            } else if (response == 4)
            {
                // end the program
                isDone = true;
            } else
            {
                // show an error and try again
                Console.Clear();
                Console.WriteLine("Not an option. Please try again.\n");
            }
        }
    }
}