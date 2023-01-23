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
        PromptGenerator prompt = new PromptGenerator();
        prompt.selectPromp();
    }

}