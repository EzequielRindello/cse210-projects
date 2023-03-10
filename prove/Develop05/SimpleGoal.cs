public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete) : base() { }

    public override string SetGoal()
    {
        this._name = SetName();
        this._description = SetDescription();
        this._points = SetPoints();
        this._goal = $"{_name},{_description},{_points},{_isComplete}";
        return this._goal;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override void ShowGoal(int goalNumber)
    {
        string checkString = " ";
        if (_isComplete)
            checkString = "X";
        Console.WriteLine($"{goalNumber}. [{checkString}] {_name} ({_description} )");
    }
}