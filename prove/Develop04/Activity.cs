public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("Enter any key to continue. All activities last 40 seconds by default :)");
        string none = Console.ReadLine();
    }

    public void GetReadyMessage()
    {
        Console.WriteLine("Get Ready...");
        PauseSpinner();
    }

    public void PauseSpinner()
    {
        int counter = 0;
        while (true)
        {
            counter++;
            switch (counter % 4)
            {
                case 0:
                    Console.Write("/");
                    Thread.Sleep(650);
                    break;
                case 1:
                    Console.Write("-");
                    Thread.Sleep(650);
                    break;
                case 2:
                    Console.Write("\\");
                    Thread.Sleep(650);
                    break;
                case 3:
                    Console.Write("|");
                    Thread.Sleep(650);
                    break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            if (counter == 10)
            {
                break;
            }
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Weel done!!!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} ");
        PauseSpinner();
    }
}