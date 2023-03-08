public class GroundingActivity : Activity
{
    /* This activity is mentioned in 
        the group meeting so I decided 
        to add it to get extra points.
        it wont have time and atributes to
        be different from the others :) */

    public GroundingActivity(string name, string description) : base(name, description)
    {
        _name = "Grounding ctivity";
        _description = "This five-step exercise can be very helpful during periods of anxiety or panic by helping to ground you in the present when your mind is bouncing around between various anxious thoughts.";
    }

    public void RunGroundingActivity()
    {
        Console.WriteLine("Before starting this exercise, pay attention to your breathing. Slow, deep, long breaths can help you maintain a sense of calm or help you return to a calmer state.");
        Console.WriteLine("When you are ready to begin enter any key ");
        string none = Console.ReadLine();
        Timer();
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Acknowledge FIVE things you see around you. It could be a pen, a spot on the ceiling, anything in your surroundings.");
            PressToContinue(none);
            Console.WriteLine("Acknowledge FOUR things you can touch around you. It could be your hair, a pillow, or the ground under your feet. ");
            PressToContinue(none);
            Console.WriteLine("Acknowledge THREE things you hear. This could be any external sound. If you can hear your belly rumbling that counts! Focus on things you can hear outside of your body.");
            PressToContinue(none);
            Console.WriteLine("Acknowledge TWO things you can smell. Maybe you are in your office and smell pencil, or maybe you are in your bedroom and smell a pillow. If you need to take a brief walk to find a scent you could smell soap in your bathroom, or nature outside.");
            PressToContinue(none);
            Console.WriteLine("Acknowledge ONE thing you can taste. What does the inside of your mouth taste like—gum, coffee, or the sandwich from lunch?");
            PressToContinue(none);
            return;
        }
    }

    public void PressToContinue(string none)
    {
        Console.WriteLine("Press enter to continue.");
        Console.ReadKey();
    }

    public void SpecialStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("This program is different from the others since it does not have a predefined time, just relax and take the time you need for each answer. Enter any key when you are ready.");
        Console.ReadKey();
    }

    public void SpecialEndingMessage()
    {
        Console.WriteLine("Well done !!!");
        PauseSpinner();
    }

}