public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;
    protected string _goal;

    public Goal(string name, string description, int points, bool isComplete, string goal)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
        _goal = goal;
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
        Console.WriteLine("what is the amount of points associated with your goal?");
        int z = int.Parse(Console.ReadLine());
        return this._points = z;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string SetGoal()
    {
        return _goal;
    }

    public string GetGoal()
    {
        return _goal;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

}