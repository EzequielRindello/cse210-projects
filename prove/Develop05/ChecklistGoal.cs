public class ChecklistGoal : Goal
{
    private int _howManyTimes;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = GetName();
        _description = GetDescription();
        _points = GetPoints();
        _bonus = GetBonus();
        _howManyTimes = GetHowManyTimes();
        _isComplete = isComplete;
    }

    public override string CreateGoal()
    {
        string x = "[ ]" + " " + _name + " " + "(" + _description + _points + ")";
        return this._goal = x;
    }

    public int GetHowManyTimes()
    {
        Console.WriteLine("How many times do you have to complete this goal to get the bonus?");
        int z = Console.Read();
        this._howManyTimes = z;
        return _howManyTimes;
    }

    public int GetBonus()
    {
        Console.WriteLine("What is the bonus associated for this goal?");
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