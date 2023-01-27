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
                outputFile.WriteLine();
            }
        }

    }
    public void DeleteResponses()
    {

    }
    public void LoadFile()
    {
        // Sould be myFile.txt
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();

    }
    public void DisplayResponse(List<string> journal)
    {
        for (int i = 0; i < journal.Count; i++)
        {
            Console.WriteLine(journal[i]);
        }
    }
}