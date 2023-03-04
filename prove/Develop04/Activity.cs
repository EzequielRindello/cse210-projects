public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayStartingMessageAndGetTime()
    {
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        SetDuration();
    }

    public void SetDuration()
    {
        Console.WriteLine("How long in senconds, would you like for your session?");
        string read = Console.ReadLine();
        int seconds = Int32.Parse(read);
        this._duration = seconds;
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

            if (counter == 5)
            {
                break;
            }
        }
    }

    public void Timer()
    {
        for (int i = 0; i < 6; ++i)
        {
            Console.Write($"\rYou may begin in...{i} ");
            Thread.Sleep(1000);
        }

        Console.Write($"\rYou may begin in... ");
        Console.WriteLine("");
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Weel done!!!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} ");
        PauseSpinner();
    }

}