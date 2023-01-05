using System;

class Program
{
    static void Main(string[] args)
    {
        // Get input from the user and passed to an integer.
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int valid_percent = int.Parse(percentage);
        // Set a variable to apply a grade with ifs statemets.
        string grade = "";
        if (valid_percent >= 90)
        {
            grade = "A";
        }
        else if (valid_percent >= 80)
        {
            grade = "B";
        }
        else if (valid_percent >= 70)
        {
            grade = "C";
        }
        else if (valid_percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        // Prints the resuls.
        Console.WriteLine($"Your grade is: {grade}");
        if (valid_percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed :)");
        }
        else
        {
            Console.WriteLine("We sorry, you did not pass :/");
        }
    }
}