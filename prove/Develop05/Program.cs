using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> simpleGoal = new List<Goal>();
        List<Goal> eternalGoal = new List<Goal>();
        List<Goal> checklistGoal = new List<Goal>();

        while (true)
        {
            Console.Clear();
            string answer = Menu();
            switch (answer)
            {
                case "1":

                    break;
                case "2":

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
        Console.WriteLine("1: Create new goal\n2: List Goals\n3: Save goals\n4: Load goals\n5: Record event \n6: Quit");
        return Console.ReadLine();
    }

    // public static string GoalsMenu()
    // {
    //     Console.WriteLine("The types of goals are:");
    //     Console.WriteLine("1: Simple goal\n2: Eternal Goal\n3: Checklist goal");
    //     return Console.ReadLine();
    // }


}