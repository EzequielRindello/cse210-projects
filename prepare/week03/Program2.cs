using System;
using System.Collections.Generic;
class Program2
{
    static void Main(string[] args)
    {
        bool valid = false;
        while (valid != true)
        {
            Menu();
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    CaseOne();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    valid = true;
                    break;
                default:
                    Console.Write("Error.");
                    break;
            }

        }

    }
    static void Menu()
    {
        Console.WriteLine("Please selec one:");
        Console.WriteLine("1.");
        Console.WriteLine("2.");
        Console.WriteLine("3.");
        Console.WriteLine("4.");
        Console.WriteLine("5.Exit");
    }
    static void CaseOne()
    {
        var list = new List<string>{ "What brings you joy? ", "Describe a place where you felt happiest. ",
        "What is something that you would like to change about yourself? How can you change it? ",
        "If you are granted a wish, what would you wish for and why? ",
        "How could you make someone you care about feel better if he/she just lost something important to them? " };

        PromptGenerator prompt1 = new PromptGenerator();
        Random r = new Random();
        int index = r.Next(list.Count);
        string randomString = list[index];
        prompt1._prompt = randomString;
        prompt1.DisplayPrompt();
    }

}