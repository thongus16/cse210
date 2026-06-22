using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;

class Activity
{
    protected string _name; // name of the activity. should be set to a pre-defined name in the inherited constructor
    protected string _instructions; // instructions of the activity. should be set to a pre-defined value in the inherited constructor
    protected int _duration = 0; // duration of the activity. should not be set in the constructor, instead is set in Activity.Begin()

    // welcome to user and say what activity they are doing, tell them the instructions, and ask for a duration. then start the activity.
    public void Begin()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_instructions}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animate(5, "spin");
        Start();
    }

    // not meant to be used in Activity, custom functinality is set in a child class
    protected virtual void Start()
    {
        Animate(_duration, "count");
        End();
    }

    // congradulate the user for completing the activity, and return to the menu.
    protected void End()
    {
        Console.WriteLine("Well Done!!");
        Animate(5, "spin");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        Animate(5, "spin");
        Console.Clear();
    }

    // shows an animation for duration seconds. if type is "count", it will show a countdown animation. otherwise it will show a spinning animation.
    protected void Animate(int duration, string type)
    {
        Console.Write(" ");

        if (type.Equals("count"))
        {
            for (int i = 0; i < duration; i++)
            {
                for (int j = 0; j < (duration - i + 1).ToString().Length; j++)
                {
                    Console.Write("\b \b");
                }
                Console.Write($"{duration - i}");
                Thread.Sleep(1000);
            }
        } else
        {
            for (int i = 0; i < duration; i++)
            {
                Console.Write("\b|");
                Thread.Sleep(250);
                Console.Write("\b/");
                Thread.Sleep(250);
                Console.Write("\b-");
                Thread.Sleep(250);
                Console.Write("\b\\");
                Thread.Sleep(250);
            }
        }
        
        Console.Write("\b \n");
    }
}