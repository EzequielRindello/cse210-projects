using System;
using System.IO;
public class SaveLoad
{
    private List<Goal> _file = new List<Goal>();
    private int _points = 0;

    public SaveLoad(List<Goal> file, int totalPoints)
    {
        this._file = file;
        this._points = totalPoints;
    }

    public void DisplayList()
    {
        int listNumber = 0;
        foreach (Goal s in _file)
        {
            listNumber++;
            string goal = s.Display();
            Console.WriteLine($"{listNumber}. {goal}");
        }
    }

    public void SaveList(List<Goal> goals, int points)
    {
        Console.Clear();
        Console.WriteLine("Enter the name of the file to save the goals:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(points);
            foreach (Goal goal in _file)
            {
                outputFile.WriteLine(goal.GetGoal());
            }
        }
        Console.WriteLine("Goals saved to file successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void LoadList()
    {
        Console.Write("What is the name of your file? ");
        string fileName = Console.ReadLine();
        String line;
        using (StreamReader outputFile = new StreamReader(fileName))
        {
            line = outputFile.ReadLine();
            _points = int.Parse(line);
            line = outputFile.ReadLine();
            while (line != null)
            {
                string[] goalLines = line.Split(',');
                string goalType = goalLines[0];
                if (goalType == "SimpleGoal")
                {
                    Goal goal = new SimpleGoal(goalLines[1], goalLines[2], int.Parse(goalLines[3]), bool.Parse(goalLines[4]));
                    _file.Add(goal);
                }
                if (goalType == "EternalGoal")
                {
                    Goal goal = new EternalGoal(goalLines[1], goalLines[2], int.Parse(goalLines[3]), bool.Parse(goalLines[4]));
                    _file.Add(goal);
                }
                if (goalType == "ChecklistGoal")
                {
                    Goal goal = new ChecklistGoal(goalLines[1], goalLines[2], int.Parse(goalLines[3]), bool.Parse(goalLines[4]), int.Parse(goalLines[5]), int.Parse(goalLines[6]), int.Parse(goalLines[7]));
                    _file.Add(goal);
                }
                line = outputFile.ReadLine();
            }
        }
    }
}