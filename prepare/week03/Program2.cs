using System;
using System.Collections.Generic;
class Program2
{
    static void Main(string[] args)
    {
        // Creates a while loop whit a boolean to keep displaying options for the user.
        // Once the user is done with the program the loop finishes.
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
        // Display the menu.
        Console.WriteLine("Please selec one:");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Exit");
    }
    static void CaseOne()
    {
        //
        PromptGenerator prompt = new PromptGenerator();
        prompt.SelectPromp();
        //
        Entry respose = new Entry();
    }

}