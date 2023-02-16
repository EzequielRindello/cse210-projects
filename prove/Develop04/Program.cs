using System;

class Program
{
    static void Main(string[] args)
    {
        // Lists of promps and questions.
        List<string> promps = new List<string>();
        List<string> questions = new List<string>();
        // While loop with a menu.
        while (true)
        {
            Console.Clear();
            string answer = GetMenuChoice();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    return;
                case "2":
                    Console.Clear();
                    return;
                case "3":
                    Console.Clear();
                    return;
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
    public static List<string> GetPrompList(List<string> x)
    {

        return x;
    }
    public static List<string> GetQuestionList(List<string> x)
    {
        
        return x;
    }
}