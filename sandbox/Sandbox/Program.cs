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
            PeugeotInfo car1=new PeugeotInfo("","",0,"");
            Console.WriteLine(car1.GetCarInfo());
            return;
        }else if(userAnswer.Equals("Fiat",StringComparison.InvariantCultureIgnoreCase))
        {
            FiatInfo car1=new FiatInfo("","",0,"");
            Console.WriteLine(car1.GetCarInfo());
            return;
        }else
        {
            Console.WriteLine("Error. Please enter a valid choice");
        }

        }
    }
}