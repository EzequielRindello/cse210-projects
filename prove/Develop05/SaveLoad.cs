public class SaveLoad
{
    private List<Goal> _file;
    private int _totalPoints = 0;

    public SaveLoad(List<Goal> file)
    {
        this._file = file;
    }

    public void DisplayList()
    {
        foreach (Goal s in _file)
        {
            string goal = s.GetGoal();
            Console.WriteLine(goal);
        }
    }

    public void SaveList()
    {
        Console.Clear();
        Console.WriteLine("Enter the name of the file to save the goals:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _file)
            {
                outputFile.WriteLine(goal.GetGoal());
            }
        }
        Console.WriteLine("Goals saved to file successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public List<Goal> LoadList()
    {
        List<Goal> goals = new List<Goal>();
        Console.WriteLine("Enter the name of the file to load the goals:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _file)
            {
                outputFile.WriteLine(goal.ToString());
            }
        }
        Console.WriteLine("Load successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        return goals;
    }
}