using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Console.Clear();
            string answer=GetMenuChoice();
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
                default :
                    Console.WriteLine("Error, please enter a valid choice.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    public static string GetMenuChoice()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1:Start breathing activity\n2:Start reflection activity\n3:Start listening activity");
        return Console.ReadLine();
    }
}