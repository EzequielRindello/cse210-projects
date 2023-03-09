public class SaveLoad
{
    private List<Goal> _file;

    public SaveLoad(List<Goal> file)
    {
        this._file = file;
    }

    public void DisplayList()
    {
        // _file.ForEach(Console.WriteLine);
        foreach (Goal s in _file)
        {
            string goal=s.SetGoal();
            Console.WriteLine(goal);
        }
    }

    public void SaveList()
    {
        Console.WriteLine("Enter the name of the file to save the goals:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _file)
            {
                outputFile.WriteLine(goal.ToString());
            }
        }
        Console.WriteLine("Goals saved to file successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void LoadList()
    {
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
    }
}