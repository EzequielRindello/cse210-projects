public class BreathingActivity : Activity
{
    // No atributes were defined for this class.
    public BreathingActivity(string name, string description, int duration) :
        base(name, description, duration)
    {
        _name = "Breathing activity.";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 40;
    }

    public void RunBreathingActivity()
    {
        BreatheIn();
        BreatheOut();
        BreatheIn();
        BreatheOut();
    }

    public void BreatheIn()
    {
        for (int i = 0; i < 5; ++i)
        {
            Console.Write($"\rBreathe in...{i} ");
            Thread.Sleep(1100);
        }
        Console.WriteLine("");
    }

    public void BreatheOut()
    {
        for (int i = 0; i < 7; ++i)
        {
            Console.Write($"\rBreathe out...{i} ");
            Thread.Sleep(1100);
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }
}