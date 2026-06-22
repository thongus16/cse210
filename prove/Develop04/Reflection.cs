class Reflection : Activity
{
    private readonly List<string> _prompts; // a list of prompts
    private readonly List<string> _questions; // a list of questions.

    public Reflection(List<string> promtps, List<string> questions)
    {
        _name = "Reflection";
        _instructions = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = promtps;
        _questions = questions;
    }

    // _duration is set to an even number, rounded up. shows a random prompt, then 2 random questions. each question will remain for _duration / 2 seconds.
    protected override void Start()
    {
        _duration = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(_duration) / 2)) * 2;
        Random rand = new();
        string prompt = _prompts[rand.Next(0, _prompts.Count)];
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to that experience.");
        Console.Write("You may begin in: ");
        Animate(5, "count");
        Console.Clear();
        List<string> usedQuest = _questions;
        for(int i = 0; i < 2; i++)
        {
            int index = rand.Next(0, usedQuest.Count);
            Console.Write($"> {usedQuest[index]} ");
            usedQuest.RemoveAt(index);
            Animate(_duration / 2, "spin");
        }
        Console.WriteLine();
        End();
    }
}