using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Scripture script;
        if (rand.Next(0,2) == 0)
        {
            string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowlege him, and he shall direct thy paths.";
            string book = "Proverbs";
            int chapter = 3;
            int startVerse = 5;
            int endVerse = 6;
            script = new Scripture(text, book, chapter, startVerse, endVerse);
        } else
        {
            string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            string book = "John";
            int chapter = 3;
            int verse = 16;
            script = new Scripture(text, book, chapter, verse);
        }
        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            script.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string user = Console.ReadLine();
            if (user.Equals("quit"))
            {
                quit = true;
            } else
            {
                quit = !script.HideWords(3);
            }
        }
    }
}