public class Car
{
    private string _moldel;
    private int _year;
    private string _name;

    public void Display(string model,int year,string name)
    {
        Console.WriteLine($"{model}{name}{year}");
    }
}