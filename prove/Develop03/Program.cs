using System;
class Program
{
    static void Main(string[] args)
    {
        // Original scripture
        List<string> proverbs = new List<string>() { "Trust ", "in ", "the ", "Lord ", "with ", "all ", "thine ", "heart;", " and ", "lean "
        , "not ", "unto ", "thine ", "own ", "understanding.", "In ", "all ", "thy ", "ways ",
        "acknowledge ", "him, ", "and ", "he ", "shall ", "direct ", "thy ", "paths." };

        while (true)
        {
            Console.Clear();

            Reference full_scripture = new Reference("Proverbs", 3, "5-6");
            full_scripture.DisplayInfo();

            Scripture display_scripture = new Scripture(proverbs);
            display_scripture.DisplayList();

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or tipe 'quit' to finish");
            string user_input = Console.ReadLine();
            if (user_input == "")
            {

                //Proverbs= NewList(Proverbs);
            }
            else if (user_input.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
            {
                break;
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }

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
    static string ConvertWord(string word, HashSet<string> discovered)
    {
        return string.Concat(word.Select(p => discovered.Contains(p.ToString()) ? p : '_'));
    }
}