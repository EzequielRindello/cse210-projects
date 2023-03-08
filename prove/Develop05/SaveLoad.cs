public class SaveLoad
{
    private List<Goal> _file;

    public SaveLoad(List<Goal> file)
    {
        this._file = file;
    }

    public void DisplayList()
    {
        _file.ForEach(Console.WriteLine);
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

    public List<Goal> LoadList()
    {
        // Sould be goals.txt
        Console.WriteLine("What is the name of your filename:");
        string filename = Console.ReadLine();
        var gFile = File.ReadAllLines(filename);
        var gList = new List<string>(gFile);
        return gList;
    }
}