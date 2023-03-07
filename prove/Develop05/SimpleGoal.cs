public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        _name = GetName();
        _description = GetDescription();
        _points = GetPoints();
        _isComplete = isComplete;
    }

    public override string CreateGoal()
    {
        string x = "[ ]" + " " + _name + " " + "(" + _description + _points + ")";
        this._goal = x;
        return _goal;
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