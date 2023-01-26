using System;

public class Entry
{
    public string _response;
    public string _time;
    public string GetResponse()
    {
        string valid = Console.ReadLine();
        _response = valid;
        return _response;
    }
    public string Time()
    {
        DateTime timeOnly = new DateTime(DateTime.Now.TimeOfDay.Ticks);
        string date_str = timeOnly.ToString("dd/MM/yyyy HH:mm:ss");
        _time = date_str;
        return _time;
    }
}