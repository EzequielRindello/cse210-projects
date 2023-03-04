using System;

class Program
{
    static void Main(string[] args)
    {
        // Lists of promps and questions.
        List<string> prompsReflecting = GetPrompList();
        List<string> questionsReflecting = GetQuestionList();
        List<string> prompsListing = GetListingList();
        List<string> listing = new List<string>();

        // While loop with a menu.
        while (true)
        {
            Console.Clear();
            string answer = GetMenuChoice();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity primera = new BreathingActivity("", "");
                    primera.DisplayStartingMessageAndGetTime();
                    Console.Clear();
                    primera.GetReadyMessage();
                    primera.RunBreathingActivity();
                    primera.DisplayEndingMessage();
                    break;
                case "2":
                    Console.Clear();
                    ReflectingActivity segunda = new ReflectingActivity("", "", prompsReflecting, questionsReflecting);
                    segunda.DisplayStartingMessageAndGetTime();
                    Console.Clear();
                    segunda.GetReadyMessage();
                    segunda.RunReflectingActivity();
                    segunda.DisplayEndingMessage();
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity tercera = new ListingActivity("", "", prompsListing, listing);
                    tercera.DisplayStartingMessageAndGetTime();
                    Console.Clear();
                    tercera.GetReadyMessage();
                    tercera.RunListingActivity();
                    tercera.DisplayEndingMessage();
                    break;
                case "4":
                    Console.Clear();
                    GroundingActivity cuarta = new GroundingActivity("", "");
                    cuarta.SpecialStartingMessage();
                    cuarta.GetReadyMessage();
                    cuarta.RunGroundingActivity();
                    cuarta.SpecialEndingMessage();
                    break;
                case "5":
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
        Console.WriteLine("1: Start breathing activity\n2: Start reflection activity\n3: Start listing activity\n4: Start grounding activity \n5: Quit");
        return Console.ReadLine();
    }

    public static List<string> GetPrompList()
    {
        List<string> x = new List<string>();
        x.Add("Think of a time when you stood up for someone else");
        x.Add("Think of a time when you did something really difficult");
        x.Add("Think of a time when you helped someone in need");
        x.Add("Think of a time when you did something truly selfless");
        return x;
    }

    public static List<string> GetQuestionList()
    {
        List<string> x = new List<string>();
        x.Add("Why was this experience meaningful to you?");
        x.Add("Have you ever done anything like this before?");
        x.Add("How did you get started?");
        x.Add("How did you feel when it was complete?");
        x.Add("What made this time different than other times when you were not as successful?");
        x.Add("What is your favorite thing about this experience?");
        x.Add("What could you learn from this experience that applies to other situations?");
        x.Add("What did you learn about yourself through this experience?");
        x.Add("How can you keep this experience in mind in the future?");

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