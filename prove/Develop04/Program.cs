using System;

class Program
{
    static void Main(string[] args)
    {
        // Lists of promps and questions.
        List<string> prompsReflecting = GetPrompList();
        List<string> questionsReflecting = GetQuestionList();
        List<string> prompsListing = GetListingList();
        // While loop with a menu.

        while (true)
        {
            Console.Clear();
            string answer = GetMenuChoice();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity primera = new BreathingActivity("", "", 0);
                    primera.DisplayStartingMessage();
                    Console.Clear();
                    primera.GetReadyMessage();
                    primera.RunBreathingActivity();
                    primera.DisplayEndingMessage();
                    break;
                case "2":
                    Console.Clear();
                    ReflectingActivity segunda = new ReflectingActivity("", "", 0, prompsReflecting, questionsReflecting);
                    segunda.DisplayStartingMessage();
                    Console.Clear();
                    segunda.GetReadyMessage();
                    //
                    
                    //
                    segunda.DisplayEndingMessage();
                    break;
                case "3":
                    ListingActivity tercera = new ListingActivity("", "", 0, prompsListing);
                    tercera.DisplayStartingMessage();
                    Console.Clear();
                    tercera.GetReadyMessage();
                    //
                    
                    //
                    tercera.DisplayEndingMessage();
                    break;
                case "4":
                    Console.WriteLine("Thanks for using the program!");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Error, please enter a valid choice.");
                    Thread.Sleep(4000);
                    break;
            }
        }
    }

    public static string GetMenuChoice()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1:Start breathing activity\n2:Start reflection activity\n3:Start listening activity\n4:Quit");
        return Console.ReadLine();
    }

    public static List<string> GetPrompList()
    {
        List<string> x = new List<string>();
        x.Add("Think of a time when you stood up for someone else.");
        x.Add("Think of a time when you did something really difficult.");
        x.Add("Think of a time when you helped someone in need.");
        x.Add("Think of a time when you did something truly selfless.");
        return x;
    }

    public static List<string> GetQuestionList()
    {
        List<string> x = new List<string>();
        return x;
    }

    public static List<string> GetListingList()
    {
        List<string> x = new List<string>();
        x.Add("Who are people that you appreciate?");
        x.Add("What are personal strengths of yours?");
        x.Add("Who are people that you have helped this week?");
        x.Add("When have you felt the Holy Ghost this month?");
        x.Add("Who are some of your personal heroes?");
        return x;
    }

}