using System;

public class PromptGenerator
{
    public List<string> _randomPromp = new List<string>();
    public string _promp;
    public string SelectPromp()
    {
        _randomPromp.Add("What brings you joy? ");
        _randomPromp.Add("Describe a place where you felt happiest.");
        _randomPromp.Add("If you are granted a wish, what would you wish for and why?");
        _randomPromp.Add("What is something that you would like to change about yourself? How can you change it?");
        Random r = new Random();
        int index = r.Next(_randomPromp.Count);
        string randomString = _randomPromp[index];
        _promp = randomString;
        Console.WriteLine(_promp);
        return _promp;
    }
}