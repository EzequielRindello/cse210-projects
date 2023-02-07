using System.IO;

public class Scripture
{
    private List<string> _proverbs = new List<string>() { };
    public Scripture(List<string> Proverbs)
    {
        _proverbs = Proverbs;
    }
    public void DisplayList()
    {
        foreach (var x in _proverbs)
        {
            Console.Write(x);
        }
    }
    public void IsCompletelyHidden()
    {
        
    }
}