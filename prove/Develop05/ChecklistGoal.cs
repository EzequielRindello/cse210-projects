public class ChecklistGoal : Goal
{
    private int _howManyTimes;
    private int _currentTimes;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, bool isComplete, int currentCount, int howManyTimes, int bonus) : base() { }

    public override string SetGoal()
    {
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._bonus = SetBonus();
        this._howManyTimes = SetHowManyTimes();
        string x = $"ChecklistGoal,{_name},{_description},{_points},{_isComplete},{_currentTimes},{_howManyTimes},{_bonus}";
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
        _currentTimes++;
        if (_currentTimes == _howManyTimes)
        {
            _isComplete = true;
        }
    }

    public override void ShowGoal(int goalNumber)
    {
        string checkString = " ";
        if (_isComplete)
            checkString = "X";
        Console.WriteLine($"{goalNumber}. [{checkString}] {_name} ({_description}) -----Currently complete {_currentTimes}/ {_howManyTimes}");
    }
    
    public override bool IsComplete()
    {
        return _isComplete;
    }
}