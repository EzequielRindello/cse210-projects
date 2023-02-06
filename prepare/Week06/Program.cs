using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Scripture display= new Scripture();
            display.DisplayList();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or tipe 'quit' to finish");
            string input = Console.ReadLine();
            if (input == "")
            {
                //Proverbs= NewList(Proverbs);
            }
            else if (input.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
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