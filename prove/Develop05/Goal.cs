public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;
    protected string _goal;

    public Goal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _isComplete = false;
        _goal = "";
    }

    public string SetName()
    {
        Console.WriteLine("What is the name of your goal?");
        string z = Console.ReadLine();
        return this._name = z;
    }

    public string GetName()
    {
        return _name;
    }

    public string SetDescription()
    {
        Console.WriteLine("What is a short description of your goal?");
        string z = Console.ReadLine();
        return this._description = z;

    }

    public string GetDescription()
    {
        return _description;
    }

    public int SetPoints()
    {
        int number;

        while (true)
        {
            Console.WriteLine("what is the amount of points associated with your goal?");
            string input = Console.ReadLine();

            try
            {
                number = Convert.ToInt32(input);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        return this._points = number;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string SetGoal()
    {
        return _goal;
    }

    public virtual string GetGoal()
    {
        return _goal;
    }

    public virtual void RecordEvent()
    {
        _isComplete = true;
    }

    public virtual void Display(int goalNumber)
    {
        Console.WriteLine($"{goalNumber}. [ ] {_name} ({_description} )");
    }

    public virtual void ShowGoalToDelete(int goalNumber)
    {
        Console.WriteLine($"{goalNumber}. {_name}");
    }

}