public class ListingActivity : Activity
{ 
    public ListingActivity(string name, string description, int duration) :
        base(name, description, duration)
    {
        name = "Welcome to the listing activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        duration = 50;
    }
}