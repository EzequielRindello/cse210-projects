using System;

class Program
{
    static void Main(string[] args)
    {
        // Input and Output
        Console.WriteLine("Enter a whole number");
        string x = Console.ReadLine();

        // String Interpolation
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");
        // or...
        Console.WriteLine("I am studying at " + school + ".");

        //


    }
}