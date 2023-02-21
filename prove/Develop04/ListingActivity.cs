public class ListingActivity : Activity
{
    private List<string> _prompsListing;
    private string _ramdomListPromp;

    public ListingActivity(string name, string description, int duration, List<string> promp) :
        base(name, description, duration)
    {
        _name = "Listing activity.";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 40;
        _prompsListing = promp;
    }

    public void RunListingActivity()
    {
        
    }

    public void GetRandomListPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompsListing.Count);
        string ramdomListPromp = _prompsListing[index];
        _ramdomListPromp=ramdomListPromp;
    }

}