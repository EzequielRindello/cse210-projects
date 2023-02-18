using System.IO;

public class Reference
{
    private string _bookName;
    private int _chapter;
    private string _verse;
    
    public Reference(string book, int chapter, string verse)
    {
        _bookName = book;
        _chapter = chapter;
        _verse = verse;
    }

    public void DisplayInfo()
    {
        Console.Write($"{_bookName} {_chapter}:{_verse} ");
    }
}