using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new  List<string>();

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
                    SaveLoad option1 = new SaveLoad(goals);
                    option1.DisplayList();
                    Console.WriteLine("Please enter any key to continue.");
                    Console.ReadKey();
                    break;
                case "3":
                    SaveLoad option2 = new SaveLoad(goals);
                    option2.SaveList();
                    break;
                case "4":
                    SaveLoad option3 = new SaveLoad(goals);
                    option3.LoadList();
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

    public static void RunChoice(string x, List<string> goals)
    {
        Console.Clear();

        if (x == "1")
        {
            SimpleGoal g1 = new SimpleGoal("", "", 0, false);
            string a1 = g1.CreateGoal();
            goals.Add(a1);
        }
        else if (x == "2")
        {
            EternalGoal g2 = new EternalGoal("", "", 0, false);
            string a2 = g2.CreateGoal();
            goals.Add(a2);
        }
        else if (x == "3")
        {
            ChecklistGoal g3 = new ChecklistGoal("", "", 0, false, 0, 0);
            string a3 = g3.CreateGoal();
            goals.Add(a3);;
        }
        else { }

    }

}