class Listing : Activity
{
    private List<string> _prompts; // a list of prompts

    public Listing(List<string> prompts)
    {
        _name = "Listing";
        _instructions = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = prompts;
    }

    // show the user a random prompt. then let the user enter answers for _duration seconds. when a answer is submitted after the time has expired, show how many answers were submitted and end the activty.
    protected override void Start()
    {
        Random rand = new();
        string prompt = _prompts[rand.Next(0, _prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        Animate(5, "count");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        int count = 0;
        bool isDone = false;
        while (!isDone)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
            if (DateTime.Now > futureTime)
            {
                isDone = true;
            }
        }
        Console.WriteLine($"You listed {count} times!\n");
        End();
    }
}