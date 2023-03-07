public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;
    protected string _goal;

    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public string GetName()
    {
        Console.WriteLine("What is the name of your goal?");
        string z = Console.ReadLine();
        this._name = z;
        return _name;
    }

    public string GetDescription()
    {
        Console.WriteLine("What is a short description of your goal?");
        string z = Console.ReadLine();
        this._description = z;
        return _description;
    }

    public int GetPoints()
    {
        Console.WriteLine("what is the amount of points associated with your goal?");
        int z = Console.Read();
        this._points = z;
        return _points;
    }

    public virtual string CreateGoal()
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