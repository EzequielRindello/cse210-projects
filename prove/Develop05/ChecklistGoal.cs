public class ChecklistGoal : Goal
{
    private int _howManyTimes;
    private int _currentTimes;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, bool isComplete, int currentCount, int howManyTimes, int bonus) : base()
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
        _howManyTimes = 0;
        _currentTimes = 0;
        _bonus = 0;
    }

    public override string SetGoal()
    {
        string x = $"ChecklistGoal,{_name},{_description},{_points},{_isComplete},{_currentTimes},{_howManyTimes},{_bonus}";
        return this._goal = x;
    }

    public void SetBonus()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _howManyTimes = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent()
    {
        _currentTimes++;
        if (_currentTimes == _howManyTimes)
        {
            _isComplete = true;
        }
    }

    public override void Display(int goalNumber)
    {
        string checkString = " ";
        if (_isComplete)
            checkString = "X";
        Console.WriteLine($"{goalNumber}. [{checkString}] {_name} ({_description}) -----Currently complete {_currentTimes}/ {_howManyTimes}");
    }

}