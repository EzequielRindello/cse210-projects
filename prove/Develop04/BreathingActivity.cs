public class BreathingActivity : Activity
{
    // No atributes were defined for this class.
    public BreathingActivity(string name, string description, int duration) :
        base(name, description, duration)
    {
        _name = "Welcome to the breathing activity.";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 30;
    }

    public void RunBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(30000);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.WriteLine("Works?");
            Thread.Sleep(15000);
        }
    }

    public void BreatheIn()
    {
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.WriteLine();
    }
}