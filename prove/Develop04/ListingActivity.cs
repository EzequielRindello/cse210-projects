public class ListingActivity : Activity
{
    private List<string> _prompsListing;

    public ListingActivity(string name, string description, int duration, List<string> promp) :
        base(name, description, duration)
    {
        _name = "Welcome to the listing activity.";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 40;
        _prompsListing = promp;
    }


}