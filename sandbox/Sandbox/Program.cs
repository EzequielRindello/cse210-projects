using System;

class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();
        List<string> Proverbs = new List<string>() { "Trust ", "in ", "the ", "Lord ", "with ", "all ", "thine ", "heart;", " and ", "lean "
        , "not ", "unto ", "thine ", "own ", "understanding.", "In ", "all ", "thy ", "ways ",
        "acknowledge ", "him, ", "and ", "he ", "shall ", "direct ", "thy ", "paths." };

        NewList(Proverbs);
        DisplayList(Proverbs);
        Console.WriteLine();
        NewList(Proverbs);
        DisplayList(Proverbs);

    }

    public static List<string> NewList(List<string> Proverbs)
    {
        var random = new Random();
        int index = random.Next(Proverbs.Count);
        string randomString = Proverbs[index];
        HashSet<string> discovered = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
        discovered.Add(randomString);
        string convertWord = ConvertWord(randomString, discovered);
        int valid = Proverbs.FindIndex(s => s == randomString);
        if (valid != -1)
        {
            Proverbs[valid] = convertWord;
        }

        return Proverbs;
    }
    public static void DisplayList(List<string> Proverbs)
    {
        foreach (var x in Proverbs)
        {
            Console.Write(x);
        }
    }
    static string ConvertWord(string word, HashSet<string> discovered)
    {
        return string.Concat(word.Select(p => discovered.Contains(p.ToString()) ? p : '_'));
    }
}