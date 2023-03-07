public class ChecklistGoal : Goal
{
    private int _howManyTimes;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = GetName();
        _description = GetDescription();
        _points = GetPoints();
        _isComplete = isComplete;
    }

    public override string CreateGoal()
    {
        GetName();
        GetDescription();
        GetPoints();
        GetHowManyTimes();
        GetBonus();
        string x = "[ ]" + " " + _name + " " + "(" + _description + _points + ")";
        this._goal = x;
        return _goal;
    }

    public int GetHowManyTimes()
    {
        Console.WriteLine("what is the amount of points associated with your goal?");
        int z = Console.Read();
        this._howManyTimes = z;
        return _howManyTimes;
    }

    public int GetBonus()
    {
        Console.WriteLine("what is the amount of points associated with your goal?");
        int z = Console.Read();
        this._bonus = z;
        return _bonus;
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return true;
    }
}