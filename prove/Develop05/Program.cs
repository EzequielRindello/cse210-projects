using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>(); // List to store/load goals entered.
        List<string> goalsCompleted = new List<string>(); // This is my extra to store every completed goal (this goal will be pop from the goals list).
        goalsCompleted = LoadGoalsCompleted();
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
                case "5": // Record goals completed.
                    /* I decided to do this here so I don't have to pass everything to a function/method with parameters*/
                    Console.Clear();
                    Console.WriteLine("The goals are: ");
                    int sum = 0;
                    foreach (Goal goal in goals)
                    {
                        sum++;
                        goal.ShowGoalToDelete(sum);
                    }
                    Console.WriteLine("Which goal you want to mark as complete? ");
                    int input = int.Parse(Console.ReadLine());
                    Goal selectedGoal = goals[input - 1];
                    selectedGoal.RecordEvent();
                    totalPoints = totalPoints + selectedGoal.GetPoints();
                    string uno = selectedGoal.GetName();
                    string dos = selectedGoal.GetDescription();
                    string nashe = uno + " " + dos;
                    goalsCompleted.Add(nashe);
                    SaveGoalsCompleted(goalsCompleted);
                    Console.WriteLine($"You now have {totalPoints} points!");
                    Console.ReadKey();
                    break;
                case "6": // Shows creativity and exceeds core requirements.
                    /* I decided to do this here so I don't have to pass everything to a function/method with parameters*/
                    Displays(goalsCompleted);
                    Console.WriteLine("Which goal you want to delete and add as to the complete goal file? ");
                    int sum2 = 0;
                    foreach (Goal goal in goals)
                    {
                        sum2++;
                        goal.ShowGoalToDelete(sum2);
                    }
                    int input2 = int.Parse(Console.ReadLine());
                    Goal selectedGoal2 = goals[input2 - 1];
                    SaveLoad delete = new SaveLoad(goals, totalPoints);
                    delete.DeleteGoal(goals, selectedGoal2);
                    break;
                case "7": // Quits the program.
                    Console.WriteLine("Thanks  for using our program!");
                    return;
            }
        }
    }

    public static string Menu(int totalPoints) // Displays the main menu.
    {
        Console.WriteLine($"You have {totalPoints} points.\n ");
        Console.WriteLine("Menu options:");
        Console.WriteLine("   1: Create new goal\n   2: List Goals\n   3: Save goals\n   4: Load goals\n   5: Record event \n   6: Show completed goals\n   7: Quit");
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
            ChecklistGoal goal3 = new ChecklistGoal("", "", 0, false, 0, 0, 0);
            goal3.SetName();
            goal3.SetDescription();
            goal3.SetPoints();
            goal3.SetBonus();
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
            goals = option3.GetGoals();
            totalPoints = option3.GetPoints();
        }
        else
        {
            Console.WriteLine("Error.");
            Thread.Sleep(2000);
        }
    }

    public static void SaveGoalsCompleted(List<string> goalsCompleted)
    {
        File.WriteAllLines("completedgoals.txt", goalsCompleted);
    }

    public static List<string> LoadGoalsCompleted()
    {
        string[] lines = File.ReadAllLines("completedgoals.txt");
        List<string> myList = new List<string>();

        foreach (string line in lines)
        {
            myList.Add(line);
        }

        return myList;
    }

    public static void Displays(List<string> goalsCompleted)
    {
        Console.Clear();
        Console.WriteLine("Metas guardadas: \n");
        foreach (string item in goalsCompleted)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Enter any key to continue.");
        Console.ReadKey();
    }
}