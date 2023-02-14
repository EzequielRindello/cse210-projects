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
            PeugeotInfo car1=new PeugeotInfo();
            car1.SetName("Peugeot 306");
            car1.SetModel("XR 1.8");
            car1.SetYear(1998);
            Console.WriteLine(car1.GetCarInfo());
            return;
        }else if(userAnswer.Equals("Fiat",StringComparison.InvariantCultureIgnoreCase))
        {
            FiatInfo car1=new FiatInfo();
            car1.SetName("Fiat 147");
            car1.SetModel("Spazio TR 1.3");
            car1.SetYear(1987);
            Console.WriteLine(car1.GetCarInfo());
            return;
        }else
        {
            Console.WriteLine("Error. Please enter a valid choice");
        }

        }
    }
}