using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            string answer = Menu();
            switch (answer)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":
                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error, please enter a valid choice.");
                    Thread.Sleep(3000);
                    break;
            }
        }
    }

    public static string Menu()
    {
        Console.WriteLine("1: Create new goal\n2: List Goals\n3: Save goals\n4: Load goals\n5: Record event \n6: Quit ");
        return Console.ReadLine();
    }

}