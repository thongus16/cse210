using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int localPoints = 0;
        List<SimpleGoal> goals = new List<SimpleGoal>();
        bool isDone = false;
        while (!isDone)
        {
            if (localPoints == 1)
            {
                Console.WriteLine($"You have {localPoints} point.\n");
            } else
            {
                Console.WriteLine($"You have {localPoints} points.\n");
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuInput = Console.ReadLine();
            if (menuInput == "1")
            {
                bool isDone1 = false;
                while (!isDone1)
                {
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goal1Input = Console.ReadLine();
                    if (goal1Input == "1")
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDesc = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalPoints = int.Parse(Console.ReadLine());
                        SimpleGoal newGoal = new SimpleGoal(goalName, goalDesc, goalPoints, false);
                        goals.Add(newGoal);
                        isDone1 = true;
                    } else if (goal1Input == "2")
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDesc = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalPoints = int.Parse(Console.ReadLine());
                        SimpleGoal newGoal = new EternalGoal(goalName, goalDesc, goalPoints, false);
                        goals.Add(newGoal);
                        isDone1 = true;
                    } else if (goal1Input == "3")
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDesc = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalPoints = int.Parse(Console.ReadLine());
                        Console.Write("How many times does the goal need to be accomplished for a bonus? ");
                        int goalNum = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int goalBonus = int.Parse(Console.ReadLine());
                        SimpleGoal newGoal = new CheckGoal(goalName, goalDesc, goalPoints, false, goalBonus, 0, goalNum);
                        goals.Add(newGoal);
                        isDone1 = true;
                    } else
                    {
                        Console.WriteLine("Not an option. Please try again.");
                    }
                }
                Console.WriteLine();
            } else if (menuInput == "2")
            {
                Console.WriteLine("The goals are:");
                foreach(SimpleGoal iGoal in goals)
                {
                    Console.WriteLine(iGoal.GetDisplayString());
                }
                Console.WriteLine();
            } else if (menuInput == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(localPoints);
                    foreach(SimpleGoal iGoal in goals)
                    {
                        outputFile.WriteLine(iGoal.GetSaveString());
                    }
                }
                Console.WriteLine();
            } else if (menuInput == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                localPoints = int.Parse(lines[0]);
                goals = new List<SimpleGoal>();
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] parts = lines[i].Split(":");

                    string goalType = parts[0];
                    string[] goalInfo = parts[1].Split("|");
                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal newGoal = new SimpleGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), bool.Parse(goalInfo[3]));
                        goals.Add(newGoal);
                    } else if (goalType == "EternalGoal")
                    {
                        SimpleGoal newGoal = new EternalGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), bool.Parse(goalInfo[3]));
                        goals.Add(newGoal);
                    } else if (goalType == "CheckGoal")
                    {
                        SimpleGoal newGoal = new CheckGoal(goalInfo[0], goalInfo[1], int.Parse(goalInfo[2]), bool.Parse(goalInfo[3]), int.Parse(goalInfo[4]), int.Parse(goalInfo[5]), int.Parse(goalInfo[6]));
                        goals.Add(newGoal);
                    }
                }
                Console.WriteLine();
            } else if (menuInput == "5")
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetTitle()}");
                }
                Console.Write("Which goal did you accomplish? ");
                int compGoal = int.Parse(Console.ReadLine()) - 1;
                int compPoints = goals[compGoal].Complete();
                Console.WriteLine($"Congratulations! You have earned {compPoints} points!\n");
                localPoints += compPoints;
                Console.WriteLine($"You now have {localPoints} points.\n");
            } else if (menuInput == "6")
            {
                isDone = true;
            } else
            {
                Console.WriteLine("Not an option. Please try again.");
            }
        }
    }
}