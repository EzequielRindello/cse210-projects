public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Breathing activity.";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 30;
    }

    public void RunBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            BreatheIn();
            BreatheOut();
        }
    }

    public void BreatheIn()
    {
        for (int i = 0; i < 5; ++i)
        {
            Console.Write($"\rBreathe in...{i} ");
            Thread.Sleep(1000);
        }
        Console.Write($"\rBreathe in... ");
        Console.WriteLine("");
    }

    public void BreatheOut()
    {
        for (int i = 0; i < 7; ++i)
        {
            Console.Write($"\rBreathe out...{i} ");
            Thread.Sleep(1000);
        }
        Console.Write($"\rBreathe out... ");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    
}