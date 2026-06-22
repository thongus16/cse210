class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _instructions = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // _duration is set to a multiple of 10, rounding up. the user will breath in for 4 seconds and out for 6 seconds.
    protected override void Start()
    {
        _duration = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(_duration) / 10)) * 10;
        Console.WriteLine();
        for (int i = 0; i < _duration; i += 10)
        {
            Console.Write("Breath in...");
            Animate(4, "count");
            Console.Write("Now breath out...");
            Animate(6, "count");
            Console.WriteLine();
        }
        End();
    }
}