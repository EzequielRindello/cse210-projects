using System;

public class Entry
{
    public string _response;
    public string GetResponse()
    {
        string valid=Console.ReadLine();
        _response=valid;
        return _response;
    }
}