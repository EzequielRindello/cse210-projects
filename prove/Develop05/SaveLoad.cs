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
        // Sould be goals.txt
        Console.WriteLine("What is the name of your filename:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for (int i = 0; i < _file.Count; i++)
            {
                string line = _file[i];
                outputFile.WriteLine(line);
            }
        }
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