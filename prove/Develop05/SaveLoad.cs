using System;
using System.IO;
public class SaveLoad
{
    private List<Goal> _file;
    private int _totalPoints = 0;

    public SaveLoad(List<Goal> file, int totalPoints)
    {
        this._file = file;
        this._totalPoints = totalPoints;
    }

    public void DisplayList()
    {
        int listNumber = 0;
        foreach (Goal s in _file)
        {
            listNumber++;
            string goal = s.Display();
            Console.WriteLine($"{listNumber}. [ ] {goal}");
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
}