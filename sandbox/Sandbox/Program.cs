using System;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
        Console.Clear();
        Console.WriteLine("What model do you prefer:\nPeugeot\nFiat ");
        string userAnswer=Console.ReadLine();
        if(userAnswer.Equals("Peugeot",StringComparison.InvariantCultureIgnoreCase))
        {
            return;
        }else if(userAnswer.Equals("Fiat",StringComparison.InvariantCultureIgnoreCase))
        {
            return;
        }else
        {
            Console.WriteLine("Error. Please enter a valid choice");
        }

        }
    }
}