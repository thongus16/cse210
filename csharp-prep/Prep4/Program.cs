using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool isDone = false;
        List<int> userList = new List<int>();
        do
        {
            Console.Write("Enter a number: ");
            int userInt = int.Parse(Console.ReadLine());
            if (userInt != 0)
            {
                userList.Add(userInt);
            }
            else
            {
                isDone = true;
            }
            
        } while(!isDone);
        int total = 0;
        int largest = userList[0];
        int smallest = userList[0];
        for (int i = 0; i < userList.Count; i++)
        {
            total += userList[i];
            if (largest < userList[i])
            {
                largest = userList[i];
            }
            if (userList[i] > 0 && smallest > userList[i])
            {
                smallest = userList[i];
            }
        }
        double mean = (double) total / userList.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {mean}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sorted list is:");
        userList.Sort();
        for (int i = 0; i < userList.Count; i++)
        {
            Console.WriteLine(userList[i]);
        }
    }
}