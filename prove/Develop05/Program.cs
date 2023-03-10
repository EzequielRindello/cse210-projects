using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>(); // List to store/load goals entered.
        List<string> goalsCompleted = new List<string>();
        int totalPoints = 0;

        while (true) // Loop with a switch that takes input from the user to select a choice from the menu.
        {
            Console.Clear(); // Clear the console and executes a case from the switch.
            string userInput = Menu(totalPoints); // Calls the Menu method and return a value to execute the switch block.
            switch (userInput)
            {
                case "1": // Creates a new goal.
                    string choice = GoalsMenu();
                    RunGoalChoice(choice, goals);
                    break;
                case "2": // List Goals.
                    RunLoadSaveChoice(userInput, goals, totalPoints);
                    break;
                case "3": // Save goals to a file.
                    RunLoadSaveChoice(userInput, goals, totalPoints);
                    break;
                case "4": // Load goals from a file.
                    RunLoadSaveChoice(userInput, goals, totalPoints);
                    break;
                case "5": // Marks  a goal completed and add the points.
                    RunLoadSaveChoice(userInput, goals, totalPoints);
                    break;
                case "6": // Quits the program.
                    Console.WriteLine("Thanks  for using our program!");
                    return;
            }
        }
    }

    public static string Menu(int totalPoints) // Displays the main menu.
    {
        Console.WriteLine($"You have {totalPoints} points.\n ");
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

    public static void RunGoalChoice(string userInput, List<Goal> goals) // Select base on the user input what goal to create.
    {
        Console.Clear();

        if (userInput == "1")
        {
            Goal goal1 = new SimpleGoal("", "", 0, false);
            goal1.SetGoal();
            goals.Add(goal1);
        }
        else if (userInput == "2")
        {
            Goal goal2 = new EternalGoal("", "", 0, false);
            goal2.SetGoal();
            goals.Add(goal2);
        }
        else if (userInput == "3")
        {
            Goal goal3 = new ChecklistGoal("", "", 0, false, 0, 0, 0);
            goal3.SetGoal();
            goals.Add(goal3);
        }
        else
        {
            Console.WriteLine("Error.");
            Thread.Sleep(2000);
        }
    }

    public static void RunLoadSaveChoice(string userInput, List<Goal> goals, int totalPoints) // Select base on the user input what goal to create.
    {
        Console.Clear();

        if (userInput == "2")
        {
            SaveLoad option1 = new SaveLoad(goals, totalPoints);
            option1.DisplayList();
            Console.WriteLine("Please enter any key to continue.");
            Console.ReadKey();
        }
        else if (userInput == "3")
        {
            SaveLoad option2 = new SaveLoad(goals, totalPoints);
            option2.SaveList(goals, totalPoints);
        }
        else if (userInput == "4")
        {
            SaveLoad option3 = new SaveLoad(goals, totalPoints);
            option3.LoadList();
        }
        else if (userInput == "5")
        {
            SaveLoad option4 = new SaveLoad(goals, totalPoints);
            option4.DisplayList();
            Console.Write("Which goal have you complete? ");
            int input = int.Parse(Console.ReadLine());
            Goal selectedGoal = goals[input - 1];
            selectedGoal.RecordEvent();
            totalPoints = totalPoints + selectedGoal.GetPoints();
        }
        else
        {
            Console.WriteLine("Error.");
            Thread.Sleep(2000);
        }
    }
}