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
                Word new_list= new Word(proverbs);
                proverbs=new_list.SelectRandomWords(proverbs);
                
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

}