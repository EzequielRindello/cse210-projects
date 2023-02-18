using System.IO;

public class Word
{
    private List<string> _proverbs = new List<string>() { };
    private string _wordToReplace;

    public Word(List<string> proverbs)
    {
        _proverbs = proverbs;
    }

    public List<string> ReplaceRandonWord(List<string> _proverbs)
    {
        var random = new Random();
        int index = random.Next(_proverbs.Count);
        string randomString = _proverbs[index];
        if (randomString!=" ")
        {
            HashSet<string> discovered = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            discovered.Add(randomString);
            _wordToReplace = ConvertWord(randomString, discovered);
            int valid = _proverbs.FindIndex(s => s == randomString);
            if (valid != -1)
            {
                _proverbs[valid] = _wordToReplace;
            }
        
        }
        return _proverbs;
    }
    
    private string ConvertWord(string word, HashSet<string> discovered)
    {
        return string.Concat(word.Select(p => discovered.Contains(p.ToString()) ? p : '_'));
    }
}