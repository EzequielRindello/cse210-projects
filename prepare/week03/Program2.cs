using System;
using System.Collections.Generic;
class Program2
{
    static void Main(string[] args)
    {

        // Global variables.
        bool valid = false;
        string prompt = "";
        string userResponse = "";
        string date_str = "";
        // Creates a while loop whit a boolean to keep displaying options for the user.
        // Once the user is done with the program the loop finishes.
        while (valid != true)
        {
            Menu();
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    prompt = PromptGenerator();
                    userResponse = GetResponse();
                    date_str = GetTime();
                    break;
                case "2":
                    Display(prompt, userResponse, date_str);
                    break;
                case "3":
                    break;
                case "4":
                    SaveToFile(prompt, userResponse, date_str);
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
        // Generates a random promp and stores in a variable(str).
        PromptGenerator prompt = new PromptGenerator();
        string randomPromp = prompt.SelectPromp();
        return randomPromp;
    }
    static string GetResponse()
    {
        //Ask for an input eturn the respose.
        Entry response = new Entry();
        string answer = response.GetResponse();
        return answer;
    }
    static string GetTime()
    {
        // Gets and return time.
        Entry time = new Entry();
        string date_str = time.Time();
        return date_str;
    }
    static void Display(string prompt, string userResponse, string date_str)
    {
        // Display the prompt, the user response and time.
        Journal display1 = new Journal();
        display1.DisplayResponse(prompt, userResponse, date_str);
    }
    static void SaveToFile(string prompt, string userResponse, string date_str)
    {
        // Saves the prompt, the user response and time into a file.
        Journal myFile = new Journal();
        myFile.SaveFile();
    }

}