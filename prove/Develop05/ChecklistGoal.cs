public class ChecklistGoal : Goal
{
    private int _howManyTimes;
    private int _bonus;

    public ChecklistGoal() : base() { }

    public override string SetGoal()
    {
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._bonus = SetBonus();
        this._howManyTimes = SetHowManyTimes();
        string x = "[ ]" + " " + _name + " " + "(" + _description + ")" + " " + _points;
        return this._goal = x;
    }

    public int SetHowManyTimes()
    {
        Console.WriteLine("How many times do you have to complete this goal to get the bonus?");
        int z = Console.Read();
        this._howManyTimes = z;
        return _howManyTimes;
    }

    public int GetHowManyTimes()
    {
        return _howManyTimes;
    }

    public int SetBonus()
    {
        Console.WriteLine("What is the bonus associated for this goal?");
        int z = Console.Read();
        this._bonus = z;
        return _bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _isComplete = true;  
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
}