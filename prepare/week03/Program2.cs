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
                    string prompt=PromptGenerator();
                    string userAnswer=GetResponse();
                    break;
                case "2":
                    Display();
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
    static string PromptGenerator()
    {
        // Generates a random promp and stores in a variable(str)
        PromptGenerator prompt = new PromptGenerator();
        string randomPromp = prompt.SelectPromp();
        return randomPromp;
    }
    static string GetResponse(){
        // Return the respose
        Entry response = new Entry();
        string answer=response.GetResponse();
        return answer;
    }

    static void Display()
    {
      Journal display1 = new Journal();
      display1.DisplayResponse();

    }
}