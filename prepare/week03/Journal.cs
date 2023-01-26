using System;
using System.IO;

public class Journal
{
    public void SaveFile(string a, string b, string c)
    {
        // Sould be myFile.txt
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Add responses.
            outputFile.WriteLine(a);
            outputFile.WriteLine(b);
            outputFile.WriteLine(c);
        }

    }
    public void DeleteResponses()
    {

    }
    public void LoadFile()
    {

    }
    public void DisplayResponse(string x, string z, string y)
    {
        Console.WriteLine(y);
        Console.WriteLine(x);
        Console.WriteLine(z);
    }
}