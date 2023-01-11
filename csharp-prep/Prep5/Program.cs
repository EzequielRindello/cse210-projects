using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string Name = PromptUserName();
        int FavoriteNumber = PromptUserNumber();
        int Square = SquareNumber(FavoriteNumber);
        DisplayResult(Name, Square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int valid = int.Parse(number);
        return valid;
    }
    static int SquareNumber(int x)
    {
        int Square = x * x;
        return Square;
    }
    static void DisplayResult(string Name, int Square)
    {
        Console.WriteLine($"{Name}, the square of your number is: {Square} ");
    }
}