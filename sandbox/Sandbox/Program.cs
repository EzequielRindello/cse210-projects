using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter a goal or type 'exit' to quit:");
            string input = Console.ReadLine();

            if (input == "exit")
            {
                break;
            }

            goals.Add(input);
        }

        Console.WriteLine("\nYour Goals:");
        foreach (string goal in goals)
        {
            Console.WriteLine(goal);
        }

        Console.WriteLine("\nMark your completed goals (enter the number):");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }

        while (true)
        {
            Console.Write("\nSelect a goal to mark as complete: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index) && index >= 1 && index <= goals.Count)
            {
                goals[index - 1] += " (completed)";
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        Console.WriteLine("\nYour Goals:");
        foreach (string goal in goals)
        {
            Console.WriteLine(goal);
        }
    }
}
