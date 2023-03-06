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
        return Console.ReadLine();
    }

    public string GetDescription()
    {
        Console.WriteLine("What is a short description of your goal?");
        return Console.ReadLine();
    }

    public int GetPoints()
    {
        Console.WriteLine("what is the amount of points associated with your goal?");
        return Console.Read();
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