using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal userJ = new Journal();

        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How was your rest last night?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        bool isDone = false;
        while (!isDone)
        {
            bool isParsed = true;
            int intAct = 0;
            do
            {
                Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
                if (isParsed)
                {
                    Console.Write("What would you like to do? ");
                } else
                {
                    Console.Write("Not an option. Please try again. ");
                }
                string userAct = Console.ReadLine();
                isParsed = int.TryParse(userAct, out intAct);
                if (isParsed)
                {
                    if (intAct > 5 || intAct < 1)
                    {
                        isParsed = false;
                    }
                }
            } while (!isParsed);
            if (intAct == 1)
            {
                Random rand = new Random();
                int num = rand.Next(0, prompts.Count);
                string userResponse = "";
                bool checkPassed = false;
                while (!checkPassed)
                {
                    Console.Write($"{prompts[num]}\n> ");
                    userResponse = Console.ReadLine();
                    if (userResponse.Contains("|"))
                    {
                        Console.WriteLine("\"|\" is not allowed. Please try again.");
                    } else
                    {
                        checkPassed = true;
                    }
                }
                
                Entry userE = new Entry();
                userE._prompt = prompts[num];
                userE._response = userResponse;
                userE._date = DateTime.Now.ToShortDateString();
                userJ.AddEntry(userE);
            } else if (intAct == 2)
            {
                userJ.Display();
            } else if (intAct == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                userJ.LoadJournal(file);
            } else if (intAct == 4)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                userJ.SaveJournal(file);
            } else if (intAct == 5)
            {
                isDone = true;
            }
        }
    }
}