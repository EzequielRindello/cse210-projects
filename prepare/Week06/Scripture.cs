using System.IO;

public class Scripture
{
    private  List<string> _proverbs = new List<string>() { "Trust ", "in ", "the ", "Lord ", "with ", "all ", "thine ", "heart;", " and ", "lean "
    , "not ", "unto ", "thine ", "own ", "understanding.", "In ", "all ", "thy ", "ways ",
    "acknowledge ", "him, ", "and ", "he ", "shall ", "direct ", "thy ", "paths." };

    public void DisplayList()
    {
        foreach (var x in _proverbs)
        {
            Console.Write(x);
        }
    }







}