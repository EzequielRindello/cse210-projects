public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {

    }

    public void GetReadyMessage()
    {

    }

    public void PauseSpinner()
    {
        int counter=0;
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
            if (counter==10)
            {
                break;
            }
        }
    }

    public void DisplayEndingMessage()
    {

    }
}