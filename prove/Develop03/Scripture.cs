using System.IO;

public class Scripture
{
    private List<string> _proverbs = new List<string>() { };

    public Scripture(List<string> Proverbs)
    {
        _proverbs = Proverbs;
    }
    
    public void DisplayScripture()
    {
        foreach (var x in _proverbs)
        {
            Console.Write(x);
        }
    }
}