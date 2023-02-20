public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) :
        base(name, description, duration)
    {
        _name = "Welcome to the breathing activity.";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
    }

}