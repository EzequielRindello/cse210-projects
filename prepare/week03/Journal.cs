using System;
using System.IO;

public class Journal
{
    public void SaveFile(List<string> journal)
    {
        // Sould be myFile.txt
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for (int i = 0; i < journal.Count; i++)
            {
                string line = journal[i];
                outputFile.WriteLine(line);
            }
        }
    }
    public List<string> LoadFile()
    {
        // Sould be myFile.txt
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        var logFile = File.ReadAllLines(filename);
        var logList = new List<string>(logFile);
        return logList;
    }
    public void DisplayResponse(List<string> journal)
    {
        for (int i = 0; i < journal.Count; i++)
        {
            Console.WriteLine(journal[i]);
        }
    }
}