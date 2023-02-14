using System;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
        //Console.Clear();
        Console.WriteLine("What model do you prefer:\nPeugeot\nFiat ");
        string userAnswer=Console.ReadLine();
        if(userAnswer.Equals("Peugeot",StringComparison.InvariantCultureIgnoreCase))
        {
            Car car1= new Car("Peugeot", "306 XR",1999);
            string model = car1.GetModel();
            string name = car1.GetName();
            int year=car1.GetYear();
            car1.Display();
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