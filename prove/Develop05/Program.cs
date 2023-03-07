using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        while (true)
        {
            Console.Clear();
            string answer = Menu();
            switch (answer)
            {
                case "1":
                    string choice = GoalsMenu();
                    RunChoice(choice, goals);
                    break;
                case "2":
                    DisplayList(goals);
                    Thread.Sleep(4000);
                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":
                    Console.WriteLine("Thanks  for using our program!");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Error, please enter a valid choice.");
                    Thread.Sleep(3000);
                    break;
            }
        }
    }

    public static string Menu()
    {
        Console.WriteLine("Menu options:");
        Console.WriteLine("   1: Create new goal\n   2: List Goals\n   3: Save goals\n   4: Load goals\n   5: Record event \n   6: Quit");
        return Console.ReadLine();
    }

    public static string GoalsMenu()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("   1: Simple goal\n   2: Eternal Goal\n   3: Checklist goal");
        return Console.ReadLine();
    }

    public static void RunChoice(string x, List<Goal> goals)
    {
        Console.Clear();

        if (x == "1")
        {
            SimpleGoal g1 = new SimpleGoal("", "", 0, false);
            g1.CreateGoal();
            goals.Add(g1);
        }
        else if (x == "2")
        {
            EternalGoal g2 = new EternalGoal("", "", 0, false);
            g2.CreateGoal();
            goals.Add(g2);
        }
        else if (x == "3")
        {
            ChecklistGoal g3 = new ChecklistGoal("", "", 0, false);
            g3.CreateGoal();
            goals.Add(g3);
        }
        else { }

    }

    public static void DisplayList(List<Goal> goals)
    {
        foreach (Goal s in goals)
        {
            Console.WriteLine(s);
        }
    }
}