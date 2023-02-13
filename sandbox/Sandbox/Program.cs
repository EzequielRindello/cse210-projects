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
        if(userAnswer=="Peugeot")
        {

        }else if(userAnswer=="Fiat")
        {
            
        }else
        {
            Console.WriteLine("Error. Please enter a valid choice");
        }

        }
    }
}