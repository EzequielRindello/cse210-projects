using System;

class Program
{
    static void Main(string[] args)
    {
        // List to store/load goals entered.
        List<Goal> goals = new List<Goal>();
        // Loop with a switch that takes input from the user to select a choice from the menu.
        while (true)
        {
            // Clear the console and executes a case from the switch.
            Console.Clear();
            string answer = Menu();
            switch (answer)
            {
                case "1": // Creates a new goal.
                    string choice = GoalsMenu();
                    RunChoice(choice, goals);
                    break;
                case "2": // List Goals.
                    SaveLoad option1 = new SaveLoad(goals);
                    option1.DisplayList();
                    Console.WriteLine("Please enter any key to continue.");
                    Console.ReadKey();
                    break;
                case "3": // Save goals to a file.
                    SaveLoad option2 = new SaveLoad(goals);
                    option2.SaveList();
                    break;
                case "4": // Load goals from a file.
                    SaveLoad option3 = new SaveLoad(goals);
                    goals = option3.LoadList();
                    break;
                case "5": // Marks  a goal completed.

                    break;
                case "6": // Quits the program.
                    Console.WriteLine("Thanks  for using our program!");
                    return;
            }
        }
    }

    public static string Menu() // Displays the main menu.
    {
        Console.WriteLine("Menu options:");
        Console.WriteLine("   1: Create new goal\n   2: List Goals\n   3: Save goals\n   4: Load goals\n   5: Record event \n   6: Quit");
        return Console.ReadLine();
    }

    public static string GoalsMenu() // Displays the types of goals menu.
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
            Goal goal1 = new SimpleGoal("", "", 0, false, "");
            goal1.CreateGoal();
            goals.Add(goal1);
        }
        else if (x == "2")
        {
            Goal goal2 = new EternalGoal("", "", 0, false, "");
            goal2.CreateGoal();
            goals.Add(goal2);
        }
        else if (x == "3")
        {
            Goal goal3 = new ChecklistGoal("", "", 0, false, "", 0, 0);
            goal3.CreateGoal();
            goals.Add(goal3);
        }
        else { }

    }

}