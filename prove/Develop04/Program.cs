using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            string answer=GetMenuChoice();
            switch (answer)
            {
                case "1":
                    return;
                case "2":
                    return;
                case "3":
                    return;
                default :
                    Console.WriteLine("Error, please enter a valid choice.");
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