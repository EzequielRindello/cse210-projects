using System;
class Program
{
    static void Main(string[] args)
    {
        // Original scripture.
        List<string> proverbs = CreateVerse();
        //  Parametrer for the main loop.
        bool valid = false;
        // Main loop for the program.
        while (!valid)
        {
            //Clear the console.
            Console.Clear();
            // Creates the name of the scripture.
            Reference full_scripture = new Reference("Proverbs", 3, "5-6");
            full_scripture.DisplayInfo();
            // Display either the Original scripture or the hidden version.
            Scripture display_scripture = new Scripture(proverbs);
            display_scripture.DisplayScripture();
            // Ask the user specific input.
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or tipe 'quit' to finish");
            string user_input = Console.ReadLine();
            if (user_input == "")
            {
                // Select random words and replace it.
                Word new_list = new Word(proverbs);
                // I choose 8 because it has to select and ignore white spaces!
                for (int i = 0; i < 8; i++)
                {
                    proverbs = new_list.ReplaceRandonWord(proverbs);
                }

            }
            else if (user_input.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
            {
                // Stops the program.
                valid = true;
            }
            else
            {
                // Handle exceptions.
                Console.WriteLine("Error.");
            }
        }
    }
    public static List<string> CreateVerse()
    {
        List<string> x = new List<string>() {"Trust"," ","in"," ","the"," ","Lord"," ","with"," ","all"," ","thine"," ","heart;"," ","and"," ", "lean"
        ," ","not"," ","unto"," ","thine"," ", "own"," ","understanding."," ","In"," ","all"," ","thy"," ","ways",
        " ","acknowledge"," ", "him,"," ", "and"," ", "he"," ", "shall"," ", "direct"," ", "thy"," ", "paths." };
        return x;
    }
}