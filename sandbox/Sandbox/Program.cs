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
            Car car1=new Car("Peugeot 306","XR 1.8",1998);
            Console.WriteLine(car1.GetCarInfo());
            return;
        }else if(userAnswer.Equals("Fiat",StringComparison.InvariantCultureIgnoreCase))
        {
            Car car1=new Car("Fiat 147","Spazio TR 1.3",1988);
            Console.WriteLine(car1.GetCarInfo());
            return;
        }else
        {
            Console.WriteLine("Error. Please enter a valid choice");
        }

        }
    }
}