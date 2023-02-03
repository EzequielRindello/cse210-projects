using System;

class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();
        List<string> Proverbs = new List<string>() { "Trust ", "in ", "the ", "Lord ", "with ", "all ", "thine ", "heart;", " and ", "lean "
            , "not ", "unto ", "thine ", "own ", "understanding.", "In ", "all ", "thy ", "ways ",
            "acknowledge ", "him, ", "and ", "he ", "shall ", "direct ", "thy ", "paths." };


        var random = new Random();
        int index = random.Next(Proverbs.Count);
        string randomString = Proverbs[index];
        HashSet<string> discovered = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
        discovered.Add(randomString);
        string convertWord = ConvertWord(randomString, discovered);

        int fd = Proverbs.FindIndex(s => s == randomString);

        if (fd != -1)
            Proverbs[fd] = convertWord;

        ;

        DisplayList(Proverbs);

    }

    public List<string> NewList(List<string> Proverbs)
    {
        return null;
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