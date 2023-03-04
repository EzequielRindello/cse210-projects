public class ListingActivity : Activity
{
    private List<string> _prompsListing;
    private string _ramdomListPromp;
    private List<string> _listing;
    private int _counting = 0;

    public ListingActivity(string name, string description, List<string> promp, List<string> listing) :
        base(name, description)
    {
        _name = "Listing activity.";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompsListing = promp;
        _listing = listing;
    }

    public void RunListingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        GetRandomListPrompt();
        DisplayPromp();
        Timer();

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            string response = Console.ReadLine();
            SaveUserResponse(response, _listing);
            _counting++;
        }

        DisplayItemsEntered();
    }

    public void GetRandomListPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompsListing.Count);
        string ramdomListPromp = _prompsListing[index];
        _ramdomListPromp = ramdomListPromp;
    }

    public void DisplayPromp()
    {
        Console.WriteLine("List as many responses you can to the following rompt: ");
        Console.WriteLine($"--- {_ramdomListPromp} ---");
    }

    public void SaveUserResponse(string a, List<string> b)
    {
        b.Add(a);
    }

    public void DisplayItemsEntered()
    {
        Console.WriteLine("");
        Console.WriteLine($"You listed {_counting} items in this sesion!");
        Console.WriteLine("");
    }

}