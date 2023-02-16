public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) :
        base(name, description, duration)
    {
        name = "Welcome to the breathing activity ";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        duration = 50;
    }
}