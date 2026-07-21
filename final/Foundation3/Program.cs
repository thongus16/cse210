using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1515 Road Rd.", "San Fran Sister", "Texas", "Taiwan");
        Lecture l1 = new Lecture("The Art of Staying Inside", "A lesson on the benefits of going insane.", "1/6/2077", "2:30pm", a1, "Peter Griftin", 6000);

        Address a2 = new Address("36590 Placment Blvd.", "New York", "Hawaii", "USA");
        Reception r1 = new Reception("Man and Women's Wedding", "Man and Women are getting married!", "6/7/1984", "11:59pm", a2, "gogetwed@wedding.com");

        Address a3 = new Address("123456789 Downthe Rd.", "Old York", "Maryland", "Germany");
        Outdoor o1 = new Outdoor("Thomas' Camp", "A short campout.", "12/25/1999", "1:00am", a3, "Snow");

        List<Event> events = new List<Event>();
        events.Add(l1);
        events.Add(r1);
        events.Add(o1);
        foreach (Event e in events)
        {
            e.DisplayStandardDetails();
            e.DisplayFullDetails();
            e.DisplayShortDescription();
            Console.WriteLine();
        }
    }
}