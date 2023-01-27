using System;
using System.Collections.Generic;
using System.IO; 
class Program2
{
    static void Main(string[] args)
    {

        // Global variables.
        bool valid = false;
        string prompt = "";
        string userResponse = "";
        string date_str = "";
        List<string>journal=new List<string>();
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
                    journal.Add(date_str);
                    journal.Add(prompt);
                    journal.Add(userResponse);
                    break;
                case "2":
                    Display(journal);
                    break;
                case "3":
                    
                    break;
                case "4":
                    SaveToFile(journal);
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
    static void Display(List<string> journal)
    {
        // Display the prompt, the user response and time.
        Journal display1 = new Journal();
        display1.DisplayResponse(journal);
    }
    static void SaveToFile(List<string> journal)
    {
        // Saves the prompt, the user response and time into a file.
        Journal myFile = new Journal();
        myFile.SaveFile(journal);
    }

}